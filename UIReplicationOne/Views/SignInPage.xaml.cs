using System;
using System.Collections.Generic;
using UIReplicationOne.ModelViews;
using Xamarin.Forms;

namespace UIReplicationOne.Views
{
    public partial class SignInPage : ContentPage
    {
        public SignInPage()
        {
            BindingContext = new SignInPageViewModel(Navigation);
            InitializeComponent();
        }
    }
}
