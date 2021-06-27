using UIReplicationOne.Views;
using Xamarin.Forms;

namespace UIReplicationOne
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new WelcomePage());
        }


        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        void OnBackButtonPressed(System.Object sender, System.EventArgs e)
        {
        }
    }
}
