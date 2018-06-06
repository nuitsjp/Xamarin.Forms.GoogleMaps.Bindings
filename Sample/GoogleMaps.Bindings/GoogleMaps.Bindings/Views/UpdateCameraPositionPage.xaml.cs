using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using GoogleMaps.Bindings.ViewModels;

namespace GoogleMaps.Bindings.Views
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