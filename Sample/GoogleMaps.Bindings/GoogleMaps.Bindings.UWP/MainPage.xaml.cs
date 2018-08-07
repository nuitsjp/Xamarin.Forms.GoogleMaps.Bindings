namespace GoogleMaps.Bindings.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new GoogleMaps.Bindings.App());
        }
    }
}
