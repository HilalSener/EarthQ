using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Widget;
using Xamarin.Forms.Platform.Android;
using Button = Android.Widget.Button;

[assembly: Xamarin.Forms.ExportRenderer(typeof(EarthQ.CustomButton), typeof(EarthQ.Droid.CustomButtonRenderer))]
namespace EarthQ.Droid
{
    public class CustomButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);
            if (base.Control != null)
            {
                var button = this.Control;
                button.SetBackgroundColor(Color.Transparent);
                button.SetAllCaps(false);

                ImageButton imageButton = new ImageButton(this.Context);
                imageButton.SetBackgroundColor(Color.Transparent);
                imageButton.Background = null;
            }
        }
    }
}