using System;
using System.Threading.Tasks;
using Xamarin.Forms.Internals;

namespace Xamarin.Forms.GoogleMaps.Bindings
{
    [Preserve(AllMembers = true)]
    public sealed class AnimateCameraBehavior : BehaviorBase<Map>
    {
        public static readonly BindableProperty RequestProperty = BindableProperty.Create("Request", typeof(AnimateCameraRequest), typeof(AnimateCameraBehavior), null, propertyChanged: OnRequestChanged);

        private static void OnRequestChanged(BindableObject bindable, object oldValue, object newValue)
        {
            ((AnimateCameraBehavior)bindable).OnRequestChanged(oldValue as AnimateCameraRequest, newValue as AnimateCameraRequest);
        }

        private void OnRequestChanged(AnimateCameraRequest oldValue, AnimateCameraRequest newValue)
        {
            if (oldValue != null)
            {
                oldValue.AnimateCameraBehavior = null;
            }
            if (newValue != null)
            {
                newValue.AnimateCameraBehavior = this;
            }
        }

        public Task<AnimationStatus> AnimateCamera(CameraUpdate cameraUpdate, TimeSpan? duration = null)
        {
            return AssociatedObject.AnimateCamera(cameraUpdate, duration);
        }
    }
}
