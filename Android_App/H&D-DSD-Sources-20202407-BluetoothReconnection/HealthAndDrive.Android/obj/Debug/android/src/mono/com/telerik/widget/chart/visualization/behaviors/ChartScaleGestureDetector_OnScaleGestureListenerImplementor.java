package mono.com.telerik.widget.chart.visualization.behaviors;


public class ChartScaleGestureDetector_OnScaleGestureListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.telerik.widget.chart.visualization.behaviors.ChartScaleGestureDetector.OnScaleGestureListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onScale:(Lcom/telerik/widget/chart/visualization/behaviors/ChartScaleGestureDetector;)Z:GetOnScale_Lcom_telerik_widget_chart_visualization_behaviors_ChartScaleGestureDetector_Handler:Com.Telerik.Widget.Chart.Visualization.Behaviors.ChartScaleGestureDetector/IOnScaleGestureListenerInvoker, Telerik.Xamarin.Android.Chart\n" +
			"n_onScaleBegin:(Lcom/telerik/widget/chart/visualization/behaviors/ChartScaleGestureDetector;)Z:GetOnScaleBegin_Lcom_telerik_widget_chart_visualization_behaviors_ChartScaleGestureDetector_Handler:Com.Telerik.Widget.Chart.Visualization.Behaviors.ChartScaleGestureDetector/IOnScaleGestureListenerInvoker, Telerik.Xamarin.Android.Chart\n" +
			"n_onScaleEnd:(Lcom/telerik/widget/chart/visualization/behaviors/ChartScaleGestureDetector;)V:GetOnScaleEnd_Lcom_telerik_widget_chart_visualization_behaviors_ChartScaleGestureDetector_Handler:Com.Telerik.Widget.Chart.Visualization.Behaviors.ChartScaleGestureDetector/IOnScaleGestureListenerInvoker, Telerik.Xamarin.Android.Chart\n" +
			"";
		mono.android.Runtime.register ("Com.Telerik.Widget.Chart.Visualization.Behaviors.ChartScaleGestureDetector+IOnScaleGestureListenerImplementor, Telerik.Xamarin.Android.Chart", ChartScaleGestureDetector_OnScaleGestureListenerImplementor.class, __md_methods);
	}


	public ChartScaleGestureDetector_OnScaleGestureListenerImplementor ()
	{
		super ();
		if (getClass () == ChartScaleGestureDetector_OnScaleGestureListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Telerik.Widget.Chart.Visualization.Behaviors.ChartScaleGestureDetector+IOnScaleGestureListenerImplementor, Telerik.Xamarin.Android.Chart", "", this, new java.lang.Object[] {  });
	}


	public boolean onScale (com.telerik.widget.chart.visualization.behaviors.ChartScaleGestureDetector p0)
	{
		return n_onScale (p0);
	}

	private native boolean n_onScale (com.telerik.widget.chart.visualization.behaviors.ChartScaleGestureDetector p0);


	public boolean onScaleBegin (com.telerik.widget.chart.visualization.behaviors.ChartScaleGestureDetector p0)
	{
		return n_onScaleBegin (p0);
	}

	private native boolean n_onScaleBegin (com.telerik.widget.chart.visualization.behaviors.ChartScaleGestureDetector p0);


	public void onScaleEnd (com.telerik.widget.chart.visualization.behaviors.ChartScaleGestureDetector p0)
	{
		n_onScaleEnd (p0);
	}

	private native void n_onScaleEnd (com.telerik.widget.chart.visualization.behaviors.ChartScaleGestureDetector p0);

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
