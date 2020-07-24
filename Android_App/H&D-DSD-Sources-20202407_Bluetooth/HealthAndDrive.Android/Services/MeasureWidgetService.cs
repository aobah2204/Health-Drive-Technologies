using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Provider;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using static Android.Views.View;
using Prism.Events;
using HealthAndDrive.Events.Notifications;
using HealthAndDrive.Models;
using HealthAndDrive.Events;
using HealthAndDrive.Droid.Services;
using HealthAndDrive.Services;
using HealthAndDrive.Tools;
using Xamarin.Essentials;
using HealthAndDrive.RepositoryContracts;
using System.Threading.Tasks;
using Android.Util;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter;

namespace HealthAndDrive.Droid.Services
{
    [Service]
    public class MeasureWidgetService : Service, IOnTouchListener, IFloatingWidgetService
    {
        private const int CLOSING_THRESHOLD = 120;
        private const float WIDGET_TAP_SENSIBILITY_PERCENTAGE = 2f;
        private IWindowManager windowManager;
        private WindowManagerLayoutParams layoutParams;
        private View floatingView;
        private TextView measureValueView;

        private TextView bloodSugarEvolution;
        private TextView unit;
        private TextView bloodSugarLevel;

        private int initialX;
        private int initialY;
        private float initialTouchX;
        private float initialTouchY;

        private int centerX;
        private int centerY;

        private IUserRepository userRepository;

        private Action<NotificationMeasure> actionRefresh;

        private AppSettings appSettings;

        private bool isEnable;
        public bool IsEnable
        {
            get { return isEnable; }
            set
            {
                isEnable = value;
                if (isEnable)
                {
                    IsWidgetEnabled?.Invoke(this, EventArgs.Empty);
                }
            }
        }
        public event EventHandler IsWidgetEnabled;


        /// <summary>
        /// Gets or sets the arrow direction.
        /// </summary>
        public WidgetArrowDirection ArrowDirection
        {
            get { return (WidgetArrowDirection)Convert.ToChar(bloodSugarEvolution.Text); }
            set { bloodSugarEvolution.Text = Convert.ToString((char)value); }
        }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        public string Text
        {
            get { return bloodSugarLevel.Text; }
            set { bloodSugarLevel.Text = value; }
        }

        /// <summary>
        /// Gets or sets the text color value.
        /// </summary>
        public WidgetTextColor TextColor
        {
            get { return (WidgetTextColor)bloodSugarLevel.CurrentTextColor; }
            set
            {
                Color color = new Color(Convert.ToInt32(value));

                bloodSugarLevel.SetTextColor(color);
                unit.SetTextColor(color);
                bloodSugarEvolution.SetTextColor(color);
            }
        }

        /// <summary>
        /// Count the tap number on widget to avoid double click
        /// </summary>
        private int tapCount = 0;

        /// <summary>
        /// Set default appearance: the text becomes "---", the text color is gray and the arrow points to the right.
        /// </summary>
        public void DefaultState()
        {
            Text = "---";
            TextColor = WidgetTextColor.gray;
            ArrowDirection = WidgetArrowDirection.right;
        }

        public override IBinder OnBind(Intent intent)
        {
            throw null;
        }

