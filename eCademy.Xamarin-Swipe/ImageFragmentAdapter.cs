using Android.Content.Res;
using Android.Support.V4.App;

namespace eCademy.Xamarin_Swipe
{
    public class ImageFragmentAdapter : FragmentPagerAdapter
    {
        private readonly int[] imageResourceIds;

        public ImageFragmentAdapter(FragmentManager fragmentManager, int[] imageResourceIds) : base(fragmentManager)
        {
            this.imageResourceIds = imageResourceIds;
        }

        public override int Count => imageResourceIds.Length;

        public override Fragment GetItem(int position)
        {
            return new ImageFragment(imageResourceIds[position]);
        }

        public override Java.Lang.ICharSequence GetPageTitleFormatted(int position)
        {
            return new Java.Lang.String($"{(position + 1)}/{imageResourceIds.Length}");
        }
    }
}