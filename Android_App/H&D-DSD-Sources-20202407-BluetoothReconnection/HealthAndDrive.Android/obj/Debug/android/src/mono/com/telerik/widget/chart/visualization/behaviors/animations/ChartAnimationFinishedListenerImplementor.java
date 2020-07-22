package mono.com.telerik.widget.chart.visualization.behaviors.animations;


public class ChartAnimationFinishedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.telerik.widget.chart.visualization.behaviors.animations.ChartAnimationFinishedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onAnimationFinished:(Lcom/telerik/widget/chart/visualization/behaviors/animations/ChartAnimation;Lcom/telerik/widget/chart/visualization/behaviors/views/SeriesAnimationView;)V:GetOnAnimationFinished_Lcom_telerik_widget_chart_visualization_behaviors_animations_ChartAnimation_Lcom_telerik_widget_chart_visualization_behaviors_views_SeriesAnimationView_Handler:Com.Telerik.Widget.Chart.Visualization.Behaviors.Animations.IChartAnimationFinishedListenerInvoker, Telerik.Xamarin.Android.Chart\n" +
			"";
		mono.android.Runtime.register ("Com.Telerik.Widget.Chart.Visualization.Behaviors.Animations.IChartAnimationFinishedListenerImplementor, Telerik.Xamarin.Android.Chart", ChartAnimationFinishedListenerImplementor.class, __md_methods);
	}


	public ChartAnimationFinishedListenerImplementor ()
	{
		super ();
		if (getClass () == ChartAnimationFinishedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Telerik.Widget.Chart.Visualization.Behaviors.Animations.IChartAnimationFinishedListenerImplementor, Telerik.Xamarin.Android.Chart", "", this, new java.lang.Object[] {  });
	}


	public void onAnimationFinished (com.telerik.widget.chart.visualization.behaviors.animations.ChartAnimation p0, com.telerik.widget.chart.visualization.behaviors.views.SeriesAnimationView p1)
	{
		n_onAnimationFinished (p0, p1);
	}

	private native void n_onAnimationFinished (com.telerik.widget.chart.visualization.behaviors.animations.ChartAnimation p0, com.telerik.widget.chart.visualization.behaviors.views.SeriesAnimationView p1);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
