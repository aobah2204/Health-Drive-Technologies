package crc644ac6aa1c847cb78b;


public class TreeViewAccessibilityDelegateCompat
	extends android.support.v4.view.AccessibilityDelegateCompat
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onInitializeAccessibilityNodeInfo:(Landroid/view/View;Landroid/support/v4/view/accessibility/AccessibilityNodeInfoCompat;)V:GetOnInitializeAccessibilityNodeInfo_Landroid_view_View_Landroid_support_v4_view_accessibility_AccessibilityNodeInfoCompat_Handler\n" +
			"";
		mono.android.Runtime.register ("Telerik.XamarinForms.DataControlsRenderer.Android.TreeViewAccessibilityDelegateCompat, Telerik.XamarinForms.DataControls", TreeViewAccessibilityDelegateCompat.class, __md_methods);
	}


	public TreeViewAccessibilityDelegateCompat ()
	{
		super ();
		if (getClass () == TreeViewAccessibilityDelegateCompat.class)
			mono.android.TypeManager.Activate ("Telerik.XamarinForms.DataControlsRenderer.Android.TreeViewAccessibilityDelegateCompat, Telerik.XamarinForms.DataControls", "", this, new java.lang.Object[] {  });
	}

	public TreeViewAccessibilityDelegateCompat (crc644ac6aa1c847cb78b.TreeViewDataSourceAdapter p0)
	{
		super ();
		if (getClass () == TreeViewAccessibilityDelegateCompat.class)
			mono.android.TypeManager.Activate ("Telerik.XamarinForms.DataControlsRenderer.Android.TreeViewAccessibilityDelegateCompat, Telerik.XamarinForms.DataControls", "Telerik.XamarinForms.DataControlsRenderer.Android.TreeViewDataSourceAdapter, Telerik.XamarinForms.DataControls", this, new java.lang.Object[] { p0 });
	}


	public void onInitializeAccessibilityNodeInfo (android.view.View p0, android.support.v4.view.accessibility.AccessibilityNodeInfoCompat p1)
	{
		n_onInitializeAccessibilityNodeInfo (p0, p1);
	}

	private native void n_onInitializeAccessibilityNodeInfo (android.view.View p0, android.support.v4.view.accessibility.AccessibilityNodeInfoCompat p1);

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
