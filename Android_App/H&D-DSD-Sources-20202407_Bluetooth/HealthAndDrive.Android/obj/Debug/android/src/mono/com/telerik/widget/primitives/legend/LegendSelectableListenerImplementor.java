package mono.com.telerik.widget.primitives.legend;


public class LegendSelectableListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.telerik.widget.primitives.legend.LegendSelectableListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onLegendObjectSelected:(Z)V:GetOnLegendObjectSelected_ZHandler:Com.Telerik.Widget.Primitives.Legend.ILegendSelectableListenerInvoker, Telerik.Xamarin.Android.Chart\n" +
			"";
		mono.android.Runtime.register ("Com.Telerik.Widget.Primitives.Legend.ILegendSelectableListenerImplementor, Telerik.Xamarin.Android.Chart", LegendSelectableListenerImplementor.class, __md_methods);
	}


	public LegendSelectableListenerImplementor ()
	{
		super ();
		if (getClass () == LegendSelectableListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Telerik.Widget.Primitives.Legend.ILegendSelectableListenerImplementor, Telerik.Xamarin.Android.Chart", "", this, new java.lang.Object[] {  });
	}


	public void onLegendObjectSelected (boolean p0)
	{
		n_onLegendObjectSelected (p0);
	}

	private native void n_onLegendObjectSelected (boolean p0);

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
