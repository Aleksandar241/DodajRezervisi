using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DodajRezervisi
{
    class Musterija : Temp
    {
        private long jmbg;
        public bool rezervacija { get; set; }
        public Musterija()
        {
            Ime = "Nedefinisano";
            Prezime = "Nedefinisano";
            mKontakt = "Nedefinisano";
            jmbg = 0;
        }
        public Musterija(string Ime, string Prezime, string mKontakt, long jmbg)
        {
            this.Ime = Ime;
            this.Prezime = Prezime;
            this.mKontakt = mKontakt;
            this.jmbg = jmbg;
        }

        public void Rezervisi(Kafic obj)
        {
            if (obj.Reserved(this) == true)
                rezervacija = true;
            else rezervacija = false;
        }
        public string Pismo()
        {
            return "\nVasa rezervacija: " + "\nIme: " + Ime + " " + Prezime + "\nJMBG: " + jmbg;
        }
    }
}
