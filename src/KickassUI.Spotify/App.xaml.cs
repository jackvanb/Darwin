using BottomBar.XamarinForms;
using Darwin.Controls;
using Darwin.PageModels;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Darwin
{
    public partial class App : Application
    {
        public App()
        {

            InitializeComponent();

            if (Device.RuntimePlatform == Device.iOS)
            {
                var tabs = new FreshMvvm.FreshTabbedNavigationContainer() { BarTextColor = Color.White, BarBackgroundColor = Color.Black };

                tabs.AddTab<MainPageModel>("Discover", "icon_home.png");
                tabs.AddTab<PlaylistPageModel>("Playlist", "icon_browse.png");
                tabs.AddTab<SearchPageModel>("Search", "icon_search.png");
				tabs.AddTab<NotificationsPageModel>("Notifications", "icon_radio.png");
                tabs.AddTab<ProfilePageModel>("Profile", "icon_library.png");

                MainPage = tabs;
            }
            else
            {
                var bottomBarPage = new CustomNavigation() { BarTextColor = Color.White, BarBackgroundColor = Color.Black };

                bottomBarPage.FixedMode = true;
                bottomBarPage.BarTheme = BottomBarPage.BarThemeTypes.DarkWithoutAlpha;
                bottomBarPage.BarTextColor = Color.White;

                bottomBarPage.AddTab<MainPageModel>("Home", "icon_home.png");
                bottomBarPage.AddTab<EmptyPageModel>("Browse", "icon_browse.png");
                bottomBarPage.AddTab<EmptyPageModel>("Search", "icon_search.png");
                bottomBarPage.AddTab<EmptyPageModel>("Radio", "icon_radio.png");
                bottomBarPage.AddTab<EmptyPageModel>("Your Library", "icon_library.png");

                MainPage = bottomBarPage;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
