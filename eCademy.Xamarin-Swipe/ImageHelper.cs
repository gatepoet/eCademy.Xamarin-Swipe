using System;
using Android.Content;
using Android.Widget;

namespace eCademy.Xamarin_Swipe
{
    public class ImageHelper
    {
        public static int[] StaticImages = new int[] {
            Resource.Drawable.acroyoga,
            Resource.Drawable.darth_vlad,
            Resource.Drawable.Kfh1uRi,
            Resource.Drawable.Margaret_Hamilton,
            Resource.Drawable.Margaret_Hamilton_1989,
            Resource.Drawable.Margaret_Hamilton_in_action,
            Resource.Drawable.math_dance,
            Resource.Drawable.Monument,
            Resource.Drawable.national_gallery,
            Resource.Drawable.original,
            Resource.Drawable.owl,
            Resource.Drawable.web_designer,
        };

        public static EventHandler<AdapterView.ItemClickEventArgs> StartPagerActivityFromClick(Context context)
        {
            return (sender, args) =>
            {
                var intent = new Intent(context, typeof(ViewPagerActivity));
                intent.PutExtra("image_position", args.Position);
                context.StartActivity(intent);
            };
        }
    }
}