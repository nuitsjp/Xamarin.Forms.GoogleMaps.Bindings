using System;

namespace Xamarin.Forms.GoogleMaps.Bindings
{
    public sealed class MoveToRegionRequest
    {
        internal event EventHandler<MoveToRegionRequestedEventArgs> MoveToRegionRequested;

        public void MoveToRegion(MapSpan mapSpan)
        {
            MoveToRegionRequested?.Invoke(this, new MoveToRegionRequestedEventArgs(mapSpan));
        }
    }
}
