
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Hardware;
using Android.Support.Wearable.Views;
using Android.Graphics;

namespace AndroidWear
{
	[Activity (Label = "PunchActivity")]			
	public class PunchActivity : Activity, ISensorEventListener
	{
		private SensorManager sensorManager;
		private TextView _sensorTextView;
		private static readonly object _syncLock = new object ();
		bool isPlaying = true;
		bool isEnough = false;
		List<float> list = new List<float>();
		Button tryAgain;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.PunchLayout);
			var layout = FindViewById<WatchViewStub> (Resource.Id.punch_layout);
			layout.SetBackgroundColor (Color.ParseColor ("#006666"));
			sensorManager = (SensorManager) GetSystemService(Context.SensorService);
			layout.LayoutInflated += delegate {

				_sensorTextView = FindViewById<TextView>(Resource.Id.accelerometer_text);
				tryAgain = FindViewById<Button>(Resource.Id.tryAgain);
				tryAgain.Visibility = ViewStates.Invisible;
			};
			//_sensorTextView = FindViewById<TextView>(Resource.Id.textView1);
			// Create your application here
		}
		public void OnSensorChanged(SensorEvent e)
		{
			//_sensorTextView.Text = "Changed";
			lock (_syncLock)
			{
				if(isPlaying){
				var c = Math.Sqrt (e.Values [0] * e.Values [0] + e.Values [1] * e.Values [1] + e.Values [2] * e.Values [2]);
				var text = Math.Round(Math.Abs (c-9.806199),1);
				float acceleration =(float)( Math.Round(Math.Abs (c-9.806199),1));
				if (acceleration > 4.0) {
					list.Add (acceleration);
					isEnough = true;
				} else {
						if (isEnough) {
							isPlaying = false;
							tryAgain.Visibility = ViewStates.Visible;
							_sensorTextView.Text = list.Max () + "";
							list.Clear ();
							isEnough = false;
							tryAgain.Visibility = ViewStates.Visible; 
							tryAgain.Click += delegate {
								isPlaying = true;
								_sensorTextView.Text = "punch Wear";
								tryAgain.Visibility = ViewStates.Invisible;
							};

					
						}
					}
				}
			}
		}
		public void OnAccuracyChanged(Sensor sensor, SensorStatus accuracy)
		{

		}
		protected override void OnResume()
		{
			base.OnResume();
			sensorManager.RegisterListener(this, sensorManager.GetDefaultSensor(SensorType.Accelerometer), SensorDelay.Ui);
		}
		protected override void OnPause()
		{
			base.OnPause();
			sensorManager.UnregisterListener(this);
		}
	}
}

