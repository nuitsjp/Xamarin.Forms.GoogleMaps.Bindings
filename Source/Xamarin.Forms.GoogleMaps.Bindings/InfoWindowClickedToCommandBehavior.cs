using Xamarin.Forms.Internals;

namespace Xamarin.Forms.GoogleMaps.Bindings
{
    [Preserve(AllMembers = true)]
    public sealed class InfoWindowClickedToCommandBehavior : EventToCommandBehaviorBase
    {
        protected override void OnAttachedTo(Map bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.InfoWindowClicked += OnInfoWindowClicked;
        }

        protected override void OnDetachingFrom(Map bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.InfoWindowClicked -= OnInfoWindowClicked;
        }

        private void OnInfoWindowClicked(object sender, InfoWindowClickedEventArgs infoWindowClickedEventArgs)
        {
            Command?.Execute(infoWindowClickedEventArgs);
        }
    }
}
