using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace SimplestSample
{
    public class MainPageViewModel
    {
        public ObservableCollection<Pin> Pins { get; set; }

        public Command<MapClickedEventArgs> MapClickedCommand => 
            new Command<MapClickedEventArgs>(args =>
            {
                Pins.Add(new Pin
                {
                    Label = $"Pin{Pins.Count}",
                    Position = args.Point
                });
            });
    }
}
