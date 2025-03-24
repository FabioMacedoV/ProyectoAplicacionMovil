using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionMovilHotel.AppHoleteria.Models
{
    public class HotelModel
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Estrellas { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Descripcion { get; set; }
        public string ImagenUrl { get; set; }
        public List<HabitacionModel> Habitaciones { get; set; } 
        public List<ServicioModel> Servicios { get; set; }

    }

    public class HabitacionModel
    {
        public int Id { get; set; }
        public string Tipo { get; set; } 
        public int Capacidad { get; set; }
        public decimal PrecioPorNoche { get; set; }
        public bool Disponible { get; set; }
    }

    public class ServicioModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
