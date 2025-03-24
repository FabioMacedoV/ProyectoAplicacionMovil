using AplicacionMovilHotel.AppHoleteria.Models;
using AplicacionMovilHotel.AppHoleteria.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AplicacionMovilHotel.AppHoleteria.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchView : ContentPage
    {
        private DestinoViewModel viewModel;
        public SearchView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, true);
            viewModel = new DestinoViewModel();
            BindingContext = viewModel;
        }

        private void fnBuscarDestino(object sender, TextChangedEventArgs e)
        {
            viewModel.BuscarDestino(e.NewTextValue);
        }

        private async void OnDestinoSeleccionado(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) return;

            var destinoSeleccionado = (DestinoModel)e.SelectedItem;

            await Navigation.PushAsync(new DestinoDetalleView(destinoSeleccionado));

            ((ListView)sender).SelectedItem = null;
        }
    }
}