using System;
using Xamarin.Forms;

namespace GoogleMaps.Bindings.Views
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void NavigateVisibleRegion(object sender, EventArgs e)
        {
            Navigation.PushAsync(new VisibleRegionPage());
        }
    }
}
