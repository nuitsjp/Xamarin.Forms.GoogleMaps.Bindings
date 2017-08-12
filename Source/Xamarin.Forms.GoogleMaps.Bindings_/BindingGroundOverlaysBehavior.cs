using System.Collections.ObjectModel;

namespace Xamarin.Forms.GoogleMaps.Bindings
{
    public sealed class BindingGroundOverlaysBehavior : BehaviorBase<Map>
    {
        private static readonly BindablePropertyKey ValuePropertyKey = BindableProperty.CreateReadOnly("Value", typeof(ObservableCollection<GroundOverlay>), typeof(BindingGroundOverlaysBehavior), default(ObservableCollection<GroundOverlay>));

        public static readonly BindableProperty ValueProperty = ValuePropertyKey.BindableProperty;
        public ObservableCollection<GroundOverlay> Value
        {
            get { return (ObservableCollection<GroundOverlay>)GetValue(ValueProperty); }
            private set { SetValue(ValuePropertyKey, value); }
        }

        protected override void OnAttachedTo(Map bindable)
        {
            base.OnAttachedTo(bindable);
            Value = bindable.GroundOverlays as ObservableCollection<GroundOverlay>;
        }

        protected override void OnDetachingFrom(Map bindable)
        {
            base.OnDetachingFrom(bindable);
            Value = null;
        }
    }
}
