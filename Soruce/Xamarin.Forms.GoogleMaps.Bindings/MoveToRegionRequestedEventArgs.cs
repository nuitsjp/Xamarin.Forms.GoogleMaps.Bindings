using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Forms.GoogleMaps.Bindings
{
    public class MoveToRegionRequestedEventArgs : EventArgs
    {
        public MapSpan MapSpan { get; }

        public MoveToRegionRequestedEventArgs(MapSpan mapSpan)
        {
            MapSpan = mapSpan;
        }
    }
}
