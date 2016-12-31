using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Forms.GoogleMaps.Bindings
{
    public class BindingPinsBehavior : BehaviorBase<Map>
    {
        private static readonly BindablePropertyKey PinsPropertyKey = BindableProperty.CreateReadOnly("Pins",
            typeof(ObservableCollection<Pin>), typeof(BindingVisibleRegionBehavior), default(ObservableCollection<Pin>), BindingMode.OneWayToSource);

        public static readonly BindableProperty PinsProperty = PinsPropertyKey.BindableProperty;

        public ObservableCollection<Pin> Value
        {
            set { SetValue(PinsProperty, value);}
        }
    }
}
