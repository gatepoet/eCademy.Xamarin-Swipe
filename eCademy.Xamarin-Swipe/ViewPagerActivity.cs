using Android.App;
using Android.OS;
using Android.Support.V4.View;
using Android.Content.PM;

namespace eCademy.Xamarin_Swipe
{
    [Activity(Label = "View Pager", ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize)]
    public class ViewPagerActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var viewPager = new ViewPager(this);
            viewPager.Adapter = new ImagePagerAdapter(this);
            viewPager.CurrentItem = Intent.GetIntExtra("image_position", 0); ;

            SetContentView(viewPager);
        }
    }
}