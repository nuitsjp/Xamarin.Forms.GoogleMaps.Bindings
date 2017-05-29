using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace GoogleMaps.Bindings.ViewModels
{
    public class InfoWindowClickedPageViewModel : ViewModelBase
    {
        private int _clickedCount;
        private Pin _pin;

        public int ClickedCount
        {
            get { return _clickedCount; }
            set { SetProperty(ref _clickedCount, value); }
        }
        public Pin Pin
        {
            get { return _pin; }
            set { SetProperty(ref _pin, value); }
        }

        public ObservableCollection<Pin> Pins { get; set; }

        public Command<MapClickedEventArgs> MapClickedCommand => new Command<MapClickedEventArgs>(
            args =>
            {
                Pin = new Pin
                {
                    Label = "Click me",
                    Position = args.Point
                };
                Pins?.Add(Pin);
            });

        public Command<InfoWindowClickedEventArgs> InfoWindowClickedCommand => new Command<InfoWindowClickedEventArgs>(
            args =>
            {
                ClickedCount++;
            });

    }
}