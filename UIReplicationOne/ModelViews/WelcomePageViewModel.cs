using System;
using System.Windows.Input;
using UIReplicationOne.Views;
using Xamarin.Forms;

namespace UIReplicationOne.ModelViews
{
    public class WelcomePageViewModel
    {
        public ICommand NavigateToSignInPageCommand { get; set; }
        public INavigation _navigation { get; set; }
        public WelcomePageViewModel(INavigation navigation)
        {
            NavigateToSignInPageCommand = new Command(NavigateToSignInPage);
            _navigation = navigation;
        }

        private void NavigateToSignInPage()
        {
            _navigation.PushAsync(new SignInPage());
        }
    }
}
