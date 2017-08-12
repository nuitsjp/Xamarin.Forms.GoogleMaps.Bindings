using System.Threading.Tasks;

namespace Xamarin.Forms.GoogleMaps.Bindings
{
    public interface IMoveCameraInvoker
    {
        Task<AnimationStatus> MoveCamera(CameraUpdate cameraUpdate);
    }
}