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

            var selectedHotel = (HotelModel)e.CurrentSelection.FirstOrDefault();

            await Navigation.PushAsync(new HotelDetalleView(selectedHotel));

            ((CollectionView)sender).SelectedItem = null;
        }

        private async void OnHotelSelectedRes(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Count == 0)
                return;

            var selectedHotel = (RestauranteModel)e.CurrentSelection.FirstOrDefault();

            await Navigation.PushAsync(new RestauranteDetalleView(selectedHotel));

            ((CollectionView)sender).SelectedItem = null;
        }

        private async void OnHotelSelectedTra(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Count == 0)
                return;

            var selectedHotel = (TransporteModel)e.CurrentSelection.FirstOrDefault();

            await Navigation.PushAsync(new TransporteDetalleView(selectedHotel));

            ((CollectionView)sender).SelectedItem = null;
        }
    }
}