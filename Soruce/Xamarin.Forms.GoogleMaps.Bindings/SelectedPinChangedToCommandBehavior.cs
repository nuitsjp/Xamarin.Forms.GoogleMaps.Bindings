using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Forms.GoogleMaps.Bindings
{
    public class SelectedPinChangedToCommandBehavior : EventToCommandBehaviorBase
    {
        protected override void OnAttachedTo(Map bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.SelectedPinChanged += OnSelectedPinChanged;
        }

        protected override void OnDetachingFrom(Map bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.SelectedPinChanged -= OnSelectedPinChanged;
        }

        private void OnSelectedPinChanged(object sender, SelectedPinChangedEventArgs args)
        {
            Command?.Execute(args);
        }
    }
}
