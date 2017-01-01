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
        private string _message;
        private Pin _pin;

        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public Pin Pin
        {
            get { return _pin; }
            set { SetProperty(ref _pin, value); }
        }

        public ObservableCollection<Pin> Pins { get; set; }

        public Command<MapClickedEventArgs> MapClickedCommand => new Command<MapClickedEventArgs>((args) =>
        {
            Message = "MapClicked";
            Pin = new Pin
            {
                Label = $"Pin{Pins.Count}",
                Position = args.Point
            };
            Pins?.Add(Pin);
        });

        public Command<PinClickedEventArgs> PinClickedCommand => new Command<PinClickedEventArgs>(args =>
        {
            Message = "PinClicked";
            Pin = args.Pin;
        });
    }
}
