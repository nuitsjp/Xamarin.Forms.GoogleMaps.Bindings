using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Forms.GoogleMaps.Bindings
{
    public class MoveToRegionBehavior : BehaviorBase<Map>
    {
        public static readonly BindableProperty RequestProperty = BindableProperty.Create("Request", typeof(MoveToRegionRequest), typeof(BindingVisibleRegionBehavior), default(MoveToRegionRequest), propertyChanged:OnRegionChanged);

        public MoveToRegionRequest Request
        {
            get { return (MoveToRegionRequest)GetValue(RequestProperty); }
            set { SetValue(RequestProperty, value); }
        }
        private static void OnRegionChanged(BindableObject bindable, object oldValue, object newValue)
        {
            ((MoveToRegionBehavior)bindable).OnRegionChanged(oldValue as MoveToRegionRequest, newValue as MoveToRegionRequest);
        }

        private void OnRegionChanged(MoveToRegionRequest oldValue, MoveToRegionRequest newValue)
        {
            if (oldValue != null)
            {
                oldValue.MoveToRegionRequested -= OnMoveToRegionRequested;
            }
            if (newValue != null)
            {
                newValue.MoveToRegionRequested += OnMoveToRegionRequested;
            }
        }

        private void OnMoveToRegionRequested(object sender, MoveToRegionRequestedEventArgs moveToRegionRequestedEventArgs)
        {
            if (moveToRegionRequestedEventArgs.MapSpan != null)
            {
                AssociatedObject.MoveToRegion(moveToRegionRequestedEventArgs.MapSpan);
            }
        }
    }
}
