using System;
using System.Windows.Input;
using UIReplicationOne.Services;
using UIReplicationOne.Views;
using Xamarin.Forms;

namespace UIReplicationOne.ModelViews
{
    public class WelcomePageViewModel
    {
        public ICommand NavigateToSignInPageCommand { get; set; }
        public ICommand FakeCreateAnAccountCommand { get; set; }
        public INavigation _navigation { get; set; }
        public WelcomePageViewModel(INavigation navigation)
        {
            NavigateToSignInPageCommand = new Command(NavigateToSignInPage);
            FakeCreateAnAccountCommand = new Command(FakeCreateAnAccount);
            _navigation = navigation;
        }

        private void FakeCreateAnAccount()
        {
            DependencyService.Get<IMessage>().LongAlert("Thanks to Create an account Mr/Ms User");
        }

        private void NavigateToSignInPage()
        {
            _navigation.PushAsync(new SignInPage());
        }
    }
}
