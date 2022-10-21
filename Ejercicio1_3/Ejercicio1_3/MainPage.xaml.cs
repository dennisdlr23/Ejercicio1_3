using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio1_3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnmostrar_Clicked(object sender, EventArgs e)
        {
            var persona = new Models.Personas
            {
                id = Convert.ToInt32(txtid.Text),
                Nombres = txtnombre.Text,
                Apellidos = txtapellido.Text,
                Edad = Convert.ToInt32(txtedad.Text),
                Correo = txtcorreo.Text,
                Direccion = txtdireccion.Text
            };
            var result = await App.DataBasePer.StorePersonas(persona);
            limpiar();

            if (result > 0)
                await DisplayAlert("Persona Ingresada", "Correcto", "Ok"); 
            else
                await DisplayAlert("Error", "No Ingresado", "Ok");
        }

        private async void btneliminar_Clicked(object sender, EventArgs e)
        {
            var persona = new Models.Personas
            {
                id = Convert.ToInt32(txtid.Text)
            };
            var result = await App.DataBasePer.DeletePersonas(persona);
            await DisplayAlert("Confirmación", "Registro eliminado correctamente", "OK");
            limpiar();
        }
        public void limpiar()
        {
            txtid.Text = " ";
            txtnombre.Text = " ";
            txtapellido.Text = " ";
            txtedad.Text = " ";
            txtcorreo.Text = " ";
            txtdireccion.Text = " ";  
        }
    
    }
}
