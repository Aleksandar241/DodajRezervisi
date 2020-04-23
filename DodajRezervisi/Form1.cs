using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DodajRezervisi
{
    public partial class Form1 : Form
    {
        public static string menIme;
        public static string menPrezime;
        public static string menKontakt;
        public static string objNaziv;
        public static string adresa;
        public static int brMesta;
        public static bool hrana;
        public static bool pet;
        public static long jmbg;
        public static string vrsta = "nepoznato";
        public int brKafica = 1;

        Kafic k;
        Musterija m;
        List<Kafic> kafici = new List<Kafic>()
            {
                {new Kafic("Bum Bum","Vlade Zecevica 12",25,true,true,"Marko","Markovic","066-222-333","kafic") },

        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gbRezerva.Hide();
            dataGridView1.Hide();
        }

        private void btZavrsi_Click(object sender, EventArgs e)
        {
            menIme = txtIme.Text;
            menPrezime = txtPrezime.Text;
            menKontakt = txtKontakt.Text;
            objNaziv = txtNaziv.Text;
            adresa = txtAdresa.Text;
            string mesto = txtMesta.Text;

            if (Provera(mesto) == false)
            {

                MessageBox.Show("Morate uneti broj u polje <Broj mesta>");

                if (menIme == "" || menPrezime == "" || menKontakt == "" || objNaziv == "" || adresa == "")
                {
                    MessageBox.Show("Morate popuniti sva polja.");
                }
            }
            else
            {
                brMesta = Convert.ToInt32(mesto);
                k = new Kafic(objNaziv, adresa, brMesta, hrana, pet, menIme, menPrezime, menKontakt, vrsta);
                kafici.Add(k);
                IspisL();

                dataGridView1.Show();


                Cek();
            }
        }
        private void IspisL()
        {
            foreach (var x in kafici)
            {
                int n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells[0].Value = x.Lista(0);
                dataGridView1.Rows[n].Cells[1].Value = x.Lista(1);
                dataGridView1.Rows[n].Cells[2].Value = x.Lista(2);
                dataGridView1.Rows[n].Cells[3].Value = x.Lista(3);
                dataGridView1.Rows[n].Cells[4].Value = x.Lista(4);
                dataGridView1.Rows[n].Cells[5].Value = x.Lista(5);
                dataGridView1.Rows[n].Cells[6].Value = x.Lista(6);
            }
        }
        private async void Cek()
        {
            await Task.Delay(1000);
            gbRezerva.Show();
            foreach (var x in kafici)
                cbIzbor.Items.Add(x.Lista(0));
        }

        private void cbHrana_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHrana.Checked)
            {
                hrana = true;

            }
            else
            {
                hrana = false;
            }
        }

        private void cbPet_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPet.Checked)
            {
                pet = true;
            }
            else
            {
                pet = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = comboBox1.SelectedIndex;

            switch (a)
            {
                case 0:
                    vrsta = "nepoznato";
                    break;
                case 1:
                    vrsta = "kafana";
                    break;
                case 2:
                    vrsta = "kafic";
                    break;
                case 3:
                    vrsta = "diskoteka";
                    break;
                case 4:
                    vrsta = "restoran";
                    break;
            }
        }
        public void Boja(int a)
        {
            dataGridView1.Rows[a].Cells[5].Style.BackColor = Color.Red;
        }
        private static bool Provera(string a)
        {
            int b;

            if (Int32.TryParse(a, out b))
                return true;
            else
                return false;


        }
        private static bool Provera2(int a)
        {
            if (a < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void bR_Click(object sender, EventArgs e)
        {
            menIme = tMime.Text;
            menPrezime = tMpre.Text;
            menKontakt = tMkont.Text;
            string jmb = tJMBG.Text;
            int a = cbIzbor.SelectedIndex;
            bool c = Provera2(a);

            if (Provera(jmb) == false)
            {
                MessageBox.Show("Morate uneti broj u polje <JMBG>");

                if (menIme == "" || menPrezime == "" || menKontakt == "")
                {
                    MessageBox.Show("Morate popuniti sva polja i odabrati objekat.");

                }
            }
            else if (c)
            {
                jmbg = Convert.ToInt32(jmb);
                m = new Musterija(menIme, menPrezime, menKontakt, jmbg);


                m.Rezervisi(kafici[a]);
                if (m.rezervacija)
                {
                    MessageBox.Show("Uspeno ste rezervisali sto." + m.Pismo() + kafici[a].Ispis());
                    dataGridView1.Rows.Clear();
                    IspisL();
                    Boja(a);
                    dataGridView1.Show();

                }
                else
                {
                    MessageBox.Show("Sva mesta su popunjena.");

                }

            }
            else
                MessageBox.Show("Morate izabrati objekat");
        }
    }
}
