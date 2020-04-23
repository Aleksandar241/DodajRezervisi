using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DodajRezervisi
{
    abstract class Temp
    {
        protected string Naziv { get; set; }
        protected string Ime { get; set; }
        protected string Prezime { get; set; }
        protected string mKontakt { get; set; }

    }
    class Kafic : Temp
    {
        public int brKafica = 1;
        protected string adresa { get; set; }
        protected bool hrana { get; set; }
        protected bool pet { get; set; }
        protected Tip tip;
        protected Menadzer menadzer { get; set; }
        public int brStolova { get; set; }


        public Kafic()
        {
            Naziv = "Nedefinisano";
            adresa = "Nedefinisano";
            brStolova = 0;
            hrana = false;
            pet = false;
            menadzer = new Menadzer();
            tip = Tip.nepoznato;

        }

        public Kafic(string Naziv, string adresa, int brStolova, bool hrana, bool pet, string mIme, string mPrezime, string mKontakt, string tip)
        {
            this.Naziv = Naziv;
            this.adresa = adresa;
            this.brStolova = brStolova;
            this.hrana = hrana;
            this.pet = pet;
            this.menadzer = new Menadzer(mIme, mPrezime, mKontakt);
            this.tip = (Tip)Enum.Parse(typeof(Tip), tip);
        }

        public string Lista(int a)
        {
            string h = "";
            string p = "";
            if (hrana)

                h = "✓";

            else
                h = "x";

            if (pet)
                p = "✓";

            else
                p = "x";

            string[] s = new string[7];
            s[0] = this.Naziv;
            s[1] = this.adresa;
            s[2] = tip.ToString();
            s[3] = h;
            s[4] = p;
            s[5] = this.brStolova.ToString();
            s[6] = this.menadzer.ToString();
            return s[a];
        }

        public virtual string Ispis()
        {
            return "\n" + Naziv + "\nAdresa: " + adresa + " \nZa sve dodatne informacije obratite se nasem menadzeru:" +
               " " + menadzer.ToString();
        }
        public bool Reserved(Musterija obj)
        {
            if (this.brStolova > 0)
            {
                this.brStolova -= 1;
                return true;
            }
            else
                return false;
        }


        public enum Tip
        {
            nepoznato,
            kafana,
            kafic,
            diskoteka,
            restoran
        }
    }
}
