package crc648f4167c40236b0a7;


public class AndroidSlotDayViewAdapter
	extends com.telerik.widget.calendar.dayview.SlotDayViewAdapter
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getSlotView:(Lcom/telerik/widget/calendar/slots/SpecialSlot;J)Landroid/view/View;:GetGetSlotView_Lcom_telerik_widget_calendar_slots_SpecialSlot_JHandler\n" +
			"";
		mono.android.Runtime.register ("Telerik.XamarinForms.InputRenderer.Android.AndroidSlotDayViewAdapter, Telerik.XamarinForms.Input", AndroidSlotDayViewAdapter.class, __md_methods);
	}


	public AndroidSlotDayViewAdapter (android.content.Context p0)
	{
		super (p0);
		if (getClass () == AndroidSlotDayViewAdapter.class)
			mono.android.TypeManager.Activate ("Telerik.XamarinForms.InputRenderer.Android.AndroidSlotDayViewAdapter, Telerik.XamarinForms.Input", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public android.view.View getSlotView (com.telerik.widget.calendar.slots.SpecialSlot p0, long p1)
	{
		return n_getSlotView (p0, p1);
	}

	private native android.view.View n_getSlotView (com.telerik.widget.calendar.slots.SpecialSlot p0, long p1);

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
