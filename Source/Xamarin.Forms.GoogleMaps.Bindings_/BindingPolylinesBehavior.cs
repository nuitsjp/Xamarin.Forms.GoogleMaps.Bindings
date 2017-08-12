using System.Collections.ObjectModel;

namespace Xamarin.Forms.GoogleMaps.Bindings
{
    public sealed class BindingPolylinesBehavior : BehaviorBase<Map>
    {
        private static readonly BindablePropertyKey ValuePropertyKey = BindableProperty.CreateReadOnly("Value", typeof(ObservableCollection<Polyline>), typeof(BindingPolylinesBehavior), default(ObservableCollection<Polyline>));

        public static readonly BindableProperty ValueProperty = ValuePropertyKey.BindableProperty;
        public ObservableCollection<Polyline> Value
        {
            get { return (ObservableCollection<Polyline>)GetValue(ValueProperty); }
            private set { SetValue(ValuePropertyKey, value); }
        }

        protected override void OnAttachedTo(Map bindable)
        {
            base.OnAttachedTo(bindable);
            Value = bindable.Polylines as ObservableCollection<Polyline>;
        }

        protected override void OnDetachingFrom(Map bindable)
        {
            base.OnDetachingFrom(bindable);
            Value = null;
        }
    }
}
