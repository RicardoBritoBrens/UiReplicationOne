﻿using System;
using UIReplicationOne.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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
    }
}