using System;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Plugin.CurrentActivity;

namespace TimerPro.Droid
{
    [Activity(Label = "TimerPro", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        private Activity currentActivity = CrossCurrentActivity.Current.Activity;
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }

        void SendMessage(string message)
        {
            Toast.MakeText(this, message, ToastLength.Short).Show();
        }

        void SendConfirmation(string title, string message, Action<bool> action, string yes, string no)
        {
            var builder = new AlertDialog.Builder(currentActivity);
            
            builder
                .SetTitle(title ?? string.Empty)
                .SetMessage(message)
                .SetPositiveButton(yes, delegate { action(true); }).SetNegativeButton(no, delegate { action(false); });

            RunOnUiThread(() =>
            {
                var alert = builder.Create();
                alert.Show();
            });
        }
    }
}