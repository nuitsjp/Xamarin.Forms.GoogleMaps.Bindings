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

        private void NavigatePins(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PinsPage());
        }

        private void NavigatePolylines(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PolylinesPage());
        }

        private void NavigatePolygons(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PolygonsPage());
        }
    }
}
