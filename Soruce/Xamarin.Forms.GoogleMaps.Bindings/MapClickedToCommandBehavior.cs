using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Xamarin.Forms.GoogleMaps.Bindings
{
    public class MapClickedToCommandBehavior : BehaviorBase<Map>
    {
        public static readonly BindableProperty CommandProperty = BindableProperty.Create("Command", typeof(ICommand), typeof(MapClickedToCommandBehavior), default(ICommand));

        private ICommand Commmand
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value);}
        }

        protected override void OnAttachedTo(Map bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.MapClicked += OnMapClicked;
        }

        protected override void OnDetachingFrom(Map bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.MapClicked -= OnMapClicked;
        }

        private void OnMapClicked(object sender, MapClickedEventArgs mapClickedEventArgs)
        {
            Commmand?.Execute(mapClickedEventArgs.Point);
        }
    }
}
