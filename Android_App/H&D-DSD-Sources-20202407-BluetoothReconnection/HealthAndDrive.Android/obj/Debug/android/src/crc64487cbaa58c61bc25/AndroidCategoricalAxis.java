package crc64487cbaa58c61bc25;


public class AndroidCategoricalAxis
	extends com.telerik.widget.chart.visualization.cartesianChart.axes.CategoricalAxis
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_createModel:()Lcom/telerik/widget/chart/engine/axes/AxisModel;:GetCreateModelHandler\n" +
			"";
		mono.android.Runtime.register ("Telerik.XamarinForms.ChartRenderer.Android.AndroidCategoricalAxis, Telerik.XamarinForms.Chart", AndroidCategoricalAxis.class, __md_methods);
	}


	public AndroidCategoricalAxis ()
	{
		super ();
		if (getClass () == AndroidCategoricalAxis.class)
			mono.android.TypeManager.Activate ("Telerik.XamarinForms.ChartRenderer.Android.AndroidCategoricalAxis, Telerik.XamarinForms.Chart", "", this, new java.lang.Object[] {  });
	}


	public com.telerik.widget.chart.engine.axes.AxisModel createModel ()
	{
		return n_createModel ();
	}

	private native com.telerik.widget.chart.engine.axes.AxisModel n_createModel ();

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
