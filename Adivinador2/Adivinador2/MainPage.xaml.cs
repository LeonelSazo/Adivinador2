using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Adivinador2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Czar_Clicked(object sender, EventArgs e)
        {
            eti1.Text = "Piensa en el día que naciste y multiplicalo por 20";
            Czar.Text = " ";
            but1.Text = "Siguiente";
        }

        private void but1_Clicked(object sender, EventArgs e)
        {
            eti2.Text = "Muy bien, a ese resultado sumale 73";
            but2.Text = "Siguiente";
        }

        private void but2_Clicked(object sender, EventArgs e)
        {
            eti3.Text = "Ahora esa nueva cantidad multiplicala por 5";
            but3.Text = "Siguiente";
        }

        private void but3_Clicked(object sender, EventArgs e)
        {
            eti4.Text = "Y por ultimo a ese resultado súmale tu mes de cumpleaños";
            but4.Text = "Siguiente";
        }

        private void but4_Clicked(object sender, EventArgs e)
        {
            eti5.Text = "Ahora dime el resultado";
            Calcular.Text = "Adivinar fecha";
        }

        private void Calcular_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Result.Text))
            {
                var cant = int.Parse(Result.Text);
                var rest = cant - 365;
                var resultd = rest.ToString();
                ren.Text = "Reiniciar";
                if (rest > 1000)
                {
                    string dia = resultd.Substring(0, 2);
                    string mes = resultd.Substring(2, 2);
                    DisplayAlert("Tu fecha de cumpleaños es: ", $"{dia}/{mes}", "Continuar");
                }
                else
                {
                    string dia = resultd.Substring(0, 1);
                    string mes = resultd.Substring(1, 2);
                    DisplayAlert("Tu fecha de cumpleaños es: ", $"0{dia}/{mes}", "Continuar");
                }
            }
            else
            {
                DisplayAlert("Sin datos", "Llena el campo solicitado", "Continuar");
            }

        }

        private void ren_Clicked(object sender, EventArgs e)
        {
            eti1.Text = "";
            Czar.Text = "Empecemos";
            but1.Text = "";
            eti2.Text = "";
            but2.Text = "";
            eti3.Text = "";
            but3.Text = "";
            eti4.Text = "";
            but4.Text = "";
            eti5.Text = "";
            Calcular.Text = "";
            ren.Text = "";
            Result.Text = "";
        }
    }
}
