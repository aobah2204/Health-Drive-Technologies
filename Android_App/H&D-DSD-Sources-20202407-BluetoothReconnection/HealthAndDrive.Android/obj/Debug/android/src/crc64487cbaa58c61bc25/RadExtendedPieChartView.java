package crc64487cbaa58c61bc25;


public class RadExtendedPieChartView
	extends com.telerik.widget.chart.visualization.pieChart.RadPieChartView
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onMeasure:(II)V:GetOnMeasure_IIHandler\n" +
			"";
		mono.android.Runtime.register ("Telerik.XamarinForms.ChartRenderer.Android.RadExtendedPieChartView, Telerik.XamarinForms.Chart", RadExtendedPieChartView.class, __md_methods);
	}


	public RadExtendedPieChartView (android.content.Context p0)
	{
		super (p0);
		if (getClass () == RadExtendedPieChartView.class)
			mono.android.TypeManager.Activate ("Telerik.XamarinForms.ChartRenderer.Android.RadExtendedPieChartView, Telerik.XamarinForms.Chart", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public RadExtendedPieChartView (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == RadExtendedPieChartView.class)
			mono.android.TypeManager.Activate ("Telerik.XamarinForms.ChartRenderer.Android.RadExtendedPieChartView, Telerik.XamarinForms.Chart", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public void onMeasure (int p0, int p1)
	{
		n_onMeasure (p0, p1);
	}

	private native void n_onMeasure (int p0, int p1);

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
