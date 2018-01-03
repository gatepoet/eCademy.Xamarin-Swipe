using Android.App;
using Android.Widget;
using Android.OS;
using Android.Util;
using Android.Views;

namespace eCademy.Xamarin_Swipe
{
    [Activity(Label = "eCademy.Xamarin_Swipe", MainLauncher = true, Theme = "@android:style/Theme.Material.Light.NoActionBar")]
    public class MainActivity : Activity
    {
        private GridView gridView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

            gridView = FindViewById<GridView>(Resource.Id.gridView);
            var adapter = new GridImageAdapter(this, gridView);
            gridView.Adapter = adapter;
            gridView.ViewTreeObserver.AddOnGlobalLayoutListener(adapter);
            gridView.Drag += GridView_Drag; ;
        }

        private void GridView_Drag(object sender, View.DragEventArgs e)
        {
            switch (e.Event.Action)
            {
                case DragAction.Started:
                    e.Handled = true;
                    break;
                case DragAction.Entered:
                case DragAction.Exited:
                    break;
                case DragAction.Drop:
                    e.Handled = true;
                    var data = e.Event.ClipData.GetItemAt(0).Text;
                    Log.Info("eCademy", $"Data: {data}");
                    break;
                case DragAction.Ended:
                    e.Handled = true;
                    break;
                case DragAction.Location:
                    break;
                default:
                    break;
            }
        }
    }
}
