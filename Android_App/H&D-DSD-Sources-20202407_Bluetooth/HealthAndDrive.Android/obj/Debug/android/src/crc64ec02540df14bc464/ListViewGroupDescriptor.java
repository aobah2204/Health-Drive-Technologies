package crc64ec02540df14bc464;


public class ListViewGroupDescriptor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.telerik.android.common.Function,
		com.telerik.android.common.Function2
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_apply:(Ljava/lang/Object;)Ljava/lang/Object;:GetApply_Ljava_lang_Object_Handler:Com.Telerik.Android.Common.IFunctionInvoker, Telerik.Xamarin.Android.Common\n" +
			"n_apply:(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;:GetApply_Ljava_lang_Object_Ljava_lang_Object_Handler:Com.Telerik.Android.Common.IFunction2Invoker, Telerik.Xamarin.Android.Common\n" +
			"";
		mono.android.Runtime.register ("Telerik.XamarinForms.DataControlsRenderer.Android.ListView.ListViewGroupDescriptor, Telerik.XamarinForms.DataControls", ListViewGroupDescriptor.class, __md_methods);
	}


	public ListViewGroupDescriptor ()
	{
		super ();
		if (getClass () == ListViewGroupDescriptor.class)
			mono.android.TypeManager.Activate ("Telerik.XamarinForms.DataControlsRenderer.Android.ListView.ListViewGroupDescriptor, Telerik.XamarinForms.DataControls", "", this, new java.lang.Object[] {  });
	}


	public java.lang.Object apply (java.lang.Object p0)
	{
		return n_apply (p0);
	}

	private native java.lang.Object n_apply (java.lang.Object p0);


	public java.lang.Object apply (java.lang.Object p0, java.lang.Object p1)
	{
		return n_apply (p0, p1);
	}

	private native java.lang.Object n_apply (java.lang.Object p0, java.lang.Object p1);

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
