package crc642cf676f472900c63;


public abstract class DataFormViewProviderBase
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.telerik.android.common.Function
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_apply:(Ljava/lang/Object;)Ljava/lang/Object;:GetApply_Ljava_lang_Object_Handler:Com.Telerik.Android.Common.IFunctionInvoker, Telerik.Xamarin.Android.Common\n" +
			"";
		mono.android.Runtime.register ("Telerik.XamarinForms.InputRenderer.Android.DataForm.DataFormViewProviderBase, Telerik.XamarinForms.Input", DataFormViewProviderBase.class, __md_methods);
	}


	public DataFormViewProviderBase ()
	{
		super ();
		if (getClass () == DataFormViewProviderBase.class)
			mono.android.TypeManager.Activate ("Telerik.XamarinForms.InputRenderer.Android.DataForm.DataFormViewProviderBase, Telerik.XamarinForms.Input", "", this, new java.lang.Object[] {  });
	}

	public DataFormViewProviderBase (crc648f4167c40236b0a7.DataFormRenderer p0, com.telerik.widget.dataform.visualization.RadDataForm p1)
	{
		super ();
		if (getClass () == DataFormViewProviderBase.class)
			mono.android.TypeManager.Activate ("Telerik.XamarinForms.InputRenderer.Android.DataForm.DataFormViewProviderBase, Telerik.XamarinForms.Input", "Telerik.XamarinForms.InputRenderer.Android.DataFormRenderer, Telerik.XamarinForms.Input:Com.Telerik.Widget.Dataform.Visualization.RadDataForm, Telerik.Xamarin.Android.Input", this, new java.lang.Object[] { p0, p1 });
	}


	public java.lang.Object apply (java.lang.Object p0)
	{
		return n_apply (p0);
	}

	private native java.lang.Object n_apply (java.lang.Object p0);

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
