package crc64204ae6d284429e79;


public class ChartLegendScrollView
	extends android.widget.ScrollView
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onTouchEvent:(Landroid/view/MotionEvent;)Z:GetOnTouchEvent_Landroid_view_MotionEvent_Handler\n" +
			"";
		mono.android.Runtime.register ("Com.Syncfusion.Charts.ChartLegendScrollView, Syncfusion.SfChart.XForms.Android", ChartLegendScrollView.class, __md_methods);
	}


	public ChartLegendScrollView (android.content.Context p0)
	{
		super (p0);
		if (getClass () == ChartLegendScrollView.class)
			mono.android.TypeManager.Activate ("Com.Syncfusion.Charts.ChartLegendScrollView, Syncfusion.SfChart.XForms.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public ChartLegendScrollView (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == ChartLegendScrollView.class)
			mono.android.TypeManager.Activate ("Com.Syncfusion.Charts.ChartLegendScrollView, Syncfusion.SfChart.XForms.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public ChartLegendScrollView (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == ChartLegendScrollView.class)
			mono.android.TypeManager.Activate ("Com.Syncfusion.Charts.ChartLegendScrollView, Syncfusion.SfChart.XForms.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public ChartLegendScrollView (android.content.Context p0, android.util.AttributeSet p1, int p2, int p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == ChartLegendScrollView.class)
			mono.android.TypeManager.Activate ("Com.Syncfusion.Charts.ChartLegendScrollView, Syncfusion.SfChart.XForms.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2, p3 });
	}


	public boolean onTouchEvent (android.view.MotionEvent p0)
	{
		return n_onTouchEvent (p0);
	}

	private native boolean n_onTouchEvent (android.view.MotionEvent p0);

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
