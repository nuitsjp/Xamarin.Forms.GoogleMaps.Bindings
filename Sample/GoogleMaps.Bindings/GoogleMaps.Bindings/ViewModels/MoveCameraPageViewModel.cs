using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;
using Xamarin.Forms.GoogleMaps.Bindings;

namespace GoogleMaps.Bindings.ViewModels
{
    public class MoveCameraPageViewModel
    {
        public MoveCameraRequest MoveCameraRequest { get; } = new MoveCameraRequest();
        public Command MoveToTokyoCommand => new Command(() =>
        {
            MoveCameraRequest.MoveCamera(CameraUpdateFactory.NewCameraPosition(
                new CameraPosition(
                    new Position(35.681298, 139.766247), // Tokyo
                    17d, // zoom
                    45d, // bearing(rotation)
                    60d // tilt
                )));
        });
    }
}
