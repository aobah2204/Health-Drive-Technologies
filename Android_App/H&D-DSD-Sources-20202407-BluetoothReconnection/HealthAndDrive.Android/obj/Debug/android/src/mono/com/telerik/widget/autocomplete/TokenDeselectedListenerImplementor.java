package mono.com.telerik.widget.autocomplete;


public class TokenDeselectedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.telerik.widget.autocomplete.TokenDeselectedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onTokenDeselected:(Lcom/telerik/widget/autocomplete/RadAutoCompleteTextView;Lcom/telerik/widget/autocomplete/TokenModel;)V:GetOnTokenDeselected_Lcom_telerik_widget_autocomplete_RadAutoCompleteTextView_Lcom_telerik_widget_autocomplete_TokenModel_Handler:Com.Telerik.Widget.Autocomplete.ITokenDeselectedListenerInvoker, Telerik.Xamarin.Android.Input\n" +
			"";
		mono.android.Runtime.register ("Com.Telerik.Widget.Autocomplete.ITokenDeselectedListenerImplementor, Telerik.Xamarin.Android.Input", TokenDeselectedListenerImplementor.class, __md_methods);
	}


	public TokenDeselectedListenerImplementor ()
	{
		super ();
		if (getClass () == TokenDeselectedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Telerik.Widget.Autocomplete.ITokenDeselectedListenerImplementor, Telerik.Xamarin.Android.Input", "", this, new java.lang.Object[] {  });
	}


	public void onTokenDeselected (com.telerik.widget.autocomplete.RadAutoCompleteTextView p0, com.telerik.widget.autocomplete.TokenModel p1)
	{
		n_onTokenDeselected (p0, p1);
	}

	private native void n_onTokenDeselected (com.telerik.widget.autocomplete.RadAutoCompleteTextView p0, com.telerik.widget.autocomplete.TokenModel p1);

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
