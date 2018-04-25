using System;

using Xamarin.Forms;

namespace Darwin.Controls
{
    public class TileView : ContentView
    {

        public event EventHandler<TileTappedEventArgs> Tapped;

        public TileView(Models.Tile square)
        {
            RelativeLayout layout = new RelativeLayout();

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) => {
                EventHandler<TileTappedEventArgs> handler = Tapped;

                if (handler != null)
                {
                    handler(this, new TileTappedEventArgs(square.NavigateType));
                }
            };
            layout.GestureRecognizers.Add(tapGestureRecognizer);

            var backgroundImage = new Image()
            {
                Source = new FileImageSource() { File = square.BackgroundImage },
                Aspect = Aspect.AspectFill,
                InputTransparent = false
            };

            layout.Children.Add(backgroundImage,
                Constraint.Constant(0),
                Constraint.Constant(0),
                Constraint.RelativeToParent((parent) => {
                    return parent.Width;
                }),
                Constraint.RelativeToParent((parent) => {
                    return parent.Height;
                }));

            var iconImage = new Image()
            {
                Source = new FileImageSource() { File = square.IconImage },
                InputTransparent = true
            };

            layout.Children.Add(
                iconImage,
                Constraint.RelativeToParent((parent) => {
                    return ((parent.Width / 2) - (iconImage.Width / 2));
                }),
                Constraint.RelativeToParent((parent) => {
                    return parent.Height * .25;
                }),
                Constraint.RelativeToParent((parent) => {
                    return parent.Width * .45;
                }),
                Constraint.RelativeToParent((parent) => {
                    return parent.Width * .45;
                })
            );

            iconImage.SizeChanged += (sender, e) => {
                layout.ForceLayout();
            };

            var label = new Label()
            {
                Text = square.Text,
                HorizontalTextAlignment = TextAlignment.Center,
                TextColor = Color.White,
                FontFamily = Device.OnPlatform("AvenirNextCondensed-Bold", "sans-serif-condensed", null),
                InputTransparent = true
            };

            layout.Children.Add(label,
                Constraint.Constant(0),
                Constraint.RelativeToParent((parent) => {
                    return parent.Height - 30;
                }),
                Constraint.RelativeToParent((parent) => {
                    return parent.Width;
                }),
                Constraint.RelativeToParent((parent) => {
                    return parent.Height;
                }));

            Content = layout;
        }
    }
}
