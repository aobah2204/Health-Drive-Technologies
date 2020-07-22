package mono.com.telerik.widget.calendar.dayview;


public class DayViewTimeSlotTappedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.telerik.widget.calendar.dayview.DayViewTimeSlotTappedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onTimeSlotTapped:(JJJ[Ljava/lang/Object;)V:GetOnTimeSlotTapped_JJJarrayLjava_lang_Object_Handler:Com.Telerik.Widget.Calendar.Dayview.IDayViewTimeSlotTappedListenerInvoker, Telerik.Xamarin.Android.Input\n" +
			"";
		mono.android.Runtime.register ("Com.Telerik.Widget.Calendar.Dayview.IDayViewTimeSlotTappedListenerImplementor, Telerik.Xamarin.Android.Input", DayViewTimeSlotTappedListenerImplementor.class, __md_methods);
	}


	public DayViewTimeSlotTappedListenerImplementor ()
	{
		super ();
		if (getClass () == DayViewTimeSlotTappedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Telerik.Widget.Calendar.Dayview.IDayViewTimeSlotTappedListenerImplementor, Telerik.Xamarin.Android.Input", "", this, new java.lang.Object[] {  });
	}


	public void onTimeSlotTapped (long p0, long p1, long p2, java.lang.Object[] p3)
	{
		n_onTimeSlotTapped (p0, p1, p2, p3);
	}

	private native void n_onTimeSlotTapped (long p0, long p1, long p2, java.lang.Object[] p3);

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
