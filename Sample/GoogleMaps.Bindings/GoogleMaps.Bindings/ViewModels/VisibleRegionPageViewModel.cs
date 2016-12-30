using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.GoogleMaps;

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
    }
}
