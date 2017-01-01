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
        private Pin _pin;
        private int _mapClickedCount;
        private int _pinClickedCount;
        private int _selectedPinChangedCount;
        private string _pinDragStatus;

        public int MapClickedCount
        {
            get { return _mapClickedCount; }
            set { SetProperty(ref _mapClickedCount, value); }
        }

        public int PinClickedCount
        {
            get { return _pinClickedCount; }
            set { SetProperty(ref _pinClickedCount, value); }
        }

        public int SelectedPinChangedCount
        {
            get { return _selectedPinChangedCount; }
            set { SetProperty(ref _selectedPinChangedCount, value); }
        }

        public string PinDragStatus
        {
            get { return _pinDragStatus; }
            set { SetProperty(ref _pinDragStatus, value); }
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
                MapClickedCount++;
                Pin = new Pin
                {
                    Label = $"Pin{Pins.Count}",
                    Position = args.Point
                };
                Pins?.Add(Pin);
            });

        public Command<PinClickedEventArgs> PinClickedCommand => new Command<PinClickedEventArgs>(
            args =>
            {
                PinClickedCount++;
                Pin = args.Pin;
            });

        public Command<SelectedPinChangedEventArgs> SelectedPinChangedCommand => new Command<SelectedPinChangedEventArgs>(
            args =>
            {
                SelectedPinChangedCount++;
                Pin = args.SelectedPin;
            });

        public Command<PinDragEventArgs> PinDragStartCommand => new Command<PinDragEventArgs>(
            args =>
            {
                PinDragStatus = "Start";
                Pin = args.Pin;
            });

        public Command<PinDragEventArgs> PinDraggingStartCommand => new Command<PinDragEventArgs>(
            args =>
            {
                PinDragStatus = "Dragging";
                Pin = args.Pin;
            });
    }
}
