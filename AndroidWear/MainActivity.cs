using System;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Support.Wearable.Views;
using Android.Views;
using Android.Widget;
using Android.Graphics;

//using System.Drawing;
using System.Collections.Generic;

namespace AndroidWear
{
	[Activity (Label = "AndroidWear", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		public override bool OnTouchEvent (MotionEvent e)
		{
			return base.OnTouchEvent (e);
			//e.Action = MotionEventActions.
			//var gestureDetector = new GestureDetector(
		}
		/* this is comment for fake pull 1+1=2+1=3+2=? */
		private WearableListView mListView;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			listItems = new List<int> ();
			for (int i = 10; i < 200; i++) {
				listItems.Add (i);
			}
			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			var v = FindViewById<WatchViewStub> (Resource.Id.watch_view_stub);

			v.SetBackgroundColor (Color.ParseColor ("#006666"));
			v.LayoutInflated += delegate {

				mListView = v.FindViewById<WearableListView> (Resource.Id.weightListview);
				mListView.SetAdapter (new ProjectAdapter (this));
				//mListView.SetClickListener(this);
				// Get our button from the layout resource,x	
				// and attach an event to it
				Button button = FindViewById<Button> (Resource.Id.myButton);
				
				//button.Click += delegate {
				//	StartActivity(typeof(PunchActivity));
				//};
			};
		}

		private static List<int> listItems;

		public class ProjectAdapter : WearableListView.Adapter
		{
			List<int> projects;
			Context context;

			public ProjectAdapter (Context context)
			{
				projects = listItems;
				this.context = context;
			}

			public override void OnBindViewHolder (Android.Support.V7.Widget.RecyclerView.ViewHolder p0, int p1)
			{
				var view = p0.ItemView.FindViewById<TextView> (Resource.Id.textView);
				view.Text = "" + projects [p1];
			}

			public override Android.Support.V7.Widget.RecyclerView.ViewHolder OnCreateViewHolder (ViewGroup p0, int p1)
			{
				return new MyViewHolder (LayoutInflater.FromContext (context).Inflate (Resource.Layout.row_layout, null));
			}

			public override int ItemCount {
				get  { return projects.Count; }
			}
		}

		public class MyViewHolder : Android.Support.V7.Widget.RecyclerView.ViewHolder
		{
			public MyViewHolder (View view)
				: base (view)
			{                
			}
		}


	
	}

}



