using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;
using Xamarin.Forms.GoogleMaps.Bindings;

namespace GoogleMaps.Bindings.ViewModels
{
    public class VisibleRegionPageViewModel : ViewModelBase
    {
        private MapSpan _visibleRegion;

        public MapSpan VisibleRegion
        {
            get { return _visibleRegion; }
            set { SetProperty(ref _visibleRegion, value); }
        }

        public MoveToRegionRequest Request { get; } = new MoveToRegionRequest();


        public Command MoveToTokyoCommand => new Command(() =>
        {
            Request.MoveToRegion( 
                MapSpan.FromCenterAndRadius(
                    new Position(35.681298, 139.766247), 
                    Distance.FromKilometers(2)));
        });
    }
}
