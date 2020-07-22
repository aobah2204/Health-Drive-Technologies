package crc64b76f6e8b2d8c8db1;


public class ActionSheetAppCompatDialogFragment
	extends crc64b76f6e8b2d8c8db1.AbstractBuilderAppCompatDialogFragment_2
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_dismiss:()V:GetDismissHandler\n" +
			"";
		mono.android.Runtime.register ("Acr.UserDialogs.Fragments.ActionSheetAppCompatDialogFragment, Acr.UserDialogs", ActionSheetAppCompatDialogFragment.class, __md_methods);
	}


	public ActionSheetAppCompatDialogFragment ()
	{
		super ();
		if (getClass () == ActionSheetAppCompatDialogFragment.class)
			mono.android.TypeManager.Activate ("Acr.UserDialogs.Fragments.ActionSheetAppCompatDialogFragment, Acr.UserDialogs", "", this, new java.lang.Object[] {  });
	}


	public void dismiss ()
	{
		n_dismiss ();
	}

	private native void n_dismiss ();

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
