using AplicacionMovilHotel.AppHoleteria.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace AplicacionMovilHotel.AppHoleteria.ViewModels
{
    public class GuiaViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<GuiaModel> Turismo { get; set; }

        public GuiaViewModel(int destinoId)
        {
            Turismo = new ObservableCollection<GuiaModel> 
            {
                new GuiaModel
                {
                    Id = 1,
                    Nombre = "Machu Picchu Adventure",
                    Descripcion = "Especialistas en tours guiados y expediciones a Machu Picchu.",
                    Ubicacion = "Cusco, Perú",
                    Contacto = "+51 987 654 321",
                    SitioWeb = "https://machupicchuadventure.com",
                    RedesSociales = "Facebook, Instagram, Twitter",
                    Servicios = new List<string> { "Tours guiados", "Paquetes todo incluido", "Trekking a la montaña Huayna Picchu" },
                    PrecioPromedio = 250.00m,
                    HorarioAtencion = "Lunes a Domingo 7:00 AM - 8:00 PM",
                    Calificacion = 4.8,
                    Disponible = true,
                    ImagenUrl = "https://example.com/machupicchu_adventure.jpg"
                },
                new GuiaModel
                {
                    Id = 2,
                    Nombre = "Inka Travel Tours",
                    Descripcion = "Viajes personalizados con guías expertos en la historia inca.",
                    Ubicacion = "Aguas Calientes, Perú",
                    Contacto = "+51 976 543 210",
                    SitioWeb = "https://inkatraveltours.com",
                    RedesSociales = "Instagram, WhatsApp",
                    Servicios = new List<string> { "Tours privados", "Excursiones en grupo", "Visitas arqueológicas" },
                    PrecioPromedio = 180.00m,
                    HorarioAtencion = "Lunes a Viernes 8:00 AM - 6:00 PM",
                    Calificacion = 4.5,
                    Disponible = true,
                    ImagenUrl = "https://example.com/inka_travel_tours.jpg"
                },
                new GuiaModel
                {
                    Id = 3,
                    Nombre = "Cusco Explorer",
                    Descripcion = "Explora Machu Picchu con nuestros paquetes exclusivos.",
                    Ubicacion = "Cusco, Perú",
                    Contacto = "+51 912 345 678",
                    SitioWeb = "https://cuscoexplorer.com",
                    RedesSociales = "Facebook, YouTube",
                    Servicios = new List<string> { "Tours en tren", "Caminatas por el Camino Inca", "Aventura extrema" },
                    PrecioPromedio = 300.00m,
                    HorarioAtencion = "Lunes a Sábado 9:00 AM - 7:00 PM",
                    Calificacion = 4.7,
                    Disponible = true,
                    ImagenUrl = "https://example.com/cusco_explorer.jpg"
                }
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
