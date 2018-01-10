using Android.Content;
using Android.OS;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;

namespace eCademy.Xamarin_Swipe
{
    public class ImageFragment : Fragment
    {
        private int imageResourceId;

        public ImageFragment(int imageResourceId)
        {
            this.imageResourceId = imageResourceId;
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.ImageFragment, container, false);
            var imageView = view.FindViewById<ImageView>(Resource.Id.image);
            imageView.SetImageResource(imageResourceId);
            imageView.LongClick += ImageView_LongClick;
            var textView = view.FindViewById<TextView>(Resource.Id.label);
            textView.Text = Resources.GetResourceEntryName(imageResourceId);

            return view;
        }

        private void ImageView_LongClick(object sender, View.LongClickEventArgs e)
        {
            var intent = new Intent(Context, typeof(ScaleImageActivity));
            intent.PutExtra("image_resourceId", imageResourceId);
            StartActivity(intent);
        }
    }
}