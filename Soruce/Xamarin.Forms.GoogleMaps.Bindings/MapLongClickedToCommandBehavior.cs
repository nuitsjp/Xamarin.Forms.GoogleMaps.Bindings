using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Xamarin.Forms.GoogleMaps.Bindings
{
    public class MapLongClickedToCommandBehavior : EventToCommandBehaviorBase
    {
        protected override void OnAttachedTo(Map bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.MapLongClicked += OnMapLongClicked;
        }

        protected override void OnDetachingFrom(Map bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.MapLongClicked -= OnMapLongClicked;
        }

        private void OnMapLongClicked(object sender, MapLongClickedEventArgs args)
        {
            Command?.Execute(args);
        }
    }
}
