using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGreenhouse.Model
{
    class Narudzba
    {
        private DateTime datumNarudzbe;
        static int redniBrojNarudzbe = 0;

        public Narudzba(DateTime datumNarudzbe)
        {
            this.datumNarudzbe=datimNarudzbe;
            redniBrojNarudzbe = redniBrojNarudzbe + 1;

        }
        public static int sljedeciBrojNaudzbe();

        public void dodajIzabarnuSadnicu(Sadnica stavka){}
        public bool validirajNarudzbu(Sadnica stvka) {
            if (this.stavka.Prodato - this.stavka.Kolicina < 0)
                return false;
            else
                return true;
        }
        public bool rezervirajNarudzbu(Sadnica stavka)
        {
            this.stavka.Prodato = this.stavka.Prodato - this.Kolicina;
        }

       
    }
