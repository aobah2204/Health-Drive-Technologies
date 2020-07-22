package mono.com.telerik.widget.primitives.panels;


public class ScrollViewLaidOutListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.telerik.widget.primitives.panels.ScrollViewLaidOutListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onLaidOut:()V:GetOnLaidOutHandler:Com.Telerik.Widget.Primitives.Panels.IScrollViewLaidOutListenerInvoker, Telerik.Xamarin.Android.Primitives\n" +
			"";
		mono.android.Runtime.register ("Com.Telerik.Widget.Primitives.Panels.IScrollViewLaidOutListenerImplementor, Telerik.Xamarin.Android.Primitives", ScrollViewLaidOutListenerImplementor.class, __md_methods);
	}


	public ScrollViewLaidOutListenerImplementor ()
	{
		super ();
		if (getClass () == ScrollViewLaidOutListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Telerik.Widget.Primitives.Panels.IScrollViewLaidOutListenerImplementor, Telerik.Xamarin.Android.Primitives", "", this, new java.lang.Object[] {  });
	}


	public void onLaidOut ()
	{
		n_onLaidOut ();
	}

	private native void n_onLaidOut ();

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
