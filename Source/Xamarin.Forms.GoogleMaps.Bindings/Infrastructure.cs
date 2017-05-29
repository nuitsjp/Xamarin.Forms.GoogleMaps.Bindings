using Xamarin.Forms.GoogleMaps.Bindings;

// ReSharper disable once CheckNamespace
namespace Xamarin
{
    public static class FormsGoogleMapsBindings
    {
        public static void Init()
        {
            new BindingCirclesBehavior();
            new BindingGroundOverlaysBehavior();
            new BindingPinsBehavior();
            new BindingPolygonsBehavior();
            new BindingPolylinesBehavior();
            new BindingTileLayersBehavior();
            new BindingVisibleRegionBehavior();
            new InfoWindowClickedToCommandBehavior();
            new MapClickedToCommandBehavior();
            new MapLongClickedToCommandBehavior();
            new MoveToRegionBehavior();
            new PinClickedToCommandBehavior();
            new PinDragStartToCommandBehavior();
            new PinDraggingToCommandBehavior();
            new PinDragEndToCommandBehavior();
            new SelectedPinChangedToCommandBehavior();
        }
    }
}
