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
        private ObservableCollection<Sadnica> sadnice;

        public Narudzba(DateTime datumNarudzbe, ObservableCollection<Sadnica> izabraneSadnice)
        {
            this.datumNarudzbe=datimNarudzbe;
            redniBrojNarudzbe = redniBrojNarudzbe + 1;
            this.sadnice = izabraneSadnice;

        }
        public static int sljedeciBrojNaudzbe();

        public void dodajIzabarnuSadnicu(Sadnica sadnica){
            sadnice.Add(sadnica);
        }
        public bool validirajNarudzbu() {
            if (this.sadnice.Prodato - this.sadnice.Kolicina < 0)
                return false;
            else
                return true;
        }
        public bool rezervirajNarudzbu()
        {
            this.sadnice.Prodato = this.sadnice.Prodato - this.Kolicina;
        }

       
    }
