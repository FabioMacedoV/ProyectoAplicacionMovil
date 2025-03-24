using AplicacionMovilHotel.AppHoleteria.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AplicacionMovilHotel.AppHoleteria.Models
{
    public class DestinoModel
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string imagen {  get; set; }
        public string descripcion {  get; set; }
        public string recomendaciones {  get; set; }
        public ObservableCollection<HotelModel> Hoteles { get; set; }
        public ObservableCollection<RestauranteModel> Restaurantes { get; set; }
        public ObservableCollection<TransporteModel> Transportes { get; set; }
    }
}
