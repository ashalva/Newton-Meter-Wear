package mono.com.google.android.gms.maps;


public class GoogleMap_OnMyLocationButtonClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.maps.GoogleMap.OnMyLocationButtonClickListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onMyLocationButtonClick:()Z:GetOnMyLocationButtonClickHandler:Android.Gms.Maps.GoogleMap/IOnMyLocationButtonClickListenerInvoker, Xamarin.Android.Wearable\n" +
			"";
		mono.android.Runtime.register ("Android.Gms.Maps.GoogleMap/IOnMyLocationButtonClickListenerImplementor, Xamarin.Android.Wearable, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", GoogleMap_OnMyLocationButtonClickListenerImplementor.class, __md_methods);
	}


	public GoogleMap_OnMyLocationButtonClickListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == GoogleMap_OnMyLocationButtonClickListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Gms.Maps.GoogleMap/IOnMyLocationButtonClickListenerImplementor, Xamarin.Android.Wearable, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public boolean onMyLocationButtonClick ()
	{
		return n_onMyLocationButtonClick ();
	}

	private native boolean n_onMyLocationButtonClick ();

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
