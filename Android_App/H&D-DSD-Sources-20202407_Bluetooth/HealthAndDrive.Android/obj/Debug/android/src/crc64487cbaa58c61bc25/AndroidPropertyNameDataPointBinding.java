package crc64487cbaa58c61bc25;


public class AndroidPropertyNameDataPointBinding
	extends com.telerik.widget.chart.engine.databinding.DataPointBinding
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getValue:(Ljava/lang/Object;)Ljava/lang/Object;:GetGetValue_Ljava_lang_Object_Handler\n" +
			"n_onPropertyChanged:(Ljava/lang/String;)V:GetOnPropertyChanged_Ljava_lang_String_Handler\n" +
			"";
		mono.android.Runtime.register ("Telerik.XamarinForms.ChartRenderer.Android.AndroidPropertyNameDataPointBinding, Telerik.XamarinForms.Chart", AndroidPropertyNameDataPointBinding.class, __md_methods);
	}


	public AndroidPropertyNameDataPointBinding ()
	{
		super ();
		if (getClass () == AndroidPropertyNameDataPointBinding.class)
			mono.android.TypeManager.Activate ("Telerik.XamarinForms.ChartRenderer.Android.AndroidPropertyNameDataPointBinding, Telerik.XamarinForms.Chart", "", this, new java.lang.Object[] {  });
	}


	public java.lang.Object getValue (java.lang.Object p0)
	{
		return n_getValue (p0);
	}

	private native java.lang.Object n_getValue (java.lang.Object p0);


	public void onPropertyChanged (java.lang.String p0)
	{
		n_onPropertyChanged (p0);
	}

	private native void n_onPropertyChanged (java.lang.String p0);

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
