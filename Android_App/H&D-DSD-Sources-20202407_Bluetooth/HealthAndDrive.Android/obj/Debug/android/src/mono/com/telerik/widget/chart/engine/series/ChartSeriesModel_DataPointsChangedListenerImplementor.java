package mono.com.telerik.widget.chart.engine.series;


public class ChartSeriesModel_DataPointsChangedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.telerik.widget.chart.engine.series.ChartSeriesModel.DataPointsChangedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onPointAdded:(ILcom/telerik/widget/chart/engine/dataPoints/DataPoint;)V:GetOnPointAdded_ILcom_telerik_widget_chart_engine_dataPoints_DataPoint_Handler:Com.Telerik.Widget.Chart.Engine.Series.ChartSeriesModel/IDataPointsChangedListenerInvoker, Telerik.Xamarin.Android.Chart\n" +
			"n_onPointRemoved:(ILcom/telerik/widget/chart/engine/dataPoints/DataPoint;)V:GetOnPointRemoved_ILcom_telerik_widget_chart_engine_dataPoints_DataPoint_Handler:Com.Telerik.Widget.Chart.Engine.Series.ChartSeriesModel/IDataPointsChangedListenerInvoker, Telerik.Xamarin.Android.Chart\n" +
			"";
		mono.android.Runtime.register ("Com.Telerik.Widget.Chart.Engine.Series.ChartSeriesModel+IDataPointsChangedListenerImplementor, Telerik.Xamarin.Android.Chart", ChartSeriesModel_DataPointsChangedListenerImplementor.class, __md_methods);
	}


	public ChartSeriesModel_DataPointsChangedListenerImplementor ()
	{
		super ();
		if (getClass () == ChartSeriesModel_DataPointsChangedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Telerik.Widget.Chart.Engine.Series.ChartSeriesModel+IDataPointsChangedListenerImplementor, Telerik.Xamarin.Android.Chart", "", this, new java.lang.Object[] {  });
	}


	public void onPointAdded (int p0, com.telerik.widget.chart.engine.dataPoints.DataPoint p1)
	{
		n_onPointAdded (p0, p1);
	}

	private native void n_onPointAdded (int p0, com.telerik.widget.chart.engine.dataPoints.DataPoint p1);


	public void onPointRemoved (int p0, com.telerik.widget.chart.engine.dataPoints.DataPoint p1)
	{
		n_onPointRemoved (p0, p1);
	}

	private native void n_onPointRemoved (int p0, com.telerik.widget.chart.engine.dataPoints.DataPoint p1);

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
