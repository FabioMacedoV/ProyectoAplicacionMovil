using AplicacionMovilHotel.AppHoleteria.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace AplicacionMovilHotel.AppHoleteria.ViewModels
{
    public class RestauranteViewModel : INotifyPropertyChanged
    {

        public ObservableCollection<RestauranteModel> Restaurantes { get; set; }

        public RestauranteViewModel(int destinoId)
        {
            Restaurantes = new ObservableCollection<RestauranteModel>
            {
                new RestauranteModel
                {
                    Id = 1,
                    Nombre = "Indio Feliz",
                    TipoComida = "Fusión Peruana-Francesa",
                    Ubicacion = "Calle Lloque Yupanqui 103, Machu Picchu Pueblo",
                    PrecioPromedio = 80.00m,
                    HorarioApertura = "12:00 PM",
                    HorarioCierre = "10:00 PM",
                    Capacidad = 50,
                    Disponible = true,
                    ImagenUrl = "indio_feliz.jpg",
                    Servicios = new List<string> { "WiFi", "Reservas", "Bar", "Vegetariano" },
                    MenuDestacado = new List<string> { "Trucha a la mantequilla", "Ceviche de trucha", "Pisco Sour" },
                    Calificacion = 4.8
                },
                new RestauranteModel
                {
                    Id = 2,
                    Nombre = "Tree House Restaurant",
                    TipoComida = "Gourmet Peruana",
                    Ubicacion = "Calle Huanacaure 105, Machu Picchu Pueblo",
                    PrecioPromedio = 100.00m,
                    HorarioApertura = "11:30 AM",
                    HorarioCierre = "9:30 PM",
                    Capacidad = 40,
                    Disponible = true,
                    ImagenUrl = "tree_house.jpg",
                    Servicios = new List<string> { "WiFi", "Reservas", "Vegano", "Vista panorámica" },
                    MenuDestacado = new List<string> { "Lomo saltado", "Ají de gallina", "Chicha morada" },
                    Calificacion = 4.7
                },
                new RestauranteModel
                {
                    Id = 3,
                    Nombre = "Toto's House",
                    TipoComida = "Peruana Tradicional",
                    Ubicacion = "Av. Imperio de los Incas 600, Machu Picchu Pueblo",
                    PrecioPromedio = 60.00m,
                    HorarioApertura = "7:00 AM",
                    HorarioCierre = "10:00 PM",
                    Capacidad = 80,
                    Disponible = true,
                    ImagenUrl = "totos_house.jpg",
                    Servicios = new List<string> { "WiFi", "Música en vivo", "Buffet", "Desayunos" },
                    MenuDestacado = new List<string> { "Cuy al horno", "Papa a la huancaína", "Chicha de jora" },
                    Calificacion = 4.5
                },
                new RestauranteModel
                {
                    Id = 4,
                    Nombre = "El Mapi Restaurant",
                    TipoComida = "Internacional",
                    Ubicacion = "Av. Pachacutec 109, Machu Picchu Pueblo",
                    PrecioPromedio = 120.00m,
                    HorarioApertura = "6:30 AM",
                    HorarioCierre = "10:00 PM",
                    Capacidad = 70,
                    Disponible = true,
                    ImagenUrl = "el_mapi.jpg",
                    Servicios = new List<string> { "WiFi", "Reservas", "Desayunos buffet", "Opciones sin gluten" },
                    MenuDestacado = new List<string> { "Sopa criolla", "Alpaca a la parrilla", "Tiramisú de quinoa" },
                    Calificacion = 4.9
                }
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));


    }
}
