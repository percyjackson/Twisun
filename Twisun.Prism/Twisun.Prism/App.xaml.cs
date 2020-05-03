using Prism;
using Prism.Ioc;
using Twisun.Prism.ViewModels;
using Twisun.Prism.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Twisun.Prism
{
    public partial class App
    {
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/LoginPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<TwisunTabbedPage, TwisunTabbedPageViewModel>();
            containerRegistry.RegisterForNavigation<GeneralPage, GeneralPageViewModel>();
            containerRegistry.RegisterForNavigation<ForecastPage, ForecastPageViewModel>();
            containerRegistry.RegisterForNavigation<SolarPointsPage, SolarPointsPageViewModel>();
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
        }
    }
}