        public override void OnCreate()
        {
            base.OnCreate();

            floatingView = LayoutInflater.From(this).Inflate(Resource.Layout.floatingWidget, null);

            bloodSugarLevel = floatingView.FindViewById<TextView>(Resource.Id.bloodSugarLevel);
            unit = floatingView.FindViewById<TextView>(Resource.Id.unit);
            bloodSugarEvolution = floatingView.FindViewById<TextView>(Resource.Id.bloodSugarEvolution);

            appSettings = (AppSettings)App.Current.Container.Resolve(typeof(AppSettings));

            //Repo init
            userRepository = (IUserRepository)App.Current.Container.Resolve(typeof(IUserRepository));
            IUserSettingsRepository userSettingsRepository = (IUserSettingsRepository)App.Current.Container.Resolve(typeof(IUserSettingsRepository));
            var userSettings = userSettingsRepository.GetCurrentUserSettings();
            User currentUsr = userRepository.GetCurrentUser();

            SetTouchListener();

            windowManager = GetSystemService(WindowService).JavaCast<IWindowManager>();

            WindowManagerTypes LAYOUT_FLAG = Build.VERSION.SdkInt <  Android.OS.BuildVersionCodes.O ? WindowManagerTypes.Phone : WindowManagerTypes.ApplicationOverlay;
            layoutParams = new WindowManagerLayoutParams(ViewGroup.LayoutParams.WrapContent,
                                                         ViewGroup.LayoutParams.WrapContent,
                                                         LAYOUT_FLAG,
                                                         WindowManagerFlags.NotFocusable,
                                                         Format.Translucent)
            {
                Gravity = GravityFlags.Left | GravityFlags.CenterVertical,
                X = currentUsr.WidgetPositionX,
                Y = currentUsr.WidgetPositionY

            };
            if (Settings.CanDrawOverlays(this))
            {
                windowManager.AddView(floatingView, layoutParams);
            }

            SetCenter();

            //Fill the widget with default values
            DefaultState();

            //Startup data refreshed management
            DateTimeOffset empty = new DateTimeOffset();
            if (currentUsr != null && currentUsr.GetMeasureTrend() != MeasureTrend.None)
            {
                NotificationMeasure notif = new NotificationMeasure();
                notif.NewMeasure = currentUsr.CurrentMeasure;
                notif.MaximumGlucoseTreshold = userSettings.MaximumGlucoseTreshold;
                notif.MinimumGlucoseTreshold = userSettings.MinimumGlucoseTreshold;
                notif.MeasureTrend = currentUsr.GetMeasureTrend();
                RefreshDatas(notif);
            }

            IEventAggregator eventAggregator = (IEventAggregator)App.Current.Container.Resolve(typeof(IEventAggregator));
            actionRefresh = new Action<NotificationMeasure>((notification) => { this.RefreshDatas(notification); });
            eventAggregator.GetEvent<NotificationMeasureEvent>().Subscribe(actionRefresh);

            eventAggregator.GetEvent<ExitApplicationEvent>().Publish();

            Analytics.TrackEvent(AnalyticsEvent.WidgetViewed);

        }

        /// <summary>
        /// Return the new measure into an adequate string
        /// </summary>
        /// <param name="notification"></param>
        /// <returns></returns>
        private string NewMeasureToString(NotificationMeasure notification)
        {
            AppSettings settings = new AppSettings();
            string result = String.Empty;
            if (notification.NewMeasure <= settings.LO_VALUE)
            {
                result = "Lo";
            }
            else if (settings.HI_VALUE <= notification.NewMeasure)
            {
                result = "Hi";
            }
            else
            {
                result = notification.NewMeasure.ToString();
            }
            return result;
        }

        public void RefreshDatas(NotificationMeasure notification)
        {

            try
            {
                bloodSugarLevel.SetText(NewMeasureToString(notification), TextView.BufferType.Normal);

                // compute arrow
                switch (notification.MeasureTrend)
                {
                    case MeasureTrend.Constant:
                        ArrowDirection = WidgetArrowDirection.right;
                        break;
                    case MeasureTrend.Decreasing:
                        ArrowDirection = WidgetArrowDirection.diagonal_down_right;
                        break;
                    case MeasureTrend.DecreasingHeavy:
                        ArrowDirection = WidgetArrowDirection.down;
                        break;
                    case MeasureTrend.Increasing:
                        ArrowDirection = WidgetArrowDirection.diagonal_up_right;
                        break;
                    case MeasureTrend.IncreasingHeavy:
                        ArrowDirection = WidgetArrowDirection.up;
                        break;
                    default:
                        ArrowDirection = WidgetArrowDirection.right;
                        break;
                }

                //compute color
                float currentValue = notification.NewMeasure;
                string color = this.appSettings.COLOR_RED;
                //Rouge low
                if (currentValue < notification.MinimumGlucoseTreshold - (notification.MinimumGlucoseTreshold * 25 / 100))
                {
                    color = this.appSettings.COLOR_RED;
                }
                //Orange foncé low
                else if (notification.MinimumGlucoseTreshold - (notification.MinimumGlucoseTreshold * 25 / 100) <= currentValue && currentValue < notification.MinimumGlucoseTreshold - (notification.MinimumGlucoseTreshold * 15 / 100))
                {
                    color = this.appSettings.COLOR_ORANGE;
                }
                //Orange low
                else if (notification.MinimumGlucoseTreshold - (notification.MinimumGlucoseTreshold * 15 / 100) <= currentValue && currentValue < notification.MinimumGlucoseTreshold)
                {
                    color = this.appSettings.COLOR_YELLOW;
                }
                //Vert
                else if (notification.MinimumGlucoseTreshold <= currentValue && currentValue < notification.MaximumGlucoseTreshold)
                {
                    color = this.appSettings.COLOR_GREEN;
                }
                //Orange high
                else if (notification.MaximumGlucoseTreshold <= currentValue && currentValue < notification.MaximumGlucoseTreshold + (notification.MaximumGlucoseTreshold * 20 / 100))
                {
                    color = this.appSettings.COLOR_YELLOW;
                }
                //Orange foncé high
                else if (notification.MaximumGlucoseTreshold + (notification.MaximumGlucoseTreshold * 20 / 100) <= currentValue && currentValue < notification.MaximumGlucoseTreshold + (notification.MaximumGlucoseTreshold * 35 / 100))
                {
                    color = this.appSettings.COLOR_ORANGE;
                }
                //Rouge high
                else if (notification.MaximumGlucoseTreshold + (notification.MaximumGlucoseTreshold * 35 / 100) <= currentValue)
                {
                    color = this.appSettings.COLOR_RED;
                }
                bloodSugarLevel.SetTextColor(ColorConverters.FromHex(color).ToPlatformColor());
                unit.SetTextColor(ColorConverters.FromHex(color).ToPlatformColor());
                bloodSugarEvolution.SetTextColor(ColorConverters.FromHex(color).ToPlatformColor());
            }
            catch(Exception e)
            {
                Log.Error("MeasureWidgetService", $"RefreshDatas : {e.Message}");
            }
        }

