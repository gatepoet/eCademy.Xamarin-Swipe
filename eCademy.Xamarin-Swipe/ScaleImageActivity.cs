using Android.App;
using Android.Content.PM;
using Android.OS;
using eCademy.Xamarin_Swipe.MonoDroidToolkit;

namespace eCademy.Xamarin_Swipe
{
    [Activity(ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize)]
    public class ScaleImageActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ScaleImage);

            var imageView = FindViewById<ScaleImageView>(Resource.Id.image);
            var imageResourceId = Intent.GetIntExtra("image_resourceId", 0);
            imageView.SetImageResource(imageResourceId);
        }
    }
}