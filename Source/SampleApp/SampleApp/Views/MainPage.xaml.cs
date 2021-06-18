using System;
using Xamarin.Essentials;

namespace SampleApp.Views
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            var status = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
            if (status == PermissionStatus.Granted)
            {
                return;
            }

            await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
        }

        private void NavigateVisibleRegion(object sender, EventArgs e)
        {
            Navigation.PushAsync(new VisibleRegionPage());
        }

        private void NavigatePins(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PinsPage());
        }

        private void NavigatePolylines(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PolylinesPage());
        }

        private void NavigatePolygons(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PolygonsPage());
        }

        private void NavigateCircles(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CirclesPage());
        }

        private void NavigateTileLayers(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TileLayersPage());
        }

        private void NavigationGroundOverlays(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GroundOverlaysPage());
        }

        private void NavigationMapLongClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MapLongClickedPage());
        }

        private void MoveCameraClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MoveCameraPage());
        }

        private void AnimateCameraClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AnimateCameraPage());
        }

        private void TakeSnapshotClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TakeSnapshotPage());
        }

        private void UpdateRegionClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UpdateRegionPage());
        }

        private void UpdateCameraClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UpdateCameraPositionPage());
        }
    }
}
