using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeInShape
{
    public partial class UI : Form
    {
        //konstruktor
        private BMI_AF bmiaf;
        private Dieta dieta;
        //prywatne zmienne do przechowywania wartosci
        private double wyliczoneBMI;
        private double wyliczoneAF;
        private string ktoraDieta;

        public UI() 
        {
            InitializeComponent();
            bmiaf = new BMI_AF();
            dieta = new Dieta(bmiaf);
            //dodawanie nowego obserwatora (musi jakis byc, aby dane się aktualizowaly)
            bmiaf.dodajDiete(dieta);
        }

        private void ustawWartoscBMI()
        {           
            String waga = Waga_TB.Text;
            String wzrost = Wzrost_TB.Text;

            if (!String.IsNullOrEmpty(waga) && !String.IsNullOrEmpty(wzrost))
            {
                wyliczoneBMI = bmiaf.wyliczBMI(Convert.ToDouble(waga), Convert.ToDouble(wzrost));
                Wartosc_BMI.Text = Convert.ToString(Math.Round(wyliczoneBMI,2));
                wyliczoneBMI = bmiaf.pobierzBMI();
                ktoraDieta = bmiaf.powiadomDiety();

                if(Akt_fizyczna_CB.SelectedIndex < 0 || Waga_TB.TextLength < 1 || Wzrost_TB.TextLength < 1)
                {
                    Dieta_RTB.Text = "Wprowadz parametry";
                }
                else
                {
                    Dieta_RTB.Text = "Twoja dieta" + Environment.NewLine + "___________________________________" + ktoraDieta.ToString();
                    
                }
            }
        }

        private void Waga_TB_TextChanged(object sender, EventArgs e)
        {
            ustawWartoscBMI();
        }

        private void Wzrost_TB_TextChanged(object sender, EventArgs e)
        {
            ustawWartoscBMI();
        }

        

        private void Akt_fizyczna_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            wyliczoneAF = bmiaf.wyliczAF(Akt_fizyczna_CB.SelectedIndex);
            wyliczoneAF = bmiaf.pobierzAF();
            ktoraDieta = bmiaf.powiadomDiety();

            if (Waga_TB.TextLength > 0 && Wzrost_TB.TextLength > 0)
            {
                Dieta_RTB.Text = "Twoja dieta:" + Environment.NewLine + "___________________________________" + ktoraDieta.ToString();
            }
            else
            {
                Dieta_RTB.Text = "Wybierz parametry dotyczące BMI"; 
            }
        }
    }
}
