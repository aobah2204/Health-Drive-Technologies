package mono.com.telerik.widget.list;


public class RadListView_ItemClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.telerik.widget.list.RadListView.ItemClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onItemClick:(ILandroid/view/MotionEvent;)V:GetOnItemClick_ILandroid_view_MotionEvent_Handler:Com.Telerik.Widget.List.RadListView/IItemClickListenerInvoker, Telerik.Xamarin.Android.List\n" +
			"n_onItemLongClick:(ILandroid/view/MotionEvent;)V:GetOnItemLongClick_ILandroid_view_MotionEvent_Handler:Com.Telerik.Widget.List.RadListView/IItemClickListenerInvoker, Telerik.Xamarin.Android.List\n" +
			"";
		mono.android.Runtime.register ("Com.Telerik.Widget.List.RadListView+IItemClickListenerImplementor, Telerik.Xamarin.Android.List", RadListView_ItemClickListenerImplementor.class, __md_methods);
	}


	public RadListView_ItemClickListenerImplementor ()
	{
		super ();
		if (getClass () == RadListView_ItemClickListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Telerik.Widget.List.RadListView+IItemClickListenerImplementor, Telerik.Xamarin.Android.List", "", this, new java.lang.Object[] {  });
	}


	public void onItemClick (int p0, android.view.MotionEvent p1)
	{
		n_onItemClick (p0, p1);
	}

	private native void n_onItemClick (int p0, android.view.MotionEvent p1);


	public void onItemLongClick (int p0, android.view.MotionEvent p1)
	{
		n_onItemLongClick (p0, p1);
	}

	private native void n_onItemLongClick (int p0, android.view.MotionEvent p1);

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
