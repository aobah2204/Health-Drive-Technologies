package crc644ac6aa1c847cb78b;


public class RadListViewDataSourceAdapter
	extends crc644ac6aa1c847cb78b.FormsListViewDataSourceAdapterBase
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getSelectionServiceProvider:()Lcom/telerik/android/data/SelectionAdapter;:GetGetSelectionServiceProviderHandler\n" +
			"n_getItemCount:()I:GetGetItemCountHandler\n" +
			"n_getItemViewType:(I)I:GetGetItemViewType_IHandler\n" +
			"n_getItemId:(I)J:GetGetItemId_IHandler\n" +
			"n_isGroupHeader:(I)Z:GetIsGroupHeader_IHandler\n" +
			"n_onBindListViewHolder:(Lcom/telerik/widget/list/ListViewHolder;I)V:GetOnBindListViewHolder_Lcom_telerik_widget_list_ListViewHolder_IHandler\n" +
			"n_onBindSwipeContentHolder:(Lcom/telerik/widget/list/ListViewHolder;I)V:GetOnBindSwipeContentHolder_Lcom_telerik_widget_list_ListViewHolder_IHandler\n" +
			"n_onCreateListViewHolder:(Landroid/view/ViewGroup;I)Lcom/telerik/widget/list/ListViewHolder;:GetOnCreateListViewHolder_Landroid_view_ViewGroup_IHandler\n" +
			"n_onCreateSwipeContentHolder:(Landroid/view/ViewGroup;)Lcom/telerik/widget/list/ListViewHolder;:GetOnCreateSwipeContentHolder_Landroid_view_ViewGroup_Handler\n" +
			"n_canReorder:(I)Z:GetCanReorder_IHandler\n" +
			"n_reorderItem:(II)Z:GetReorderItem_IIHandler\n" +
			"";
		mono.android.Runtime.register ("Telerik.XamarinForms.DataControlsRenderer.Android.RadListViewDataSourceAdapter, Telerik.XamarinForms.DataControls", RadListViewDataSourceAdapter.class, __md_methods);
	}


	public RadListViewDataSourceAdapter ()
	{
		super ();
		if (getClass () == RadListViewDataSourceAdapter.class)
			mono.android.TypeManager.Activate ("Telerik.XamarinForms.DataControlsRenderer.Android.RadListViewDataSourceAdapter, Telerik.XamarinForms.DataControls", "", this, new java.lang.Object[] {  });
	}


	public com.telerik.android.data.SelectionAdapter getSelectionServiceProvider ()
	{
		return n_getSelectionServiceProvider ();
	}

	private native com.telerik.android.data.SelectionAdapter n_getSelectionServiceProvider ();


	public int getItemCount ()
	{
		return n_getItemCount ();
	}

	private native int n_getItemCount ();


	public int getItemViewType (int p0)
	{
		return n_getItemViewType (p0);
	}

	private native int n_getItemViewType (int p0);


	public long getItemId (int p0)
	{
		return n_getItemId (p0);
	}

	private native long n_getItemId (int p0);


	public boolean isGroupHeader (int p0)
	{
		return n_isGroupHeader (p0);
	}

	private native boolean n_isGroupHeader (int p0);


	public void onBindListViewHolder (com.telerik.widget.list.ListViewHolder p0, int p1)
	{
		n_onBindListViewHolder (p0, p1);
	}

	private native void n_onBindListViewHolder (com.telerik.widget.list.ListViewHolder p0, int p1);


	public void onBindSwipeContentHolder (com.telerik.widget.list.ListViewHolder p0, int p1)
	{
		n_onBindSwipeContentHolder (p0, p1);
	}

	private native void n_onBindSwipeContentHolder (com.telerik.widget.list.ListViewHolder p0, int p1);


	public com.telerik.widget.list.ListViewHolder onCreateListViewHolder (android.view.ViewGroup p0, int p1)
	{
		return n_onCreateListViewHolder (p0, p1);
	}

	private native com.telerik.widget.list.ListViewHolder n_onCreateListViewHolder (android.view.ViewGroup p0, int p1);


	public com.telerik.widget.list.ListViewHolder onCreateSwipeContentHolder (android.view.ViewGroup p0)
	{
		return n_onCreateSwipeContentHolder (p0);
	}

	private native com.telerik.widget.list.ListViewHolder n_onCreateSwipeContentHolder (android.view.ViewGroup p0);


	public boolean canReorder (int p0)
	{
		return n_canReorder (p0);
	}

	private native boolean n_canReorder (int p0);


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