        public override void OnDestroy()
        {
            base.OnDestroy();

            if (floatingView != null)
            {
                windowManager.RemoveViewImmediate(floatingView);
            }

            IEventAggregator eventAggregator = (IEventAggregator)App.Current.Container.Resolve(typeof(IEventAggregator));
            eventAggregator.GetEvent<NotificationMeasureEvent>().Unsubscribe(actionRefresh);
            Dispose();
        }

        public void Dispose()
        {

            windowManager?.Dispose();
            layoutParams?.Dispose();
            floatingView?.Dispose();
            bloodSugarEvolution?.Dispose();
            unit?.Dispose();
            bloodSugarLevel?.Dispose();
        }

        public bool OnTouch(View v, MotionEvent e)
        {
            switch (e.Action)
            {
                case MotionEventActions.Down:
                    initialX = layoutParams.X;
                    initialY = layoutParams.Y;

                    initialTouchX = e.RawX;
                    initialTouchY = e.RawY;

                    return true;

                case MotionEventActions.Move:
                    layoutParams.X = initialX + (int)(e.RawX - initialTouchX);
                    layoutParams.Y = initialY + (int)(e.RawY - initialTouchY);

                    //closeFloatingView.Visibility = ViewStates.Visible;
                    windowManager.UpdateViewLayout(floatingView, layoutParams);

                    return true;

                case MotionEventActions.Up:

                    User CurrentUsr = userRepository.GetCurrentUser();
                    userRepository.UpdateWidgetPositionX(CurrentUsr, layoutParams.X);
                    userRepository.UpdateWidgetPositionY(CurrentUsr, layoutParams.Y);

                    // we calculate the move variation percentage
                    float xVariation = (float)(initialX - layoutParams.X) / initialX * 100;
                    float yVariation = (float)(initialY - layoutParams.Y) / initialY * 100;

                    // if the variation is between 0 and X, then we're good
                    if (
                        ( ((float)0 <= Math.Abs(xVariation)) &&  (Math.Abs(xVariation) <= (float )WIDGET_TAP_SENSIBILITY_PERCENTAGE) ) 
                        && (((float)0 <= Math.Abs(yVariation)) && (Math.Abs(yVariation) <= (float)WIDGET_TAP_SENSIBILITY_PERCENTAGE))
                        && tapCount == 0)
                    {
                        //OnTapWidget manager, start a new activity which fire NotificationClickedOn() from MainActivity
                        tapCount++;

                        if (this.floatingView != null)
                        {
                            this.floatingView.Visibility = ViewStates.Invisible; 
                        }

                        Intent intent = new Intent(this, typeof(MainActivity));
                        intent.SetFlags(ActivityFlags.NewTask);
                        intent.AddCategory(Intent.CategoryLauncher);
                        Application.Context.StartActivity(intent);

                    }                  
                    return true;
            }

            return false;
        }

        private void SetTouchListener()
        {
            var rootContainer = floatingView.FindViewById<LinearLayout>(Resource.Id.root);
            rootContainer.SetOnTouchListener(this);
        }

        private void SetCenter()
        {
            var display = windowManager.DefaultDisplay;
            var size = new Point();
            display.GetSize(size);

            centerX = size.X / 2;
            centerY = size.Y / 2;
        }
    }
} 