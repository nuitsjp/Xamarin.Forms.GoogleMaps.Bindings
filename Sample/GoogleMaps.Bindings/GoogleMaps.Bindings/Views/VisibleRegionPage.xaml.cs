using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace GoogleMaps.Bindings.Views
{
    public partial class VisibleRegionPage : ContentPage
    {
        public VisibleRegionPage()
        {
            InitializeComponent();
            MyMap.PropertyChanged += (sender, args) =>
            {
                if (args.PropertyName == "VisibleRegion")
                {
                    var center = MyMap.VisibleRegion.Center;
                    DirectLocationText.Text = $"{center.Longitude}, {center.Latitude}";
                }
            };
        }
    }
}
