using System;
using System.Windows.Input;
using Xamarin.Forms;

using System.Threading.Tasks;

namespace UIReplicationOne.ModelViews
{
    public class SignInPageViewModel
    {
        public ICommand SignInFakeCommand { get; set; }
        public INavigation _navigation { get; set; }
        public SignInPageViewModel(INavigation navigation)
        {
            SignInFakeCommand = new Command(async () => await FakeSignInAsync());
            _navigation = navigation;
        }

        private async Task FakeSignInAsync()
        {
            Console.WriteLine("Implement logic to log in or just show a message");
        }
    }
}
