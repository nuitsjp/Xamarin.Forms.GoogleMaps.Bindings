using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;
using Xamarin.Forms.GoogleMaps.Bindings;
using System.Threading.Tasks;

namespace SampleApp.ViewModels
{
    public class RegionPageViewModel : ViewModelBase
    {
        private MapRegion _region;
        public MapRegion Region
        {
            get => _region;
            set => SetProperty(ref _region, value);
        }

        private bool _animated = true;
        public bool Animated
        {
            get => _animated;
            set => SetProperty(ref _animated, value);
        }

        public MoveToRegionRequest Request { get; } = new MoveToRegionRequest();

        ICommand centerOnMapPinCommand;
        public ICommand CenterOnMapPinCommand =>
            centerOnMapPinCommand ??
            (centerOnMapPinCommand = new Command(async () => await ExecuteCenterOnMapPinCommand()));

        private async Task ExecuteCenterOnMapPinCommand()
        {
            Request.MoveToRegion(
                MapSpan.FromCenterAndRadius(
                    new Position(35.681298, 139.766247),
                    Distance.FromMeters(500)),
                Animated);

        }
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
