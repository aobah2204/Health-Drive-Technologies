package crc644ac6aa1c847cb78b;


public class TreeViewSelectionAdapter
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.telerik.android.data.SelectionAdapter
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getSelectedItems:()Ljava/util/List;:GetGetSelectedItemsHandler:Com.Telerik.Android.Data.ISelectionAdapterInvoker, Telerik.Xamarin.Android.Data\n" +
			"n_getSelectionMode:()Lcom/telerik/android/data/SelectionMode;:GetGetSelectionModeHandler:Com.Telerik.Android.Data.ISelectionAdapterInvoker, Telerik.Xamarin.Android.Data\n" +
			"n_setSelectionMode:(Lcom/telerik/android/data/SelectionMode;)V:GetSetSelectionMode_Lcom_telerik_android_data_SelectionMode_Handler:Com.Telerik.Android.Data.ISelectionAdapterInvoker, Telerik.Xamarin.Android.Data\n" +
			"n_clearSelection:()V:GetClearSelectionHandler:Com.Telerik.Android.Data.ISelectionAdapterInvoker, Telerik.Xamarin.Android.Data\n" +
			"n_deselectIndex:(I)V:GetDeselectIndex_IHandler:Com.Telerik.Android.Data.ISelectionAdapterInvoker, Telerik.Xamarin.Android.Data\n" +
			"n_getSelectedIndices:()[I:GetGetSelectedIndicesHandler:Com.Telerik.Android.Data.ISelectionAdapterInvoker, Telerik.Xamarin.Android.Data\n" +
			"n_isIndexSelected:(I)Z:GetIsIndexSelected_IHandler:Com.Telerik.Android.Data.ISelectionAdapterInvoker, Telerik.Xamarin.Android.Data\n" +
			"n_selectIndex:(I)V:GetSelectIndex_IHandler:Com.Telerik.Android.Data.ISelectionAdapterInvoker, Telerik.Xamarin.Android.Data\n" +
			"n_selectedItemsSize:()I:GetSelectedItemsSizeHandler:Com.Telerik.Android.Data.ISelectionAdapterInvoker, Telerik.Xamarin.Android.Data\n" +
			"";
		mono.android.Runtime.register ("Telerik.XamarinForms.DataControlsRenderer.Android.TreeViewSelectionAdapter, Telerik.XamarinForms.DataControls", TreeViewSelectionAdapter.class, __md_methods);
	}


	public TreeViewSelectionAdapter ()
	{
		super ();
		if (getClass () == TreeViewSelectionAdapter.class)
			mono.android.TypeManager.Activate ("Telerik.XamarinForms.DataControlsRenderer.Android.TreeViewSelectionAdapter, Telerik.XamarinForms.DataControls", "", this, new java.lang.Object[] {  });
	}


	public java.util.List getSelectedItems ()
	{
		return n_getSelectedItems ();
	}

	private native java.util.List n_getSelectedItems ();


	public com.telerik.android.data.SelectionMode getSelectionMode ()
	{
		return n_getSelectionMode ();
	}

	private native com.telerik.android.data.SelectionMode n_getSelectionMode ();


	public void setSelectionMode (com.telerik.android.data.SelectionMode p0)
	{
		n_setSelectionMode (p0);
	}

	private native void n_setSelectionMode (com.telerik.android.data.SelectionMode p0);


	public void clearSelection ()
	{
		n_clearSelection ();
	}

	private native void n_clearSelection ();


	public void deselectIndex (int p0)
	{
		n_deselectIndex (p0);
	}

	private native void n_deselectIndex (int p0);


	public int[] getSelectedIndices ()
	{
		return n_getSelectedIndices ();
	}

	private native int[] n_getSelectedIndices ();


	public boolean isIndexSelected (int p0)
	{
		return n_isIndexSelected (p0);
	}

	private native boolean n_isIndexSelected (int p0);


	public void selectIndex (int p0)
	{
		n_selectIndex (p0);
	}

	private native void n_selectIndex (int p0);


	public int selectedItemsSize ()
	{
		return n_selectedItemsSize ();
	}

	private native int n_selectedItemsSize ();

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
