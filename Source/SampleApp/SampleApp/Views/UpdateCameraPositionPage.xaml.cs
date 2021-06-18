using System;
using SampleApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UpdateCameraPositionPage : ContentPage
    {
        public UpdateCameraPositionPage()
        {
            InitializeComponent();
        }

        private void ContentPage_Appearing(object sender, EventArgs e)
        {
            ((UpdateCameraPositionPageViewModel)BindingContext).MoveToTokyoCommand.Execute(true);
        }
    }
}