using System.Runtime.CompilerServices;

namespace Troškovnik_prijevoza
{
    public partial class Form1 : Form
    {

        public List<Zaposlenik> zaposlenikList = new List<Zaposlenik>();
        public double BrojDanaUkupni;

        public Form1()
        {

            InitializeComponent();

            zaposlenikList.Add(new Zaposlenik() { Ime = "Mario", Prezime = "Knez", Mjesto = "Ogulin", Udaljenost = 80 });
            zaposlenikList.Add(new Zaposlenik() { Ime = "Ivan", Prezime = "Jurić", Mjesto = "Zagreb", Udaljenost = 180 });
            zaposlenikList.Add(new Zaposlenik() { Ime = "Tomislav", Prezime = "Mihić", Mjesto = "Osijek", Udaljenost = 94 });
            zaposlenikList.Add(new Zaposlenik() { Ime = "Valentin", Prezime = "Mihić", Mjesto = "Županja", Udaljenost = 51 });
            zaposlenikList.Add(new Zaposlenik() { Ime = "Danijela", Prezime = "Herceg", Mjesto = "Selna", Udaljenost = 20 });
            zaposlenikList.Add(new Zaposlenik() { Ime = "Ivona", Prezime = "Mraz", Mjesto = "Požega", Udaljenost = 45 });

            cBx_Zaposlenik.DataSource = zaposlenikList;
            cBx_Zaposlenik.DisplayMember = "Prezime";

        }



        private void Form1_Load(object sender, EventArgs e)
        {
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Full_Name(object sender, ListControlConvertEventArgs e)
        {
            string ime = (e.ListItem as Zaposlenik).Ime;
            string prezime = (e.ListItem as Zaposlenik).Prezime;
            e.Value = ime + " " + prezime;
        }

        private void mC_Kalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime DanPocetni = new DateTime();
            DateTime DanZavrsni = new DateTime();
            DanPocetni = mC_Kalendar.SelectionStart;
            DanZavrsni = mC_Kalendar.SelectionEnd;

            TimeSpan dani = DanZavrsni - DanPocetni;
            double ukupnoDana = dani.TotalDays;
            BrojDanaUkupni += ukupnoDana;
            txb_Troskovnik.Text = "Ukupan broj dana je: " + Math.Round(BrojDanaUkupni).ToString() + Environment.NewLine;
        }

        private void cBx_Zaposlenik_SelectedIndexChanged(object sender, EventArgs e)
        {

            foreach (var item in zaposlenikList)
            {

                string a = item.Ime + " " + item.Prezime;

                if (a == cBx_Zaposlenik.Text)
                {

                    txb_Udaljenost.Text = item.Udaljenost.ToString();

                }


            }

        }

        private void Izracunaj_Click(object sender, EventArgs e)
        {

            foreach ( var item in zaposlenikList)
            {

                double ukupno = Math.Round(BrojDanaUkupni) * 2 * item.Udaljenost;
                txb_Troskovnik.Text = "Udaljenost u jednom smjeru je: " + item.Udaljenost.ToString() + Environment.NewLine;
                txb_Troskovnik.Text += "Cijena po 1km je: " + Environment.NewLine;
                txb_Troskovnik.Text += "Ukupna isplata: " + ukupno;

            }

        }
    }
}