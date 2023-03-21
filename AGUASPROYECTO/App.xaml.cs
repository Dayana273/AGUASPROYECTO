using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AGUASPROYECTO
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new  NavigationPage(new CLIENTES.ClientePage());
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
