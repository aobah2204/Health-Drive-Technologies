package crc644b19d71eeb53ff67;


public class RadViewContainer
	extends crc644b19d71eeb53ff67.RadViewContainerBase
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onSizeChanged:(IIII)V:GetOnSizeChanged_IIIIHandler\n" +
			"";
		mono.android.Runtime.register ("Telerik.XamarinForms.Common.Android.RadViewContainer, Telerik.XamarinForms.Common", RadViewContainer.class, __md_methods);
	}


	public RadViewContainer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == RadViewContainer.class)
			mono.android.TypeManager.Activate ("Telerik.XamarinForms.Common.Android.RadViewContainer, Telerik.XamarinForms.Common", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public RadViewContainer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == RadViewContainer.class)
			mono.android.TypeManager.Activate ("Telerik.XamarinForms.Common.Android.RadViewContainer, Telerik.XamarinForms.Common", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public RadViewContainer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == RadViewContainer.class)
			mono.android.TypeManager.Activate ("Telerik.XamarinForms.Common.Android.RadViewContainer, Telerik.XamarinForms.Common", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public void onSizeChanged (int p0, int p1, int p2, int p3)
	{
		n_onSizeChanged (p0, p1, p2, p3);
	}

	private native void n_onSizeChanged (int p0, int p1, int p2, int p3);

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
