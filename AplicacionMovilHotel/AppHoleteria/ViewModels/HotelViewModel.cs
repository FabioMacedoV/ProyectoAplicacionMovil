using AplicacionMovilHotel.AppHoleteria.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace AplicacionMovilHotel.AppHoleteria.ViewModels
{
    public class HotelViewModel : INotifyPropertyChanged
    {

        public ObservableCollection<HotelModel> Hoteles { get; set; }

        public HotelViewModel(int destinoId)
        {
            Hoteles = new ObservableCollection<HotelModel> {
                new HotelModel()
                {
                    Id = 1,
                    HotelId = 1,
                    Nombre = "Inkaterra Machu Picchu Pueblo Hotel",
                    Direccion = "Camino del Inca, Aguas Calientes, Perú",
                    Estrellas = 5,
                    Telefono = "+51 84 211234",
                    Correo = "reservas@inkaterra.com",
                    Descripcion = "Un hotel ecológico de lujo rodeado de naturaleza exuberante.",
                    ImagenUrl = "inkaterra.jpg",
                    Habitaciones = new List<HabitacionModel>
                    {
                        new HabitacionModel { Id = 1, Tipo = "Suite", Capacidad = 2, PrecioPorNoche = 350.00m, Disponible = true },
                        new HabitacionModel { Id = 2, Tipo = "Doble", Capacidad = 4, PrecioPorNoche = 250.00m, Disponible = true }
                    },
                    Servicios = new List<ServicioModel>
                    {
                        new ServicioModel { Id = 1, Nombre = "WiFi", Descripcion = "Internet de alta velocidad gratuito" },
                        new ServicioModel { Id = 2, Nombre = "Desayuno Incluido", Descripcion = "Buffet variado con productos locales" },
                        new ServicioModel { Id = 3, Nombre = "Spa", Descripcion = "Relájate con masajes y tratamientos exclusivos" }
                    }
                },
                new HotelModel()
                {
                    Id = 2,
                    HotelId = 1,
                    Nombre = "Sumaq Machu Picchu Hotel",
                    Direccion = "Av. Hermanos Ayar, Aguas Calientes, Perú",
                    Estrellas = 5,
                    Telefono = "+51 84 211068",
                    Correo = "info@sumaqhotelperu.com",
                    Descripcion = "Un hotel familiar con vista al río Vilcanota y gastronomía gourmet.",
                    ImagenUrl = "sumaq.jpg",
                    Habitaciones = new List<HabitacionModel>
                    {
                        new HabitacionModel { Id = 3, Tipo = "Matrimonial", Capacidad = 2, PrecioPorNoche = 320.00m, Disponible = true },
                        new HabitacionModel { Id = 4, Tipo = "Familiar", Capacidad = 4, PrecioPorNoche = 450.00m, Disponible = false }
                    },
                    Servicios = new List<ServicioModel>
                    {
                        new ServicioModel { Id = 4, Nombre = "Restaurante", Descripcion = "Cocina gourmet con ingredientes andinos" },
                        new ServicioModel { Id = 5, Nombre = "Traslado", Descripcion = "Servicio de transporte desde la estación de tren" },
                        new ServicioModel { Id = 6, Nombre = "Bar", Descripcion = "Variedad de cócteles y bebidas tradicionales" }
                    }
                },
                new HotelModel()
                {
                    Id = 3,
                    HotelId = 1,
                    Nombre = "Casa del Sol Machu Picchu",
                    Direccion = "Av. Imperio de los Incas, Aguas Calientes, Perú",
                    Estrellas = 4,
                    Telefono = "+51 84 211020",
                    Correo = "contacto@casadelsol.com",
                    Descripcion = "Un hotel boutique con impresionantes vistas a la montaña.",
                    ImagenUrl = "casadelsol.jpg",
                    Habitaciones = new List<HabitacionModel>
                    {
                        new HabitacionModel { Id = 5, Tipo = "Estándar", Capacidad = 2, PrecioPorNoche = 180.00m, Disponible = true },
                        new HabitacionModel { Id = 6, Tipo = "Deluxe", Capacidad = 3, PrecioPorNoche = 250.00m, Disponible = true }
                    },
                    Servicios = new List<ServicioModel>
                    {
                        new ServicioModel { Id = 7, Nombre = "Masajes", Descripcion = "Tratamientos relajantes y terapéuticos" },
                        new ServicioModel { Id = 8, Nombre = "Guía turístico", Descripcion = "Excursiones personalizadas a Machu Picchu" },
                        new ServicioModel { Id = 9, Nombre = "Servicio a la habitación", Descripcion = "Disponible las 24 horas" }
                    }
                }
            };

            OnPropertyChanged(nameof(Hoteles));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    }
}
