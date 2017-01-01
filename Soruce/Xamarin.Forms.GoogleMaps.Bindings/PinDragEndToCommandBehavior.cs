using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Forms.GoogleMaps.Bindings
{
    public class PinDragEndToCommandBehavior : EventToCommandBehaviorBase
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
