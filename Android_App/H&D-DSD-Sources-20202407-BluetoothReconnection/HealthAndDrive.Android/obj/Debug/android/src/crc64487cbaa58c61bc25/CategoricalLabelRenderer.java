package crc64487cbaa58c61bc25;


public class CategoricalLabelRenderer
	extends com.telerik.widget.chart.visualization.cartesianChart.series.categorical.CategoricalSeriesLabelRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getLabelText:(Lcom/telerik/widget/chart/engine/dataPoints/DataPoint;)Ljava/lang/String;:GetGetLabelText_Lcom_telerik_widget_chart_engine_dataPoints_DataPoint_Handler\n" +
			"";
		mono.android.Runtime.register ("Telerik.XamarinForms.ChartRenderer.Android.CategoricalLabelRenderer, Telerik.XamarinForms.Chart", CategoricalLabelRenderer.class, __md_methods);
	}


	public CategoricalLabelRenderer (com.telerik.widget.chart.visualization.common.ChartSeries p0)
	{
		super (p0);
		if (getClass () == CategoricalLabelRenderer.class)
			mono.android.TypeManager.Activate ("Telerik.XamarinForms.ChartRenderer.Android.CategoricalLabelRenderer, Telerik.XamarinForms.Chart", "Com.Telerik.Widget.Chart.Visualization.Common.ChartSeries, Telerik.Xamarin.Android.Chart", this, new java.lang.Object[] { p0 });
	}


	public java.lang.String getLabelText (com.telerik.widget.chart.engine.dataPoints.DataPoint p0)
	{
		return n_getLabelText (p0);
	}

	private native java.lang.String n_getLabelText (com.telerik.widget.chart.engine.dataPoints.DataPoint p0);

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
