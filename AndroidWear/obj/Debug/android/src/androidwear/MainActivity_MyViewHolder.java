package androidwear;


public class MainActivity_MyViewHolder
	extends android.support.v7.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("AndroidWear.MainActivity/MyViewHolder, AndroidWear, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MainActivity_MyViewHolder.class, __md_methods);
	}


	public MainActivity_MyViewHolder (android.view.View p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == MainActivity_MyViewHolder.class)
			mono.android.TypeManager.Activate ("AndroidWear.MainActivity/MyViewHolder, AndroidWear, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Views.View, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}

	java.util.ArrayList refList;
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
