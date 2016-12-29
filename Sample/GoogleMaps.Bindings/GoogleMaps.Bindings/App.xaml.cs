using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps.Bindings;

namespace GoogleMaps.Bindings
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var behavior = new BindingVisibleRegionBehavior();

            MainPage = new NavigationPage(new MainPage());
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
