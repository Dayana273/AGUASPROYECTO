using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AGUASPROYECTO.CLIENTES
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClientePage : ContentPage
    {
        public ClientePage()
        {
            InitializeComponent();
        }

        private void btguardar_Clicked(object sender, EventArgs e)
        {


            {
                if (Codigo == null)
                {
                    DisplayAlert("Error", "No has ingresado el codigo", "ok");
                }
                else if (string.IsNullOrEmpty(Codigo.Text))
                {
                    DisplayAlert("Error", "Error  no has ingresado el nombre", "ok");

                }

                else if (string.IsNullOrEmpty(NombreC.Text))
                {
                    DisplayAlert("Error", "Error no has ingresado el nombre", "ok");
                }

                else if (string.IsNullOrEmpty(Pais.Text))
                {
                    DisplayAlert("Error", "Error no has ingresado el pais y departamento", "ok");
                }

                else if (string.IsNullOrEmpty(txtMunicipio.Text))
                {
                    DisplayAlert("Error", "Error no has ingresado la residencia", "ok");
                }

            }

        }

        private void btnbuscar_Clicked(object sender, EventArgs e)
        {

        }
    }
}

