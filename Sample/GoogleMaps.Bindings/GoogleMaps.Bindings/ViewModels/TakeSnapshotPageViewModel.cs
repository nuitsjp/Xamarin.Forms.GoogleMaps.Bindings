using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps.Bindings;

namespace GoogleMaps.Bindings.ViewModels
{
    public class TakeSnapshotPageViewModel : ViewModelBase
    {
        private ImageSource _imageSource;
        public TakeSnapshotRequest TakeSnapshotRequest { get; } = new TakeSnapshotRequest();

        public ImageSource ImageSource
        {
            get => _imageSource;
            set => SetProperty(ref _imageSource, value);
        }

        public Command TakeSnapshotCommand => new Command(async () =>
        {
            var stream = await TakeSnapshotRequest.TakeSnapshot();
            ImageSource = ImageSource.FromStream(() => stream);
        });
    }
}
