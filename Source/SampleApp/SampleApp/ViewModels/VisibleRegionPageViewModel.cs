using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;
using Xamarin.Forms.GoogleMaps.Bindings;

namespace SampleApp.ViewModels
{
    public class VisibleRegionPageViewModel : ViewModelBase
    {
        private MapSpan _visibleRegion;
        public MapSpan VisibleRegion
        {
            get => _visibleRegion;
            set => SetProperty(ref _visibleRegion, value);
        }

        private bool _animated = true;
        public bool Animated
        {
            get => _animated;
            set => SetProperty(ref _animated, value);
        }

        public MoveToRegionRequest Request { get; } = new MoveToRegionRequest();


        public Command MoveToTokyoCommand => new Command(() =>
        {
            Request.MoveToRegion(
                MapSpan.FromCenterAndRadius(
                    new Position(35.681298, 139.766247),
                    Distance.FromKilometers(2)),
                Animated);
        });
    }
}
