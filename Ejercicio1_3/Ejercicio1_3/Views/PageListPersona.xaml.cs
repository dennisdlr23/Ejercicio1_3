using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio1_3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageListPersona : ContentPage
    {
        public PageListPersona()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listpersona.ItemsSource = await App.DataBasePer.ListaPersonas();
        }

        private async void listpersona_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Models.Personas perso = (Models.Personas)e.CurrentSelection.FirstOrDefault();

            MainPage pag = new MainPage();
            pag.BindingContext = perso;
            await Navigation.PushModalAsync(pag);
        }

        private async void tooladd_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }

      
    }
}