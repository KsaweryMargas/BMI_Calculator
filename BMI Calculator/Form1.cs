using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BMI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void oblicz_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(wpiszheight.Text, out double height) ||
                !double.TryParse(wpiszweight.Text, out double weight) ||
                !double.TryParse(wpiszwiek.Text, out double wiek))
            {
                MessageBox.Show("Wpisz poprawne liczby!");
                return;
            }

            double bmi = weight / Math.Pow(height / 100.0, 2);
            bmi = Math.Round(bmi, 2);
            wynikBMI.Text = bmi.ToString();

            string kategoria = "";

            if (bmi < 14)
            {
                kategoria = "Szczurek";
            }
            else if (bmi < 17)
            {
                kategoria = "Wychudzenie";
            }
            else if (bmi < 20)
            {
                kategoria = "Niedowaga";
            }
            else if (bmi < 25)
            {
                kategoria = "Pożądana masa ciała";
            }
            else if (bmi < 30)
            {
                kategoria = "Nadwaga";
            }
            else if (bmi < 35)
            {
                kategoria = "Otyłość I stopnia";
            }
            else if (bmi < 40)
            {
                kategoria = "Otyłość II stopnia";
            }
            else
            {
                kategoria = "Michal Jaśkiewicz";
            }

            wynikKategoria.Text = kategoria;
        }
    }
}
