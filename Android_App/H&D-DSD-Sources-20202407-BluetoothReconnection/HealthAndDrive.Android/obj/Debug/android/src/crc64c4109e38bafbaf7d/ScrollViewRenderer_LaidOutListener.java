package crc64c4109e38bafbaf7d;


public class ScrollViewRenderer_LaidOutListener
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
		mono.android.Runtime.register ("Telerik.XamarinForms.PrimitivesRenderer.Android.ScrollViewRenderer+LaidOutListener, Telerik.XamarinForms.Primitives", ScrollViewRenderer_LaidOutListener.class, __md_methods);
	}


	public ScrollViewRenderer_LaidOutListener ()
	{
		super ();
		if (getClass () == ScrollViewRenderer_LaidOutListener.class)
			mono.android.TypeManager.Activate ("Telerik.XamarinForms.PrimitivesRenderer.Android.ScrollViewRenderer+LaidOutListener, Telerik.XamarinForms.Primitives", "", this, new java.lang.Object[] {  });
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
