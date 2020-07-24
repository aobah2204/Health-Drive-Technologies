package mono.com.telerik.widget.primitives.legend;


public class LegendTouchListener_LegendItemClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.telerik.widget.primitives.legend.LegendTouchListener.LegendItemClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onItemClick:(Landroid/view/View;I)V:GetOnItemClick_Landroid_view_View_IHandler:Com.Telerik.Widget.Primitives.Legend.LegendTouchListener/ILegendItemClickListenerInvoker, Telerik.Xamarin.Android.Chart\n" +
			"";
		mono.android.Runtime.register ("Com.Telerik.Widget.Primitives.Legend.LegendTouchListener+ILegendItemClickListenerImplementor, Telerik.Xamarin.Android.Chart", LegendTouchListener_LegendItemClickListenerImplementor.class, __md_methods);
	}


	public LegendTouchListener_LegendItemClickListenerImplementor ()
	{
		super ();
		if (getClass () == LegendTouchListener_LegendItemClickListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Telerik.Widget.Primitives.Legend.LegendTouchListener+ILegendItemClickListenerImplementor, Telerik.Xamarin.Android.Chart", "", this, new java.lang.Object[] {  });
	}


	public void onItemClick (android.view.View p0, int p1)
	{
		n_onItemClick (p0, p1);
	}

	private native void n_onItemClick (android.view.View p0, int p1);

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
