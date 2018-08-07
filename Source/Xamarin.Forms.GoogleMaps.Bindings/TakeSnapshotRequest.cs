using System;
using System.IO;
using System.Threading.Tasks;

namespace Xamarin.Forms.GoogleMaps.Bindings
{
    public sealed class TakeSnapshotRequest
    {
        internal TakeSnapshotBehavior TakeSnapshotBehavior { get; set; }
        public Task<Stream> TakeSnapshot()
        {
            if (TakeSnapshotBehavior == null) throw new InvalidOperationException("Not binding to TakeSnapshotBehavior.");

            return TakeSnapshotBehavior.TakeSnapshot();
        }
    }
}
