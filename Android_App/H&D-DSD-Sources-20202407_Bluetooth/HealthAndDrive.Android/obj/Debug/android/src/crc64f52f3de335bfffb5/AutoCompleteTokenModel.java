package crc64f52f3de335bfffb5;


public class AutoCompleteTokenModel
	extends com.telerik.widget.autocomplete.TokenModel
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Telerik.XamarinForms.InputRenderer.Android.AutoComplete.AutoCompleteTokenModel, Telerik.XamarinForms.Input", AutoCompleteTokenModel.class, __md_methods);
	}


	public AutoCompleteTokenModel (java.lang.String p0, android.graphics.drawable.Drawable p1)
	{
		super (p0, p1);
		if (getClass () == AutoCompleteTokenModel.class)
			mono.android.TypeManager.Activate ("Telerik.XamarinForms.InputRenderer.Android.AutoComplete.AutoCompleteTokenModel, Telerik.XamarinForms.Input", "System.String, mscorlib:Android.Graphics.Drawables.Drawable, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public AutoCompleteTokenModel (android.os.Parcel p0)
	{
		super (p0);
		if (getClass () == AutoCompleteTokenModel.class)
			mono.android.TypeManager.Activate ("Telerik.XamarinForms.InputRenderer.Android.AutoComplete.AutoCompleteTokenModel, Telerik.XamarinForms.Input", "Android.OS.Parcel, Mono.Android", this, new java.lang.Object[] { p0 });
	}

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
