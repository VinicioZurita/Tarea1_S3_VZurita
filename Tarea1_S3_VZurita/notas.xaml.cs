using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea1_S3_VZurita
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class notas : ContentPage
    {
        double suma1, suma2, NF;
        public notas()
        {
            InitializeComponent();
        }
        private void btnSumar_Clicked(object sender, EventArgs e)
        {

            try
            {//acciones del programa

                if (String.IsNullOrWhiteSpace(txtNotaS1.Text) || String.IsNullOrWhiteSpace(txtNotaE1.Text))
                {
                    DisplayAlert("Advertencia", "Los campos (*) son obligatorios.", "OK");
                }
                else
                {
                    double dato1 = Convert.ToDouble(txtNotaS1.Text);
                    double dato2 = Convert.ToDouble(txtNotaE1.Text);
                    suma1 = dato1 * 0.30 + dato2 * 0.20;
                    txtNP1.Text = suma1.ToString();
                    if (String.IsNullOrWhiteSpace(txtNotaS2.Text) || String.IsNullOrWhiteSpace(txtNotaE2.Text))
                    {
                        DisplayAlert("Advertencia", "Los campos (*) son obligatorios.", "OK");
                    }
                    else
                    {
                        double dato3 = Convert.ToDouble(txtNotaS2.Text);
                        double dato4 = Convert.ToDouble(txtNotaE2.Text);
                        suma2 = dato3 * 0.30 + dato4 * 0.20;
                        txtNP2.Text = suma2.ToString();
                        NF = suma1 + suma2;
                        txtNF.Text = NF.ToString();
                        if (NF >= 7)
                            Estado.Text = "APROBADO";
                        else
                            if (NF >= 5 && NF < 7)
                            Estado.Text = "COMPLEMENTARIO";
                        else
                            Estado.Text = "REPROBADO";
                    }
                }


            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "OK");
            }
        }
    }
}