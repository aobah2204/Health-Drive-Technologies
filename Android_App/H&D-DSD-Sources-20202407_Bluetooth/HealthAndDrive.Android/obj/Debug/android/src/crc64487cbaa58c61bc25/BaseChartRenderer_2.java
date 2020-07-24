package crc64487cbaa58c61bc25;


public abstract class BaseChartRenderer_2
	extends crc644b19d71eeb53ff67.AndroidRendererBase_2
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Telerik.XamarinForms.ChartRenderer.Android.BaseChartRenderer`2, Telerik.XamarinForms.Chart", BaseChartRenderer_2.class, __md_methods);
	}


	public BaseChartRenderer_2 (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == BaseChartRenderer_2.class)
			mono.android.TypeManager.Activate ("Telerik.XamarinForms.ChartRenderer.Android.BaseChartRenderer`2, Telerik.XamarinForms.Chart", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public BaseChartRenderer_2 (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == BaseChartRenderer_2.class)
			mono.android.TypeManager.Activate ("Telerik.XamarinForms.ChartRenderer.Android.BaseChartRenderer`2, Telerik.XamarinForms.Chart", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public BaseChartRenderer_2 (android.content.Context p0)
	{
		super (p0);
		if (getClass () == BaseChartRenderer_2.class)
			mono.android.TypeManager.Activate ("Telerik.XamarinForms.ChartRenderer.Android.BaseChartRenderer`2, Telerik.XamarinForms.Chart", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
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
