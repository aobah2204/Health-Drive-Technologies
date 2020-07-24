package mono.com.telerik.widget.chart.engine.databinding.datasources;


public class DataBindingListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.telerik.widget.chart.engine.databinding.datasources.DataBindingListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onBoundItemPropertyChanged:(Lcom/telerik/widget/chart/engine/databinding/DataPointBindingEntry;Ljava/beans/PropertyChangeEvent;)V:GetOnBoundItemPropertyChanged_Lcom_telerik_widget_chart_engine_databinding_DataPointBindingEntry_Ljava_beans_PropertyChangeEvent_Handler:Com.Telerik.Widget.Chart.Engine.Databinding.Datasources.IDataBindingListenerInvoker, Telerik.Xamarin.Android.Chart\n" +
			"n_onDataBindingComplete:()V:GetOnDataBindingCompleteHandler:Com.Telerik.Widget.Chart.Engine.Databinding.Datasources.IDataBindingListenerInvoker, Telerik.Xamarin.Android.Chart\n" +
			"";
		mono.android.Runtime.register ("Com.Telerik.Widget.Chart.Engine.Databinding.Datasources.IDataBindingListenerImplementor, Telerik.Xamarin.Android.Chart", DataBindingListenerImplementor.class, __md_methods);
	}


	public DataBindingListenerImplementor ()
	{
		super ();
		if (getClass () == DataBindingListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Telerik.Widget.Chart.Engine.Databinding.Datasources.IDataBindingListenerImplementor, Telerik.Xamarin.Android.Chart", "", this, new java.lang.Object[] {  });
	}


	public void onBoundItemPropertyChanged (com.telerik.widget.chart.engine.databinding.DataPointBindingEntry p0, java.beans.PropertyChangeEvent p1)
	{
		n_onBoundItemPropertyChanged (p0, p1);
	}

	private native void n_onBoundItemPropertyChanged (com.telerik.widget.chart.engine.databinding.DataPointBindingEntry p0, java.beans.PropertyChangeEvent p1);


	public void onDataBindingComplete ()
	{
		n_onDataBindingComplete ();
	}

	private native void n_onDataBindingComplete ();

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
