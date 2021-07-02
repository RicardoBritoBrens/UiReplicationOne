using System;
using System.Windows.Input;
using Xamarin.Forms;

using System.Threading.Tasks;
using UIReplicationOne.Services;

namespace UIReplicationOne.ModelViews
{
    public class SignInPageViewModel
    {
        public ICommand FakeSignInCommand { get; set; }
        public ICommand FakeSignUpCommand { get; set; }
        public ICommand FakeForgotPasswordCommand { get; set; }
        public ICommand NavigateBackCommand { get; set; }
        public INavigation _navigation { get; set; }
        public SignInPageViewModel(INavigation navigation)
        {
            FakeSignInCommand = new Command(FakeSignInAsync);
            FakeSignUpCommand = new Command(FakeSignUp);
            FakeForgotPasswordCommand = new Command(ForgotPassowrd);
            NavigateBackCommand = new Command(async () => await NavigateBack());
            _navigation = navigation;
        }

        private void ForgotPassowrd()
        {
            DependencyService.Get<IMessage>().LongAlert("Working on this feature, Mr/Ms User");
        }

        private void FakeSignUp()
        {
            DependencyService.Get<IMessage>().LongAlert("Thanks for Sign Up Mr/Ms User");
        }

        private void FakeSignInAsync()
        {
            DependencyService.Get<IMessage>().LongAlert("Thanks for Sign In Mr/Ms User");
        }

        private async Task NavigateBack()
        {
            await _navigation.PopAsync();
        }
    }
}
