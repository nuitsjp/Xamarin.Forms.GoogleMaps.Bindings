using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;
using Xamarin.Forms.GoogleMaps.Bindings;

namespace GoogleMaps.Bindings.ViewModels
{
    public class AnimateCameraPageViewModel
    {
        public AnimateCameraRequest AnimateCameraRequest { get; } = new AnimateCameraRequest();
        public Command MoveToTokyoCommand => new Command(() =>
        {
            AnimateCameraRequest.AnimateCamera(CameraUpdateFactory.NewCameraPosition(
                new CameraPosition(
                    new Position(35.681298, 139.766247), // Tokyo
                    17d, // zoom
                    45d, // bearing(rotation)
                    60d // tilt
                )), TimeSpan.FromSeconds(2)); ;
        });
    }
}
