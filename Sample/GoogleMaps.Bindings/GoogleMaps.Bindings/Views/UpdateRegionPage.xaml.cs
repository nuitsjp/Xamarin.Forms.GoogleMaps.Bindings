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
    public partial class UpdateRegionPage
    {
        public UpdateRegionPage()
        {
            InitializeComponent();
        }

        private void OnAppearing(object sender, EventArgs e)
        {
            //((UpdateRegionPageViewModel)BindingContext).MoveToTokyoCommand.Execute(null);
        }
    }
}