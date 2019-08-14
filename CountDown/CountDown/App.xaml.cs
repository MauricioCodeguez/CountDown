using CountDown.Repositories;
using CountDown.Views;
using Xamarin.Forms;

namespace CountDown
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

#if DEBUG
            HotReloader.Current.Run(this);
#endif

            DependencyService.Register<IPalavrasReservadasRepositorio, PalavrasReservadasRepositorio>();

            MainPage = new MainPage();
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
