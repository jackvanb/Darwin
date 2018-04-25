using System;
using Darwin.Controls;
using Darwin.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(HorizontalScrollView), typeof(HorizontalScrollViewRenderer))]
namespace Darwin.iOS.Renderers
{
    public class HorizontalScrollViewRenderer : ScrollViewRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            var element = e.NewElement as HorizontalScrollView;
            element?.Render();

            // Don't need these.
            ShowsHorizontalScrollIndicator = false;
        }
    }
}
