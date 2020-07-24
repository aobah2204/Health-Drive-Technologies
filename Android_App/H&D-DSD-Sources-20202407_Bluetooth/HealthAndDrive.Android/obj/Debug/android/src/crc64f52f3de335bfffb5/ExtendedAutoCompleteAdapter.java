package crc64f52f3de335bfffb5;


public class ExtendedAutoCompleteAdapter
	extends com.telerik.widget.autocomplete.AutoCompleteAdapter
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onBindListViewHolder:(Lcom/telerik/widget/list/ListViewHolder;I)V:GetOnBindListViewHolder_Lcom_telerik_widget_list_ListViewHolder_IHandler\n" +
			"n_onCreateViewHolder:(Landroid/view/ViewGroup;I)Lcom/telerik/widget/list/ListViewHolder;:GetOnCreateViewHolder_Landroid_view_ViewGroup_IHandler\n" +
			"n_filter:(Ljava/lang/String;)V:GetFilter_Ljava_lang_String_Handler\n" +
			"";
		mono.android.Runtime.register ("Telerik.XamarinForms.InputRenderer.Android.AutoComplete.ExtendedAutoCompleteAdapter, Telerik.XamarinForms.Input", ExtendedAutoCompleteAdapter.class, __md_methods);
	}


	public ExtendedAutoCompleteAdapter (android.content.Context p0, java.util.List p1, java.lang.Integer p2)
	{
		super (p0, p1, p2);
		if (getClass () == ExtendedAutoCompleteAdapter.class)
			mono.android.TypeManager.Activate ("Telerik.XamarinForms.InputRenderer.Android.AutoComplete.ExtendedAutoCompleteAdapter, Telerik.XamarinForms.Input", "Android.Content.Context, Mono.Android:System.Collections.Generic.IList`1<Com.Telerik.Widget.Autocomplete.TokenModel>, mscorlib:Java.Lang.Integer, Mono.Android", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public ExtendedAutoCompleteAdapter (android.content.Context p0, java.util.List p1, com.telerik.widget.list.ListViewHolder p2)
	{
		super (p0, p1, p2);
		if (getClass () == ExtendedAutoCompleteAdapter.class)
			mono.android.TypeManager.Activate ("Telerik.XamarinForms.InputRenderer.Android.AutoComplete.ExtendedAutoCompleteAdapter, Telerik.XamarinForms.Input", "Android.Content.Context, Mono.Android:System.Collections.Generic.IList`1<Com.Telerik.Widget.Autocomplete.TokenModel>, mscorlib:Com.Telerik.Widget.List.ListViewHolder, Telerik.Xamarin.Android.List", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public void onBindListViewHolder (com.telerik.widget.list.ListViewHolder p0, int p1)
	{
		n_onBindListViewHolder (p0, p1);
	}

	private native void n_onBindListViewHolder (com.telerik.widget.list.ListViewHolder p0, int p1);


	public com.telerik.widget.list.ListViewHolder onCreateViewHolder (android.view.ViewGroup p0, int p1)
	{
		return n_onCreateViewHolder (p0, p1);
	}

	private native com.telerik.widget.list.ListViewHolder n_onCreateViewHolder (android.view.ViewGroup p0, int p1);


	public void filter (java.lang.String p0)
	{
		n_filter (p0);
	}

	private native void n_filter (java.lang.String p0);

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
