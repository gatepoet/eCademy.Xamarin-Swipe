using Android.Content;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace eCademy.Xamarin_Swipe
{
    public class GridImageAdapter : BaseAdapter, ViewTreeObserver.IOnGlobalLayoutListener
    {
        private readonly Context context;
        private readonly GridView gridView;

        public GridImageAdapter(Context context, GridView gridView)
        {
            this.context = context;
            this.gridView = gridView;
        }

        public override int Count
        {
            get { return ImageHelper.StaticImages.Length; }
        }

        public int ImageSize { get; set; }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return ImageHelper.StaticImages[position];
        }

        // create a new ImageView for each item referenced by the Adapter
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            ImageView imageView;

            if (convertView == null)
            {  // if it's not recycled, initialize some attributes
                imageView = new ImageView(context);
                var layoutParams = new ViewGroup.LayoutParams(ImageSize, ImageSize);
                imageView.LayoutParameters = layoutParams;
                imageView.SetScaleType(ImageView.ScaleType.CenterCrop);
            }
            else
            {
                imageView = (ImageView)convertView;
            }

            imageView.SetImageResource(ImageHelper.StaticImages[position]);
            return imageView;
        }

        public void OnGlobalLayout()
        {
            var columns = gridView.Width / gridView.RequestedColumnWidth;
            var newImageSize = gridView.Width / columns;
            if (newImageSize != ImageSize)
            {
                ImageSize = newImageSize;
                NotifyDataSetChanged();
            }
        }
    }
}