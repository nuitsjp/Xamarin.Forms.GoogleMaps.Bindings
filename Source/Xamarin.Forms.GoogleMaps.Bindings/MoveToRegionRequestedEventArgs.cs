using System;

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
