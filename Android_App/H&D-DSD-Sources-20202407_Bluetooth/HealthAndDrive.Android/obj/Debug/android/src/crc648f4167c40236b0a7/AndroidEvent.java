package crc648f4167c40236b0a7;


public class AndroidEvent
	extends com.telerik.widget.calendar.events.Event
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Telerik.XamarinForms.InputRenderer.Android.AndroidEvent, Telerik.XamarinForms.Input", AndroidEvent.class, __md_methods);
	}


	public AndroidEvent (java.lang.String p0, long p1, long p2)
	{
		super (p0, p1, p2);
		if (getClass () == AndroidEvent.class)
			mono.android.TypeManager.Activate ("Telerik.XamarinForms.InputRenderer.Android.AndroidEvent, Telerik.XamarinForms.Input", "System.String, mscorlib:System.Int64, mscorlib:System.Int64, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
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
