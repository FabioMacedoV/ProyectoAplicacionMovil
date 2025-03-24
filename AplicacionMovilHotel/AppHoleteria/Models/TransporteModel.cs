using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionMovilHotel.AppHoleteria.Models
{
    public class TransporteModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Empresa { get; set; } 
        public string Origen { get; set; } 
        public string Destino { get; set; }
        public decimal Precio { get; set; } 
        public string HorarioSalida { get; set; } 
        public string HorarioLlegada { get; set; }
        public int Capacidad { get; set; } 
        public bool Disponible { get; set; } 
        public string ImagenUrl { get; set; } 
    }
}
