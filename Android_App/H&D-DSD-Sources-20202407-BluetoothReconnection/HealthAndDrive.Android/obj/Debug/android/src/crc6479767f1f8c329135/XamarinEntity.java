package crc6479767f1f8c329135;


public class XamarinEntity
	extends com.telerik.widget.dataform.engine.EntityCore
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getSourceObject:()Ljava/lang/Object;:GetGetSourceObjectHandler\n" +
			"n_setProperty:(Lcom/telerik/widget/dataform/engine/EntityProperty;Ljava/lang/Object;)V:GetSetProperty_Lcom_telerik_widget_dataform_engine_EntityProperty_Ljava_lang_Object_Handler\n" +
			"n_getProperty:(Lcom/telerik/widget/dataform/engine/EntityProperty;)Ljava/lang/Object;:GetGetProperty_Lcom_telerik_widget_dataform_engine_EntityProperty_Handler\n" +
			"n_properties:()Ljava/lang/Iterable;:GetPropertiesHandler\n" +
			"";
		mono.android.Runtime.register ("Com.Telerik.Widget.Dataform.Engine.XamarinEntity, Telerik.Xamarin.Android.Input", XamarinEntity.class, __md_methods);
	}


	public XamarinEntity ()
	{
		super ();
		if (getClass () == XamarinEntity.class)
			mono.android.TypeManager.Activate ("Com.Telerik.Widget.Dataform.Engine.XamarinEntity, Telerik.Xamarin.Android.Input", "", this, new java.lang.Object[] {  });
	}

	public XamarinEntity (java.lang.Object p0)
	{
		super ();
		if (getClass () == XamarinEntity.class)
			mono.android.TypeManager.Activate ("Com.Telerik.Widget.Dataform.Engine.XamarinEntity, Telerik.Xamarin.Android.Input", "Java.Lang.Object, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public java.lang.Object getSourceObject ()
	{
		return n_getSourceObject ();
	}

	private native java.lang.Object n_getSourceObject ();


	public void setProperty (com.telerik.widget.dataform.engine.EntityProperty p0, java.lang.Object p1)
	{
		n_setProperty (p0, p1);
	}

	private native void n_setProperty (com.telerik.widget.dataform.engine.EntityProperty p0, java.lang.Object p1);


	public java.lang.Object getProperty (com.telerik.widget.dataform.engine.EntityProperty p0)
	{
		return n_getProperty (p0);
	}

	private native java.lang.Object n_getProperty (com.telerik.widget.dataform.engine.EntityProperty p0);


	public java.lang.Iterable properties ()
	{
		return n_properties ();
	}

	private native java.lang.Iterable n_properties ();

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
