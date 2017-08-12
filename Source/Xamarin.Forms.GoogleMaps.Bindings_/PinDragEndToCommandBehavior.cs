namespace Xamarin.Forms.GoogleMaps.Bindings
{
    public sealed class PinDragEndToCommandBehavior : EventToCommandBehaviorBase
    {
        protected override void OnAttachedTo(Map bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.PinDragEnd += OnPinDragEnd;
        }

        protected override void OnDetachingFrom(Map bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.PinDragEnd -= OnPinDragEnd;
        }

        private void OnPinDragEnd(object sender, PinDragEventArgs args)
        {
            Command?.Execute(args);
        }
    }
}
