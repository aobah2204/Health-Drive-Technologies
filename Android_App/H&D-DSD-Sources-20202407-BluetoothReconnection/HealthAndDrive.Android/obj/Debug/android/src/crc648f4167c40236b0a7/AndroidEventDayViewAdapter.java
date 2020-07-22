package crc648f4167c40236b0a7;


public class AndroidEventDayViewAdapter
	extends com.telerik.widget.calendar.dayview.EventDayViewAdapter
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getView:(Lcom/telerik/widget/calendar/events/Event;J)Landroid/view/View;:GetGetView_Lcom_telerik_widget_calendar_events_Event_JHandler\n" +
			"";
		mono.android.Runtime.register ("Telerik.XamarinForms.InputRenderer.Android.AndroidEventDayViewAdapter, Telerik.XamarinForms.Input", AndroidEventDayViewAdapter.class, __md_methods);
	}


	public AndroidEventDayViewAdapter (android.content.Context p0)
	{
		super (p0);
		if (getClass () == AndroidEventDayViewAdapter.class)
			mono.android.TypeManager.Activate ("Telerik.XamarinForms.InputRenderer.Android.AndroidEventDayViewAdapter, Telerik.XamarinForms.Input", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public android.view.View getView (com.telerik.widget.calendar.events.Event p0, long p1)
	{
		return n_getView (p0, p1);
	}

	private native android.view.View n_getView (com.telerik.widget.calendar.events.Event p0, long p1);

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
