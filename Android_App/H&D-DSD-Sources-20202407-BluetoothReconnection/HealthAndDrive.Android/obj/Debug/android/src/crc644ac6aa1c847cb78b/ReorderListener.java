package crc644ac6aa1c847cb78b;


public class ReorderListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.telerik.widget.list.ItemReorderBehavior.ItemReorderListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onReorderFinished:()V:GetOnReorderFinishedHandler:Com.Telerik.Widget.List.ItemReorderBehavior/IItemReorderListenerInvoker, Telerik.Xamarin.Android.List\n" +
			"n_onReorderItem:(II)V:GetOnReorderItem_IIHandler:Com.Telerik.Widget.List.ItemReorderBehavior/IItemReorderListenerInvoker, Telerik.Xamarin.Android.List\n" +
			"n_onReorderStarted:(I)V:GetOnReorderStarted_IHandler:Com.Telerik.Widget.List.ItemReorderBehavior/IItemReorderListenerInvoker, Telerik.Xamarin.Android.List\n" +
			"";
		mono.android.Runtime.register ("Telerik.XamarinForms.DataControlsRenderer.Android.ReorderListener, Telerik.XamarinForms.DataControls", ReorderListener.class, __md_methods);
	}


	public ReorderListener ()
	{
		super ();
		if (getClass () == ReorderListener.class)
			mono.android.TypeManager.Activate ("Telerik.XamarinForms.DataControlsRenderer.Android.ReorderListener, Telerik.XamarinForms.DataControls", "", this, new java.lang.Object[] {  });
	}


	public void onReorderFinished ()
	{
		n_onReorderFinished ();
	}

	private native void n_onReorderFinished ();


	public void onReorderItem (int p0, int p1)
	{
		n_onReorderItem (p0, p1);
	}

	private native void n_onReorderItem (int p0, int p1);


	public void onReorderStarted (int p0)
	{
		n_onReorderStarted (p0);
	}

	private native void n_onReorderStarted (int p0);

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
