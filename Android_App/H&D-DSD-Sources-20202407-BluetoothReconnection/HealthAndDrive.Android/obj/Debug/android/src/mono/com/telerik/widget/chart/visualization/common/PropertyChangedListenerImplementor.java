package mono.com.telerik.widget.chart.visualization.common;


public class PropertyChangedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.telerik.widget.chart.visualization.common.PropertyChangedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onPropertyChanged:(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;)V:GetOnPropertyChanged_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Handler:Com.Telerik.Widget.Chart.Visualization.Common.IPropertyChangedListenerInvoker, Telerik.Xamarin.Android.Chart\n" +
			"";
		mono.android.Runtime.register ("Com.Telerik.Widget.Chart.Visualization.Common.IPropertyChangedListenerImplementor, Telerik.Xamarin.Android.Chart", PropertyChangedListenerImplementor.class, __md_methods);
	}


	public PropertyChangedListenerImplementor ()
	{
		super ();
		if (getClass () == PropertyChangedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Telerik.Widget.Chart.Visualization.Common.IPropertyChangedListenerImplementor, Telerik.Xamarin.Android.Chart", "", this, new java.lang.Object[] {  });
	}


	public void onPropertyChanged (java.lang.Object p0, java.lang.String p1, java.lang.Object p2)
	{
		n_onPropertyChanged (p0, p1, p2);
	}

	private native void n_onPropertyChanged (java.lang.Object p0, java.lang.String p1, java.lang.Object p2);

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
