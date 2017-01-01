using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Xamarin.Forms.GoogleMaps.Bindings
{
    public abstract class EventToCommandBehaviorBase : BehaviorBase<Map>
    {
        public static readonly BindableProperty CommandProperty = BindableProperty.Create("Command", typeof(ICommand), typeof(MapClickedToCommandBehavior), default(ICommand));

        protected ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }
    }
}
