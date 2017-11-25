using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Meme9gag;
using Meme9gag.Droid;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace Meme9gag.Droid
{
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.Transparent);
                Control.SetTextColor(global::Android.Graphics.Color.White);
                Control.SetShadowLayer(1.6f, 1, 1, global::Android.Graphics.Color.Black);
            }
        }
    }
}
