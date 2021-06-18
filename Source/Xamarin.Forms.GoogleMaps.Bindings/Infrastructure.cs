using System.Diagnostics.CodeAnalysis;
using Xamarin.Forms.GoogleMaps.Bindings;
namespace Xamarin
{
    public static class FormsGoogleMapsBindings
    {
        [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
        public static void Init()
        {
            new BindingCirclesBehavior();
            new BindingGroundOverlaysBehavior();
            new BindingPinsBehavior();
            new BindingPolygonsBehavior();
            new BindingPolylinesBehavior();
            new BindingTileLayersBehavior();
#pragma warning disable CS0618 // 型またはメンバーが旧型式です
            new BindingVisibleRegionBehavior();
#pragma warning restore CS0618 // 型またはメンバーが旧型式です
            new BindingRegionBehavior();
            new MapClickedToCommandBehavior();
            new MapLongClickedToCommandBehavior();
            new MoveToRegionBehavior();
            new PinClickedToCommandBehavior();
            new PinDragStartToCommandBehavior();
            new PinDraggingToCommandBehavior();
            new PinDragEndToCommandBehavior();
            new SelectedPinChangedToCommandBehavior();
            new InfoWindowClickedToCommandBehavior();
        }
    }
}
