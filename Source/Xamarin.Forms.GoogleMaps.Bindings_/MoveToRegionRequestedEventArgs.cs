using System;

namespace Xamarin.Forms.GoogleMaps.Bindings
{
    internal sealed class MoveToRegionRequestedEventArgs : EventArgs
    {
        internal MapSpan MapSpan { get; }

        internal MoveToRegionRequestedEventArgs(MapSpan mapSpan)
        {
            MapSpan = mapSpan;
        }
    }
}
