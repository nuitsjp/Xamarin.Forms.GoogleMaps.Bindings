namespace Xamarin.Forms.GoogleMaps.Bindings
{
    public sealed class PinDraggingToCommandBehavior : EventToCommandBehaviorBase
    {
        protected override void OnAttachedTo(Map bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.PinDragging += OnPinDragging;
        }

        protected override void OnDetachingFrom(Map bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.PinDragging -= OnPinDragging;
        }

        private void OnPinDragging(object sender, PinDragEventArgs args)
        {
            Command?.Execute(args);
        }
    }
}
