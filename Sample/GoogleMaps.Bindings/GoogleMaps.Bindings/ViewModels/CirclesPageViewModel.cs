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
    public class CirclesPageViewModel : ViewModelBase
    {
        public ObservableCollection<Circle> Circles { get; set; }

        public Command<MapClickedEventArgs> MapClickedCommand => new Command<MapClickedEventArgs>(
            args =>
            {
                var circle = new Circle();
                circle.Center = args.Point;
                circle.Radius = Distance.FromMeters(3000f);

                circle.StrokeColor = Color.Purple;
                circle.StrokeWidth = 6f;
                circle.FillColor = Color.FromRgba(0, 0, 255, 32);
                circle.Tag = "CIRCLE"; // Can set any object

                Circles.Add(circle);
            });
    }
}
