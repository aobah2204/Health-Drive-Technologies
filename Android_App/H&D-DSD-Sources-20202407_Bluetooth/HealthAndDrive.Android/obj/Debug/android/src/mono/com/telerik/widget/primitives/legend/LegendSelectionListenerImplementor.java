package mono.com.telerik.widget.primitives.legend;


public class LegendSelectionListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.telerik.widget.primitives.legend.LegendSelectionListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onLegendItemSelected:(Ljava/lang/Object;)V:GetOnLegendItemSelected_Ljava_lang_Object_Handler:Com.Telerik.Widget.Primitives.Legend.ILegendSelectionListenerInvoker, Telerik.Xamarin.Android.Chart\n" +
			"";
		mono.android.Runtime.register ("Com.Telerik.Widget.Primitives.Legend.ILegendSelectionListenerImplementor, Telerik.Xamarin.Android.Chart", LegendSelectionListenerImplementor.class, __md_methods);
	}


	public LegendSelectionListenerImplementor ()
	{
		super ();
		if (getClass () == LegendSelectionListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Telerik.Widget.Primitives.Legend.ILegendSelectionListenerImplementor, Telerik.Xamarin.Android.Chart", "", this, new java.lang.Object[] {  });
	}


	public void onLegendItemSelected (java.lang.Object p0)
	{
		n_onLegendItemSelected (p0);
	}

	private native void n_onLegendItemSelected (java.lang.Object p0);

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
