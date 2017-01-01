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

        public Command<Position> MapClickedCommand => new Command<Position>((position) =>
        {
            Message = "MapClicked";
            Pin = new Pin
            {
                Label = $"Pin{Pins.Count}",
                Position = position,
            };
            Pins?.Add(Pin);
        });

        public Command<PinClickedEventArgs> PinClickedCommand => new Command<PinClickedEventArgs>(arg =>
        {
            Message = "PinClicked";
            Pin = arg.Pin;
        });
    }
}
