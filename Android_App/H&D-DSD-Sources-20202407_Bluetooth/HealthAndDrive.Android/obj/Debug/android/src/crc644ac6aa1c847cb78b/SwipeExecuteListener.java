package crc644ac6aa1c847cb78b;


public class SwipeExecuteListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.telerik.widget.list.SwipeExecuteBehavior.SwipeExecuteListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onExecuteFinished:(I)V:GetOnExecuteFinished_IHandler:Com.Telerik.Widget.List.SwipeExecuteBehavior/ISwipeExecuteListenerInvoker, Telerik.Xamarin.Android.List\n" +
			"n_onSwipeEnded:(II)V:GetOnSwipeEnded_IIHandler:Com.Telerik.Widget.List.SwipeExecuteBehavior/ISwipeExecuteListenerInvoker, Telerik.Xamarin.Android.List\n" +
			"n_onSwipeProgressChanged:(IILandroid/view/View;)V:GetOnSwipeProgressChanged_IILandroid_view_View_Handler:Com.Telerik.Widget.List.SwipeExecuteBehavior/ISwipeExecuteListenerInvoker, Telerik.Xamarin.Android.List\n" +
			"n_onSwipeStarted:(I)V:GetOnSwipeStarted_IHandler:Com.Telerik.Widget.List.SwipeExecuteBehavior/ISwipeExecuteListenerInvoker, Telerik.Xamarin.Android.List\n" +
			"";
		mono.android.Runtime.register ("Telerik.XamarinForms.DataControlsRenderer.Android.SwipeExecuteListener, Telerik.XamarinForms.DataControls", SwipeExecuteListener.class, __md_methods);
	}


	public SwipeExecuteListener ()
	{
		super ();
		if (getClass () == SwipeExecuteListener.class)
			mono.android.TypeManager.Activate ("Telerik.XamarinForms.DataControlsRenderer.Android.SwipeExecuteListener, Telerik.XamarinForms.DataControls", "", this, new java.lang.Object[] {  });
	}


	public void onExecuteFinished (int p0)
	{
		n_onExecuteFinished (p0);
	}

	private native void n_onExecuteFinished (int p0);


	public void onSwipeEnded (int p0, int p1)
	{
		n_onSwipeEnded (p0, p1);
	}

	private native void n_onSwipeEnded (int p0, int p1);


	public void onSwipeProgressChanged (int p0, int p1, android.view.View p2)
	{
		n_onSwipeProgressChanged (p0, p1, p2);
	}

	private native void n_onSwipeProgressChanged (int p0, int p1, android.view.View p2);


	public void onSwipeStarted (int p0)
	{
		n_onSwipeStarted (p0);
	}

	private native void n_onSwipeStarted (int p0);

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
