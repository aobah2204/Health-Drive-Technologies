package crc648f4167c40236b0a7;


public class CalendarRenderer
	extends crc644b19d71eeb53ff67.AndroidRendererBase_2
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getSuggestedMinimumHeight:()I:GetGetSuggestedMinimumHeightHandler\n" +
			"n_getSuggestedMinimumWidth:()I:GetGetSuggestedMinimumWidthHandler\n" +
			"";
		mono.android.Runtime.register ("Telerik.XamarinForms.InputRenderer.Android.CalendarRenderer, Telerik.XamarinForms.Input", CalendarRenderer.class, __md_methods);
	}


	public CalendarRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == CalendarRenderer.class)
			mono.android.TypeManager.Activate ("Telerik.XamarinForms.InputRenderer.Android.CalendarRenderer, Telerik.XamarinForms.Input", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public CalendarRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == CalendarRenderer.class)
			mono.android.TypeManager.Activate ("Telerik.XamarinForms.InputRenderer.Android.CalendarRenderer, Telerik.XamarinForms.Input", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public CalendarRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == CalendarRenderer.class)
			mono.android.TypeManager.Activate ("Telerik.XamarinForms.InputRenderer.Android.CalendarRenderer, Telerik.XamarinForms.Input", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public int getSuggestedMinimumHeight ()
	{
		return n_getSuggestedMinimumHeight ();
	}

	private native int n_getSuggestedMinimumHeight ();


	public int getSuggestedMinimumWidth ()
	{
		return n_getSuggestedMinimumWidth ();
	}

	private native int n_getSuggestedMinimumWidth ();

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
