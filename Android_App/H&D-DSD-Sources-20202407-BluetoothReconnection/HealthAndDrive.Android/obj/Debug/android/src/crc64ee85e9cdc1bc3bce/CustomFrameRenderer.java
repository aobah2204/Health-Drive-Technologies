package crc64ee85e9cdc1bc3bce;


public class CustomFrameRenderer
	extends crc64720bb2db43a66fe9.FrameRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("HealthAndDrive.Droid.Renderers.CustomFrameRenderer, HealthAndDrive.Android", CustomFrameRenderer.class, __md_methods);
	}


	public CustomFrameRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == CustomFrameRenderer.class)
			mono.android.TypeManager.Activate ("HealthAndDrive.Droid.Renderers.CustomFrameRenderer, HealthAndDrive.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public CustomFrameRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == CustomFrameRenderer.class)
			mono.android.TypeManager.Activate ("HealthAndDrive.Droid.Renderers.CustomFrameRenderer, HealthAndDrive.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public CustomFrameRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == CustomFrameRenderer.class)
			mono.android.TypeManager.Activate ("HealthAndDrive.Droid.Renderers.CustomFrameRenderer, HealthAndDrive.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
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
