using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V4.View;

namespace eCademy.Xamarin_Swipe
{
    public class ImagePagerAdapter : PagerAdapter
    {
        Context context;

        public ImagePagerAdapter(Context context)
        {
            this.context = context;
        }

        public override Java.Lang.Object InstantiateItem(ViewGroup container, int position)
        {
            var imageView = new ImageView(context);
            imageView.SetImageResource(ImageHelper.StaticImages[position]);

            var viewPager = container.JavaCast<ViewPager>();
            viewPager.AddView(imageView);

            return imageView;
        }

        public override void DestroyItem(ViewGroup container, int position, Java.Lang.Object view)
        {
            var viewPager = container.JavaCast<ViewPager>();
            viewPager.RemoveView(view as View);
        }

        public override int Count => ImageHelper.StaticImages.Length;

        public override bool IsViewFromObject(View view, Java.Lang.Object @object) => view == @object;
    }
}