using System;
using System.Threading.Tasks;

namespace Xamarin.Forms.GoogleMaps.Bindings
{
    public sealed class AnimateCameraRequest
    {
        internal AnimateCameraBehavior AnimateCameraBehavior { get; set; }
        public Task<AnimationStatus> AnimateCamera(CameraUpdate cameraUpdate, TimeSpan? duration = null)
        {
            if (AnimateCameraBehavior == null) throw new InvalidOperationException("Not binding to AnimateCameraBehavior.");

            return AnimateCameraBehavior.AnimateCamera(cameraUpdate, duration);
        }
    }
}
