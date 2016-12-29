using GoogleMaps.Bindings.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GoogleMaps.Bindings
{
    public partial class MainPage : ContentPage
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
