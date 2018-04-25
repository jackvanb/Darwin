using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Darwin.Controls;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace Darwin.Pages
{
    public partial class PlayerPage : ModalPage
    {
        public PlayerPage()
        {
            InitializeComponent();

            artwork.On<iOS>().UseBlurEffect(BlurEffectStyle.Dark);
        }
    }
}
