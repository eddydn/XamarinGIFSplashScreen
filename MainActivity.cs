using Android.App;
using Android.Widget;
using Android.OS;

namespace GIFSplashScreen
{
    [Activity(Label = "GIFSplashScreen",Theme ="@style/Theme.AppCompat.Light.NoActionBar")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView (Resource.Layout.Main);
        }
    }
}

