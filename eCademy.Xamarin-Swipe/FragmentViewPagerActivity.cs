using Android.OS;
using Android.Support.V4.View;
using Android.Content.PM;
using Android.App;
using Android.Support.V4.App;

namespace eCademy.Xamarin_Swipe
{
    [Activity(Label = "View Pager", ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize)]
    public class FragmentViewPagerActivity : FragmentActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.FragmentViewPager);

            var viewPager = FindViewById<ViewPager>(Resource.Id.pager);

            viewPager.Adapter = new ImageFragmentAdapter(SupportFragmentManager, ImageHelper.StaticImages);
            viewPager.CurrentItem = Intent.GetIntExtra("image_position", 0); ;
        }
    }
}