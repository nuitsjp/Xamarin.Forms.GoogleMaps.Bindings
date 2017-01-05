using System;

namespace Xamarin.Forms.GoogleMaps.Bindings
{
	internal sealed class MoveToRegionRequestedEventArgs : EventArgs
    {
        public MapSpan MapSpan { get; }

		internal MoveToRegionRequestedEventArgs(MapSpan mapSpan)
        {
            MapSpan = mapSpan;
        }
    }
}
