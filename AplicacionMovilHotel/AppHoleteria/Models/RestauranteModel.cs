using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionMovilHotel.AppHoleteria.Models
{
    public class RestauranteModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string TipoComida { get; set; }
        public string Ubicacion { get; set; }
        public decimal PrecioPromedio { get; set; }
        public string HorarioApertura { get; set; }
        public string HorarioCierre { get; set; }
        public int Capacidad { get; set; }
        public bool Disponible { get; set; }
        public string ImagenUrl { get; set; }
        public List<string> Servicios { get; set; }
        public List<string> MenuDestacado { get; set; }
        public double Calificacion { get; set; }

        public RestauranteModel()
        {
            Servicios = new List<string>();
            MenuDestacado = new List<string>();
        }
    }
}
