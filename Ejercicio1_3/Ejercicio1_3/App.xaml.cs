using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio1_3
{
    public partial class App : Application
    {
        static Controllers.PersonasController databasePersona;
        public static Controllers.PersonasController DataBasePer
        {

            get
            {
                if (databasePersona == null)
                {
                    databasePersona =
                    new Controllers.PersonasController(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Perso.db3"));
                }
                return databasePersona;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            MainPage = new NavigationPage(new Views.PageListPersona());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
