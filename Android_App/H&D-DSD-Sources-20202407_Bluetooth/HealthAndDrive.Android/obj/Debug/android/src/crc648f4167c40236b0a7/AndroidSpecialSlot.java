package crc648f4167c40236b0a7;


public class AndroidSpecialSlot
	extends com.telerik.widget.calendar.slots.SpecialSlot
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Telerik.XamarinForms.InputRenderer.Android.AndroidSpecialSlot, Telerik.XamarinForms.Input", AndroidSpecialSlot.class, __md_methods);
	}


	public AndroidSpecialSlot (long p0, long p1)
	{
		super (p0, p1);
		if (getClass () == AndroidSpecialSlot.class)
			mono.android.TypeManager.Activate ("Telerik.XamarinForms.InputRenderer.Android.AndroidSpecialSlot, Telerik.XamarinForms.Input", "System.Int64, mscorlib:System.Int64, mscorlib", this, new java.lang.Object[] { p0, p1 });
	}

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
