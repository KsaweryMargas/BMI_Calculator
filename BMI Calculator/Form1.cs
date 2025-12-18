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
            tabelaBMI.ColumnCount = 2;
            tabelaBMI.Columns[0].Name = "BMI";
            tabelaBMI.Columns[1].Name = "Kategoria";
            tabelaBMI.Rows.Add("< 14", "Szczurek");
            tabelaBMI.Rows.Add("14 – 16.9", "Wychudzenie");
            tabelaBMI.Rows.Add("17 – 19.9", "Niedowaga");
            tabelaBMI.Rows.Add("20 – 24.9", "Pożądana masa ciała");
            tabelaBMI.Rows.Add("25 – 29.9", "Nadwaga");
            tabelaBMI.Rows.Add("30 – 34.9", "Otyłość I stopnia");
            tabelaBMI.Rows.Add("35 – 39.9", "Otyłość II stopnia");
            tabelaBMI.Rows.Add("≥ 40", "Michal Jaśkiewicz");
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
            string opis = "";

            if (bmi < 14)
            {
                kategoria = "Szczurek";
                opis = "Twoja masa ciała jest bardzo niska, Może to prowadzić do poważnych problemów zdrowotnych," +
                       "Zalecana jest pilna konsultacja z lekarzem. Twój organizm potrzebuje więcej energii," +
                       "aby prawidłowo funkcjonować. Staraj się jeść regularnie i odżywczo. Pamiętaj też o odpoczynku i unikaniu stresu.";
            }
            else if (bmi < 17)
            {
                kategoria = "Wychudzenie";
                opis = "Twoja masa ciała jest znacznie poniżej normy, Może to powodować osłabienie organizmu," +
                       "Warto skonsultować się z dietetykiem. Spróbuj wprowadzić zdrowe przekąski między posiłkami." +
                       "Pij dużo wody i unikaj słodkich napojów. Zadbaj o lekką aktywność, jak spacer lub stretching.";
            }
            else if (bmi < 20)
            {
                kategoria = "Niedowaga";
                opis = "Twoja masa ciała jest poniżej zalecanej normy, Może to wpływać na odporność i energię, " +
                      "Zaleca się zwiększenie wartości odżywczej posiłków. Dodaj więcej białka i warzyw do diety." +
                      "Jedz regularnie, nie pomijaj śniadań. Staraj się wysypiać i dbać o równowagę w życiu.";
            }
            else if (bmi < 25)
            {
                kategoria = "Pożądana masa ciała";
                opis = "Twoja masa ciała mieści się w normie, Oznacza to prawidłowe proporcje wagi do wzrostu, " +
                       "Utrzymuj zdrową dietę i aktywność fizyczną. Kontynuuj dbanie o regularne posiłki." +
                       "Pamiętaj o ruchu każdego dnia. Ciesz się dobrym samopoczuciem i zdrowiem.";
            }
            else if (bmi < 30)
            {
                kategoria = "Nadwaga";
                opis = "Twoja masa ciała jest powyżej normy, Może to zwiększać ryzyko chorób," +
                       "Zalecana jest większa aktywność fizyczna. Staraj się chodzić na spacery lub ćwiczyć 2-3 razy w tygodniu." +
                       "Ogranicz słodycze i tłuste jedzenie. Dbaj o regularne posiłki i nawodnienie.";
            }
            else if (bmi < 35)
            {
                kategoria = "Otyłość I stopnia";
                opis = "Występuje otyłość pierwszego stopnia, Może negatywnie wpływać na zdrowie," +
                       "Warto skonsultować się ze specjalistą. Spróbuj wprowadzić więcej warzyw i owoców do codziennej diety. " +
                       "Unikaj podjadania między posiłkami. Pamiętaj o regularnej aktywności fizycznej, nawet lekkiej.";
            }
            else if (bmi < 40)
            {
                kategoria = "Otyłość II stopnia";
                opis = "Jest to zaawansowana otyłość, Zwiększa ryzyko chorób przewlekłych, Konieczna jest zmiana stylu życia." +
                       "Staraj się planować posiłki z pomocą dietetyka. Znajdź formę ruchu, którą polubisz. Dbaj o swoje zdrowie krok po kroku, bez pośpiechu.";
            }
            else
            {
                kategoria = "Michal Jaśkiewicz";
                opis = "Jest to skrajna otyłość, stanowi poważne zagrożenie dla zdrowia, " +
                       "Zalecane jest leczenie pod kontrolą lekarza. Ważne jest, aby uzyskać wsparcie medyczne i psychologiczne. " +
                       "Małe kroki w diecie i ruchu mogą dać duże efekty. Nie poddawaj się, Twoje zdrowie jest najważniejsze.";
            }

            wynikKategoria.Text = kategoria;
            opisKategorii.Text = opis;
        }
    }
}
