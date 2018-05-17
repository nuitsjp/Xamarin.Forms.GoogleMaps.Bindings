using Xamarin.Forms.Internals;

namespace Xamarin.Forms.GoogleMaps.Bindings
{
    [Preserve(AllMembers = true)]
    public sealed class CameraMoveStartedToCommandBehavior : EventToCommandBehaviorBase
    {
        protected override void OnAttachedTo(Map bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.CameraMoveStarted += OnCameraMoveStarted;
        }

        protected override void OnDetachingFrom(Map bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.CameraMoveStarted -= OnCameraMoveStarted;
        }

        private void OnCameraMoveStarted(object sender, CameraMoveStartedEventArgs cameraMoveStartedEventArgs)
        {
            Command?.Execute(cameraMoveStartedEventArgs);
        }
    }
}
