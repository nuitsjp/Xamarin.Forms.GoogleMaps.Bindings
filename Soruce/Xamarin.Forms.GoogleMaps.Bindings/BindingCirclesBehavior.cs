using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Forms.GoogleMaps.Bindings
{
    public class BindingCirclesBehavior : BehaviorBase<Map>
    {
        private static readonly BindablePropertyKey ValuePropertyKey = BindableProperty.CreateReadOnly("Value", typeof(ObservableCollection<Circle>), typeof(BindingCirclesBehavior), default(ObservableCollection<Circle>));

        public static readonly BindableProperty ValueProperty = ValuePropertyKey.BindableProperty;
        public ObservableCollection<Circle> Value
        {
            get { return (ObservableCollection<Circle>)GetValue(ValueProperty); }
            private set { SetValue(ValuePropertyKey, value); }
        }

        protected override void OnAttachedTo(Map bindable)
        {
            base.OnAttachedTo(bindable);
            Value = bindable.Circles as ObservableCollection<Circle>;
        }

        protected override void OnDetachingFrom(Map bindable)
        {
            base.OnDetachingFrom(bindable);
            Value = null;
        }
    }
}
