package crc642cf676f472900c63;


public class AndroidDataFormEntityAdapter
	extends com.telerik.widget.dataform.visualization.DataFormEntityAdapter
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getEditorsForEntity:(Lcom/telerik/widget/dataform/engine/Entity;)Ljava/lang/Iterable;:GetGetEditorsForEntity_Lcom_telerik_widget_dataform_engine_Entity_Handler\n" +
			"n_getViewersForEntity:(Lcom/telerik/widget/dataform/engine/Entity;)Ljava/lang/Iterable;:GetGetViewersForEntity_Lcom_telerik_widget_dataform_engine_Entity_Handler\n" +
			"";
		mono.android.Runtime.register ("Telerik.XamarinForms.InputRenderer.Android.DataForm.AndroidDataFormEntityAdapter, Telerik.XamarinForms.Input", AndroidDataFormEntityAdapter.class, __md_methods);
	}


	public AndroidDataFormEntityAdapter (com.telerik.widget.dataform.visualization.RadDataForm p0)
	{
		super (p0);
		if (getClass () == AndroidDataFormEntityAdapter.class)
			mono.android.TypeManager.Activate ("Telerik.XamarinForms.InputRenderer.Android.DataForm.AndroidDataFormEntityAdapter, Telerik.XamarinForms.Input", "Com.Telerik.Widget.Dataform.Visualization.RadDataForm, Telerik.Xamarin.Android.Input", this, new java.lang.Object[] { p0 });
	}


	public java.lang.Iterable getEditorsForEntity (com.telerik.widget.dataform.engine.Entity p0)
	{
		return n_getEditorsForEntity (p0);
	}

	private native java.lang.Iterable n_getEditorsForEntity (com.telerik.widget.dataform.engine.Entity p0);


	public java.lang.Iterable getViewersForEntity (com.telerik.widget.dataform.engine.Entity p0)
	{
		return n_getViewersForEntity (p0);
	}

	private native java.lang.Iterable n_getViewersForEntity (com.telerik.widget.dataform.engine.Entity p0);

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
