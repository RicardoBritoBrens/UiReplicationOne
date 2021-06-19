using System;
using System.Collections.Generic;
using UIReplicationOne.ModelViews;
using Xamarin.Forms;

namespace UIReplicationOne.Views
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            BindingContext = new WelcomePageViewModel(Navigation);
            InitializeComponent();
        }
    }
}
