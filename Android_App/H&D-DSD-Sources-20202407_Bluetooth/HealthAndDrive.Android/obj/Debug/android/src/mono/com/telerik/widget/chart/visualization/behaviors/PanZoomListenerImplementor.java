package mono.com.telerik.widget.chart.visualization.behaviors;


public class PanZoomListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.telerik.widget.chart.visualization.behaviors.PanZoomListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onPan:(DD)V:GetOnPan_DDHandler:Com.Telerik.Widget.Chart.Visualization.Behaviors.IPanZoomListenerInvoker, Telerik.Xamarin.Android.Chart\n" +
			"n_onZoom:(DD)V:GetOnZoom_DDHandler:Com.Telerik.Widget.Chart.Visualization.Behaviors.IPanZoomListenerInvoker, Telerik.Xamarin.Android.Chart\n" +
			"";
		mono.android.Runtime.register ("Com.Telerik.Widget.Chart.Visualization.Behaviors.IPanZoomListenerImplementor, Telerik.Xamarin.Android.Chart", PanZoomListenerImplementor.class, __md_methods);
	}


	public PanZoomListenerImplementor ()
	{
		super ();
		if (getClass () == PanZoomListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Telerik.Widget.Chart.Visualization.Behaviors.IPanZoomListenerImplementor, Telerik.Xamarin.Android.Chart", "", this, new java.lang.Object[] {  });
	}


	public void onPan (double p0, double p1)
	{
		n_onPan (p0, p1);
	}

	private native void n_onPan (double p0, double p1);


	public void onZoom (double p0, double p1)
	{
		n_onZoom (p0, p1);
	}

	private native void n_onZoom (double p0, double p1);

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
