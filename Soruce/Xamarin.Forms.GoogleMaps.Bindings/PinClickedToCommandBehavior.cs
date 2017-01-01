using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
