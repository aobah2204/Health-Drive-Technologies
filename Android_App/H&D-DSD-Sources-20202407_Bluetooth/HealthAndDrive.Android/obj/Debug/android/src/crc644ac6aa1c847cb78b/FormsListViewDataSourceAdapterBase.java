package crc644ac6aa1c847cb78b;


public abstract class FormsListViewDataSourceAdapterBase
	extends com.telerik.widget.list.ListViewAdapterBase
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreateListViewHolder:(Landroid/view/ViewGroup;I)Lcom/telerik/widget/list/ListViewHolder;:GetOnCreateListViewHolder_Landroid_view_ViewGroup_IHandler\n" +
			"n_reorderItem:(II)Z:GetReorderItem_IIHandler\n" +
			"";
		mono.android.Runtime.register ("Telerik.XamarinForms.DataControlsRenderer.Android.FormsListViewDataSourceAdapterBase, Telerik.XamarinForms.DataControls", FormsListViewDataSourceAdapterBase.class, __md_methods);
	}


	public FormsListViewDataSourceAdapterBase ()
	{
		super ();
		if (getClass () == FormsListViewDataSourceAdapterBase.class)
			mono.android.TypeManager.Activate ("Telerik.XamarinForms.DataControlsRenderer.Android.FormsListViewDataSourceAdapterBase, Telerik.XamarinForms.DataControls", "", this, new java.lang.Object[] {  });
	}


	public com.telerik.widget.list.ListViewHolder onCreateListViewHolder (android.view.ViewGroup p0, int p1)
	{
		return n_onCreateListViewHolder (p0, p1);
	}

	private native com.telerik.widget.list.ListViewHolder n_onCreateListViewHolder (android.view.ViewGroup p0, int p1);


	public boolean reorderItem (int p0, int p1)
	{
		return n_reorderItem (p0, p1);
	}

	private native boolean n_reorderItem (int p0, int p1);

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
