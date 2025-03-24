using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionMovilHotel.AppHoleteria.Models
{
    public class GuiaModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; } 
        public string Descripcion { get; set; }
        public string Ubicacion { get; set; } 
        public string Contacto { get; set; } 
        public string SitioWeb { get; set; } 
        public string RedesSociales { get; set; }
        public List<string> Servicios { get; set; } 
        public decimal PrecioPromedio { get; set; } 
        public string HorarioAtencion { get; set; }
        public double Calificacion { get; set; } 
        public bool Disponible { get; set; }
        public string ImagenUrl { get; set; } 

    }
}
