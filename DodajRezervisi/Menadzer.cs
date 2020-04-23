using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DodajRezervisi
{
    class Menadzer : Temp
    {

        public Menadzer()
        {
            Ime = "Nedefinisano";
            Prezime = "Nedefinisano";
            mKontakt = "Nedefinisano";

        }
        public Menadzer(string mIme, string mPrezime, string mKontakt)
        {
            this.Ime = mIme;
            this.Prezime = mPrezime;
            this.mKontakt = mKontakt;

        }
        public override string ToString()
        {
            return "\n" + Ime + " " + Prezime + "\n" + mKontakt;
        }

    }
}
