using System;

namespace Xamarin.Forms.GoogleMaps.Bindings
{
    public class UpdateCameraPositionBehavior : BehaviorBase<Map>
    {
        public static readonly BindableProperty CameraUpdateProperty =
            BindableProperty.Create("CameraUpdate", typeof(CameraUpdate), typeof(UpdateCameraPositionBehavior), default(CameraUpdate), propertyChanged: OnCameraUpdateChanged);

        public static readonly BindableProperty DurationProperty =
            BindableProperty.Create("Duration", typeof(TimeSpan?), typeof(UpdateRegionBehavior), null);

        public TimeSpan? Duration => (TimeSpan?)GetValue(DurationProperty);

        private static void OnCameraUpdateChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (newValue == null) return;

            var behavior = (UpdateCameraPositionBehavior)bindable;
            if(behavior.Duration == null)
            {
                behavior.AssociatedObject.MoveCamera((CameraUpdate)newValue);
            }
            else
            {
                behavior.AssociatedObject.AnimateCamera((CameraUpdate)newValue, behavior.Duration);
            }
        }
    }
}
