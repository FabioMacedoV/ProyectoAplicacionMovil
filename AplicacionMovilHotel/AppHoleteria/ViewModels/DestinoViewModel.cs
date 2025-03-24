using AplicacionMovilHotel.AppHoleteria.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using static Android.Resource;
using System.Linq;

namespace AplicacionMovilHotel.AppHoleteria.ViewModels
{
    public class DestinoViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<DestinoModel> Destinos { get; set; }
        public ObservableCollection<DestinoModel> DestinosFiltrados { get; set; }

        public DestinoViewModel()
        {
            Destinos = new ObservableCollection<DestinoModel>
            {
                new DestinoModel
            {
                id = 1,
                nombre = "Machu Picchu",
                imagen = "machupichu.jpg",
                descripcion = "Antigua ciudad inca en la cima de una montaña.",
                recomendaciones = "Llevar ropa cómoda, protector solar y cámara.",
                Hoteles = new ObservableCollection<HotelModel>
                {
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
                },
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
                },
            },
            new DestinoModel
            {
                id = 2,
                nombre = "Lago Titicaca",
                imagen = "lagotiticaca.jpg",
                descripcion = "El lago navegable más alto del mundo.",
                recomendaciones = "Visitar las islas flotantes de los Uros y Taquile.",
                Hoteles = new ObservableCollection<HotelModel>
                {
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
                },
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
                },
            },
            new DestinoModel
            {
                id = 3,
                nombre = "Líneas de Nazca",
                imagen = "nazca.jpg",
                descripcion = "Geoglifos antiguos en el desierto de Nazca.",
                recomendaciones = "Tomar un vuelo para apreciarlas desde el aire.",
                Hoteles = new ObservableCollection<HotelModel>
                {
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
                },
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
                },
            }
            };

            DestinosFiltrados = new ObservableCollection<DestinoModel>(Destinos);
        }

        public void BuscarDestino(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                DestinosFiltrados = new ObservableCollection<DestinoModel>(Destinos);
            }
            else
            {
                var resultado = Destinos.Where(d => d.nombre.ToLower().Contains(texto.ToLower())).ToList();
                DestinosFiltrados = new ObservableCollection<DestinoModel>(resultado);
            }

            OnPropertyChanged(nameof(DestinosFiltrados));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

}
