using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace GoogleMaps.Bindings.ViewModels
{
    public class UpdateRegionPageViewModel : ViewModelBase
    {
        private MapSpan _region =
            MapSpan.FromCenterAndRadius(
                new Position(35.681298, 139.766247),
                Distance.FromKilometers(2));

        public MapSpan Region
        {
            get => _region;
            set => SetProperty(ref _region, value);
        }

        private bool _animated = false;
        public bool Animated
        {
            get => _animated;
            set => SetProperty(ref _animated, value);
        }

        public Command MoveToTokyoCommand => new Command(() =>
        {
            Region =
                MapSpan.FromCenterAndRadius(
                    new Position(35.681298, 139.766247),
                    Distance.FromKilometers(2));
        });

        public Command MoveToOsakaCommand => new Command(() =>
        {
            Region =
                MapSpan.FromCenterAndRadius(
                    new Position(34.702485, 135.495951),
                    Distance.FromKilometers(2));
        });
    }
}
