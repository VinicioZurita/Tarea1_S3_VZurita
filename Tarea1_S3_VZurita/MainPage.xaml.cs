using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tarea1_S3_VZurita
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnIngresar_Clicked(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string clave = txtClave.Text;
            if (usuario == "estudiante2021" && clave== "uisrael2021") 
                await Navigation.PushAsync(new notas());
            else
                await DisplayAlert("Advertencia", "¡Usuario o clave incorrectas!", "OK");
        }
    }
}
