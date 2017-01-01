using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace GoogleMaps.Bindings.ViewModels
{
    public class PinsPageViewModel : ViewModelBase
    {
        public ObservableCollection<Pin> Pins { get; set; }

        public Command<Position> MapClickedCommand => new Command<Position>((position) =>
        {
            Pins?.Add(
                new Pin
                {
                    Label = $"Pin{Pins.Count}",
                    Position = position,
                });
        });
    }
}
