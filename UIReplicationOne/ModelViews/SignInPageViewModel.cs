using System;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;
using UIReplicationOne.Services;
using UIReplicationOne.ModelViews.Base;

namespace UIReplicationOne.ModelViews
{
    public class SignInPageViewModel : BaseViewModel
    {
        public ICommand FakeSignInCommand { get; set; }
        public ICommand FakeSignUpCommand { get; set; }
        public ICommand FakeForgotPasswordCommand { get; set; }
        public ICommand NavigateBackCommand { get; set; }
        public INavigation _navigation { get; set; }


        private bool _actionEnable;
        public bool ActionEnable
        {
            get { return _actionEnable; }
            set
            {
                SetProperty(ref _actionEnable, value);
                SignInOpacity = (ActionEnable) ? 1.0d : 0.5d;
            }
        }
        public double SignInOpacity
        {
            get => _signInOpacity;
            set
            {
                _signInOpacity = value;
                OnPropertyChanged();
            }
        }
        private double _signInOpacity;
        public bool UsernameValid
        {
            get => _usernameValid;
            set
            {
                _usernameValid = value;
                OnPropertyChanged();
            }
        }
        public bool PasswordValid
        {
            get => _passwordValid;
            set
            {
                _passwordValid = value;
                OnPropertyChanged();
            }
        }

        public bool _usernameValid;
        public bool _passwordValid;
        public string Username
        {
            get => _username;
            set
            {
                _username = value;
                OnPropertyChanged();
                UsernameValid = (!string.IsNullOrWhiteSpace(Username) && Username.Length > 5);
                ActionEnable = (UsernameValid && PasswordValid);

            }
        }
        private string _username;

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged();
                PasswordValid = (!string.IsNullOrWhiteSpace(Password) && Password.Length > 5);
                ActionEnable = (UsernameValid && PasswordValid);

            }
        }
        private string _password;


        public SignInPageViewModel(INavigation navigation)
        {
            FakeSignInCommand = new Command(FakeSignInAsync);
            FakeSignUpCommand = new Command(FakeSignUp);
            FakeForgotPasswordCommand = new Command(ForgotPassowrd);
            NavigateBackCommand = new Command(async () => await NavigateBack());
            UsernameValid = false;
            PasswordValid = false;
            SignInOpacity = 0.5d;
            ActionEnable = false;
            _navigation = navigation;
        }

        private void ForgotPassowrd()
        {
            DependencyService.Get<IMessage>().LongAlert("Working on this feature, Mr/Ms User");
        }

        private void FakeSignUp()
        {
            DependencyService.Get<IMessage>().LongAlert("Thanks for sign up, Mr/Ms User");
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
