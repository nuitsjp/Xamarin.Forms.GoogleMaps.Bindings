using System;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace GoogleMaps.Bindings.ViewModels
{
    public class UpdateCameraPositionPageViewModel : ViewModelBase
    {
        private CameraUpdate _cameraUpdate = null;

        public CameraUpdate CameraUpdate
        {
            get => _cameraUpdate;
            set => SetProperty(ref _cameraUpdate, value);
        }

        private bool _animated = false;

        public bool Animated
        {
            get => _animated;
            set
            {
                _animated = value;
                Duration = _animated ? TimeSpan.FromSeconds(2) : (TimeSpan?)null;
            }
        }

        private TimeSpan? _duration;
        public TimeSpan? Duration
        {
            get => _duration;
            set => SetProperty(ref _duration, value);
        }

        public Command MoveToTokyoCommand => new Command(() =>
        {
            CameraUpdate =
                CameraUpdateFactory.NewCameraPosition(
                    new CameraPosition(
                        new Position(35.681298, 139.766247), // Tokyo
                        17d, // zoom
                        45d, // bearing(rotation)
                        60d // tilt
                    ));
        });

        public Command MoveToOsakaCommand => new Command(() =>
        {
            CameraUpdate =
                CameraUpdateFactory.NewCameraPosition(
                    new CameraPosition(
                        new Position(34.702485, 135.495951), // Tokyo
                        17d, // zoom
                        45d, // bearing(rotation)
                        60d // tilt
                    ));
        });
    }
}
