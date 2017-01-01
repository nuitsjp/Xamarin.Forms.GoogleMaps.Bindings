using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace GoogleMaps.Bindings.ViewModels
{
    public class GroundOverlaysPageViewModel : ViewModelBase
    {
        public ObservableCollection<GroundOverlay> GroundOverlays { get; set; }

        public Command<MapClickedEventArgs> MapClickedCommand => new Command<MapClickedEventArgs>(
            args =>
            {
                var icon = BitmapDescriptorFactory.FromBundle("image01.png");
                var overlay = new GroundOverlay()
                {
                    Bounds = new Bounds(args.Point, new Position(args.Point.Latitude + 0.001d, args.Point.Longitude + 0.001d)),
                    Icon = icon,
                    Transparency = 0.5f,
                    Tag = "THE GROUNDOVERLAY"
                };
                GroundOverlays.Add(overlay);
            });
    }
}
