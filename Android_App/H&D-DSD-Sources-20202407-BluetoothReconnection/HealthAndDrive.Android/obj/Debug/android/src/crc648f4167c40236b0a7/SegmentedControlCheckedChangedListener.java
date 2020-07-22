package crc648f4167c40236b0a7;


public class SegmentedControlCheckedChangedListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.widget.RadioGroup.OnCheckedChangeListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCheckedChanged:(Landroid/widget/RadioGroup;I)V:GetOnCheckedChanged_Landroid_widget_RadioGroup_IHandler:Android.Widget.RadioGroup/IOnCheckedChangeListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("Telerik.XamarinForms.InputRenderer.Android.SegmentedControlCheckedChangedListener, Telerik.XamarinForms.Input", SegmentedControlCheckedChangedListener.class, __md_methods);
	}


	public SegmentedControlCheckedChangedListener ()
	{
		super ();
		if (getClass () == SegmentedControlCheckedChangedListener.class)
			mono.android.TypeManager.Activate ("Telerik.XamarinForms.InputRenderer.Android.SegmentedControlCheckedChangedListener, Telerik.XamarinForms.Input", "", this, new java.lang.Object[] {  });
	}


	public void onCheckedChanged (android.widget.RadioGroup p0, int p1)
	{
		n_onCheckedChanged (p0, p1);
	}

	private native void n_onCheckedChanged (android.widget.RadioGroup p0, int p1);

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
