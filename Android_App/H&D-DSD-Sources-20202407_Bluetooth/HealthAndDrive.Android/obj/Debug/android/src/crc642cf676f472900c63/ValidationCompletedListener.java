package crc642cf676f472900c63;


public class ValidationCompletedListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.telerik.widget.dataform.engine.ValidationCompletedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_validationCompleted:(Lcom/telerik/widget/dataform/engine/ValidationInfo;)V:GetValidationCompleted_Lcom_telerik_widget_dataform_engine_ValidationInfo_Handler:Com.Telerik.Widget.Dataform.Engine.IValidationCompletedListenerInvoker, Telerik.Xamarin.Android.Input\n" +
			"";
		mono.android.Runtime.register ("Telerik.XamarinForms.InputRenderer.Android.DataForm.ValidationCompletedListener, Telerik.XamarinForms.Input", ValidationCompletedListener.class, __md_methods);
	}


	public ValidationCompletedListener ()
	{
		super ();
		if (getClass () == ValidationCompletedListener.class)
			mono.android.TypeManager.Activate ("Telerik.XamarinForms.InputRenderer.Android.DataForm.ValidationCompletedListener, Telerik.XamarinForms.Input", "", this, new java.lang.Object[] {  });
	}


	public void validationCompleted (com.telerik.widget.dataform.engine.ValidationInfo p0)
	{
		n_validationCompleted (p0);
	}

	private native void n_validationCompleted (com.telerik.widget.dataform.engine.ValidationInfo p0);

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
