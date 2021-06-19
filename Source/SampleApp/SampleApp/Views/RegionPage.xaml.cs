using System;
using SampleApp.ViewModels;

namespace SampleApp.Views
{
    public partial class RegionPage
    {
        public RegionPage()
        {
            InitializeComponent();
        }

        private void RegionPage_OnAppearing(object sender, EventArgs e)
        {
            ((RegionPageViewModel)BindingContext).CenterOnMapPinCommand.Execute(null);
        }
    }
}
