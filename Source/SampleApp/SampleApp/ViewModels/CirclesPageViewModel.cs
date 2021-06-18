using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace SampleApp.ViewModels
{
    public class CirclesPageViewModel : ViewModelBase
    {
        public ObservableCollection<Circle> Circles { get; set; }

        public Command<MapClickedEventArgs> MapClickedCommand => new Command<MapClickedEventArgs>(
            args =>
            {
                var circle = new Circle
                {
                    Center = args.Point,
                    Radius = Distance.FromMeters(3000f),
                    StrokeColor = Color.Purple,
                    StrokeWidth = 6f,
                    FillColor = Color.FromRgba(0, 0, 255, 32),
                    Tag = "CIRCLE"
                };

                // Can set any object

                Circles.Add(circle);
            });
    }
}
