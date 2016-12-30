using System.ComponentModel;

namespace Xamarin.Forms.GoogleMaps.Bindings
{
    [Preserve(AllMembers = true)]
    public class BindingVisibleRegionBehavior : BehaviorBase<Map>
    {
        public static readonly BindableProperty ValueProperty = BindableProperty.Create("Value", typeof(MapSpan), typeof(BindingVisibleRegionBehavior), default(MapSpan), BindingMode.OneWayToSource);

        public MapSpan Value
        {
            get { return (MapSpan)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        protected override void OnAttachedTo(Map bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.PropertyChanged += BindableOnPropertyChanged;
        }

        protected override void OnDetachingFrom(Map bindable)
        {
            bindable.PropertyChanged -= BindableOnPropertyChanged;
            base.OnDetachingFrom(bindable);
        }

        private void BindableOnPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            if (args.PropertyName == "VisibleRegion")
            {
                Value = AssociatedObject.VisibleRegion;
            }
        }
    }
}
