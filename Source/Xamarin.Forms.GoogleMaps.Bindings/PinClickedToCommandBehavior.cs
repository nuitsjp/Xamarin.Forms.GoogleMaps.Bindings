namespace Xamarin.Forms.GoogleMaps.Bindings
{
    public class PinClickedToCommandBehavior : EventToCommandBehaviorBase
    {
        protected override void OnAttachedTo(Map bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.PinClicked += OnPinClicked;
        }

        protected override void OnDetachingFrom(Map bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.PinClicked -= OnPinClicked;
        }

        private void OnPinClicked(object sender, PinClickedEventArgs pinClickedEventArgs)
        {
            Command?.Execute(pinClickedEventArgs);
        }
    }
}
