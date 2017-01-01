using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Forms.GoogleMaps.Bindings
{
    public class PinDragStartToCommandBehavior : EventToCommandBehaviorBase
    {
        protected override void OnAttachedTo(Map bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.PinDragStart += OnPinDragStart;
        }

        protected override void OnDetachingFrom(Map bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.PinDragStart -= OnPinDragStart;
        }

        private void OnPinDragStart(object sender, PinDragEventArgs args)
        {
            Command?.Execute(args);
        }
    }
}
