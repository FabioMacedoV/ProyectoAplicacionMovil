using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using AplicacionMovilHotel.AppHoleteria.Views;

namespace AplicacionMovilHotel
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<FileImageSource> imageSources = new ObservableCollection<FileImageSource>();
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            imageSources.Add("arequipa.png");
            imageSources.Add("ica.png");
            imageSources.Add("huancayo.png");
            imageSources.Add("tumbes.png");

            imgSider.Images = imageSources;
            imgSider1.Images = imageSources;
            imgSider2.Images = imageSources;
            imgSider3.Images = imageSources;
        }

        private async void nfPaginaBuscar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SearchView());
        }
    }
}
