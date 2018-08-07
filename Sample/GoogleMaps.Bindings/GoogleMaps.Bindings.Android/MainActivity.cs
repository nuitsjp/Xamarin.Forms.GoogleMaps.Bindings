using Android.App;
using Android.Content.PM;
using Android.OS;

namespace GoogleMaps.Bindings.Droid
{
    [Activity(Label = "GoogleMaps.Bindings", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            Xamarin.Forms.Forms.Init(this, bundle);
            Xamarin.FormsGoogleMaps.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

