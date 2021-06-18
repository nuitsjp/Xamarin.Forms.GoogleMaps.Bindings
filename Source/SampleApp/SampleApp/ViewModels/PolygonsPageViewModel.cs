using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace SampleApp.ViewModels
{
    public class PolygonsPageViewModel : ViewModelBase
    {
        public ObservableCollection<Polygon> Polygons { get; set; }

        public Command<MapClickedEventArgs> MapClickedCommand => new Command<MapClickedEventArgs>(
            args =>
            {
                var position = args.Point;
                var polygon = new Polygon();
                polygon.Positions.Add(position);
                polygon.Positions.Add(new Position(position.Latitude - 0.02d, position.Longitude - 0.01d));
                polygon.Positions.Add(new Position(position.Latitude - 0.02d, position.Longitude + 0.01d));
                polygon.Positions.Add(position);

                polygon.IsClickable = true;
                polygon.StrokeColor = Color.Green;
                polygon.StrokeWidth = 3f;
                polygon.FillColor = Color.FromRgba(255, 0, 0, 64);
                polygon.Tag = "POLYGON"; // Can set any object

                Polygons.Add(polygon);
            });
    }
}
