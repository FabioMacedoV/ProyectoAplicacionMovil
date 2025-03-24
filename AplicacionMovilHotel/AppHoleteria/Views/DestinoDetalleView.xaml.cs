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
    public partial class DestinoDetalleView : ContentPage
    {

        public DestinoDetalleView(DestinoModel destino)
        {
            InitializeComponent();
            BindingContext = destino;

        }

        private async void OnHotelSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Count == 0)
                return;

            // Obtener el hotel seleccionado
            var selectedHotel = (HotelModel)e.CurrentSelection.FirstOrDefault();

            // Navegar a la página de detalles pasando el hotel seleccionado
            await Navigation.PushAsync(new HotelDetalleView(selectedHotel));

            // Desmarcar selección para permitir futuras selecciones
            ((CollectionView)sender).SelectedItem = null;
        }
    }
}