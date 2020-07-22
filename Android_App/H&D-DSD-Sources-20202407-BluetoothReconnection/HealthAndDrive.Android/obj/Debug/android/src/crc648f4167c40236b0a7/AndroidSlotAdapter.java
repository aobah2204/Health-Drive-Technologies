package crc648f4167c40236b0a7;


public class AndroidSlotAdapter
	extends com.telerik.widget.calendar.slots.SlotAdapter
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getSlotsForDate:(J)Ljava/util/List;:GetGetSlotsForDate_JHandler\n" +
			"";
		mono.android.Runtime.register ("Telerik.XamarinForms.InputRenderer.Android.AndroidSlotAdapter, Telerik.XamarinForms.Input", AndroidSlotAdapter.class, __md_methods);
	}


	public AndroidSlotAdapter (com.telerik.widget.calendar.RadCalendarView p0)
	{
		super (p0);
		if (getClass () == AndroidSlotAdapter.class)
			mono.android.TypeManager.Activate ("Telerik.XamarinForms.InputRenderer.Android.AndroidSlotAdapter, Telerik.XamarinForms.Input", "Com.Telerik.Widget.Calendar.RadCalendarView, Telerik.Xamarin.Android.Input", this, new java.lang.Object[] { p0 });
	}


	public AndroidSlotAdapter (com.telerik.widget.calendar.RadCalendarView p0, java.util.List p1)
	{
		super (p0, p1);
		if (getClass () == AndroidSlotAdapter.class)
			mono.android.TypeManager.Activate ("Telerik.XamarinForms.InputRenderer.Android.AndroidSlotAdapter, Telerik.XamarinForms.Input", "Com.Telerik.Widget.Calendar.RadCalendarView, Telerik.Xamarin.Android.Input:System.Collections.Generic.IList`1<Com.Telerik.Widget.Calendar.Slots.SpecialSlot>, mscorlib", this, new java.lang.Object[] { p0, p1 });
	}


	public java.util.List getSlotsForDate (long p0)
	{
		return n_getSlotsForDate (p0);
	}

	private native java.util.List n_getSlotsForDate (long p0);

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
