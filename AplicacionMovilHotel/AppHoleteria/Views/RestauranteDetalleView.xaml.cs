using AplicacionMovilHotel.AppHoleteria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AplicacionMovilHotel.AppHoleteria.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RestauranteDetalleView : ContentPage
    {
        public RestauranteDetalleView(RestauranteModel restaurante)
        {
            InitializeComponent();

            BindingContext = restaurante;
        }
    }
}