using System.Collections.ObjectModel;

namespace Xamarin.Forms.GoogleMaps.Bindings
{
    public class BindingTileLayersBehavior : BehaviorBase<Map>
    {
        private static readonly BindablePropertyKey ValuePropertyKey = BindableProperty.CreateReadOnly("Value", typeof(ObservableCollection<TileLayer>), typeof(BindingTileLayersBehavior), default(ObservableCollection<TileLayer>));

        public static readonly BindableProperty ValueProperty = ValuePropertyKey.BindableProperty;
        public ObservableCollection<TileLayer> Value
        {
            get { return (ObservableCollection<TileLayer>)GetValue(ValueProperty); }
            private set { SetValue(ValuePropertyKey, value); }
        }

        protected override void OnAttachedTo(Map bindable)
        {
            base.OnAttachedTo(bindable);
            Value = bindable.TileLayers as ObservableCollection<TileLayer>;
        }

        protected override void OnDetachingFrom(Map bindable)
        {
            base.OnDetachingFrom(bindable);
            Value = null;
        }
    }
}
