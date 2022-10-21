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
    public partial class PageTwo : ContentPage
    {
        public PageTwo()
        {
            InitializeComponent();
        }
        public PageTwo(String nombre, String apellido, String edad, String correo)
        {
            InitializeComponent();

            lblresultado.Text = nombre + " " + apellido + " " + edad + " " + correo;

        }
    }
}