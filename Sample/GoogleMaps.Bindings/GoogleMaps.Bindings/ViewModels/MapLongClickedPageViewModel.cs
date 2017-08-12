using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace GoogleMaps.Bindings.ViewModels
{
    public class MapLongClickedPageViewModel : ViewModelBase
    {
        private int _clickedCount;

        public int ClickedCount
        {
            get => _clickedCount;
            set => SetProperty(ref _clickedCount, value);
        }

        public Command<MapLongClickedEventArgs> MapLongClickedCommand => new Command<MapLongClickedEventArgs>(
            args =>
            {
                ClickedCount++;
            });

    }
}
