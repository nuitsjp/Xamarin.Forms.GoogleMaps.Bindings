using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Forms.GoogleMaps.Bindings
{
    public sealed class MoveCameraRequest
    {
        public IMoveCameraInvoker MoveCameraInvoker { get; set; }
        public Task<AnimationStatus> MoveCamera(CameraUpdate cameraUpdate)
        {
            if(MoveCameraInvoker == null) throw new InvalidOperationException("Not binding to MoveCameraBehavior.");

            return MoveCameraInvoker.MoveCamera(cameraUpdate);
        }
    }
}
