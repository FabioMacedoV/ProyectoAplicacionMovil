using AplicacionMovilHotel.AppHoleteria.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace AplicacionMovilHotel.AppHoleteria.ViewModels
{
    public class TransporteViewModel : INotifyPropertyChanged
    {

        public ObservableCollection<TransporteModel> Transportes { get; set; }

        public TransporteViewModel(int destinoId)
        {
            Transportes = new ObservableCollection<TransporteModel>
            {
                new TransporteModel
                {
                    Id = 1,
                    Nombre = "Expreso Inca Rail",
                    Tipo = "Tren",
                    Empresa = "Inca Rail",
                    Origen = "Cusco",
                    Destino = "Machu Picchu",
                    Precio = 150.00m,
                    HorarioSalida = "06:00 AM",
                    HorarioLlegada = "09:00 AM",
                    Capacidad = 200,
                    Disponible = true,
                    ImagenUrl = "inca_rail.jpg"
                },
                new TransporteModel
                {
                    Id = 2,
                    Nombre = "PeruRail Vistadome",
                    Tipo = "Tren",
                    Empresa = "PeruRail",
                    Origen = "Ollantaytambo",
                    Destino = "Machu Picchu",
                    Precio = 120.00m,
                    HorarioSalida = "07:20 AM",
                    HorarioLlegada = "09:50 AM",
                    Capacidad = 180,
                    Disponible = true,
                    ImagenUrl = "perurail_vistadome.jpg"
                },
                new TransporteModel
                {
                    Id = 3,
                    Nombre = "Bus Hidroeléctrica",
                    Tipo = "Bus",
                    Empresa = "Transporte Machu Picchu",
                    Origen = "Hidroeléctrica",
                    Destino = "Machu Picchu Pueblo",
                    Precio = 10.00m,
                    HorarioSalida = "02:00 PM",
                    HorarioLlegada = "03:30 PM",
                    Capacidad = 50,
                    Disponible = true,
                    ImagenUrl = "bus_hidroelectrica.jpg"
                },
                new TransporteModel
                {
                    Id = 4,
                    Nombre = "Caminata desde Hidroeléctrica",
                    Tipo = "Caminata",
                    Empresa = "Independiente",
                    Origen = "Hidroeléctrica",
                    Destino = "Machu Picchu Pueblo",
                    Precio = 0.00m,
                    HorarioSalida = "Libre",
                    HorarioLlegada = "4 horas aprox.",
                    Capacidad = 100,
                    Disponible = true,
                    ImagenUrl = "camino_hidroelectrica.jpg"
                }
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    }
}
