using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        int id;
        private DateTime datumNarudzbe;
        static int redniBrojNarudzbe = 0;
        private List<Sadnica> sadnice;


        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public DateTime DatumNarudzbe
        {
            get
            {
                return datumNarudzbe;
            }

            set
            {
                datumNarudzbe = value;
            }
        }

        public static int RedniBrojNarudzbe
        {
            get
            {
                return redniBrojNarudzbe;
            }

            set
            {
                redniBrojNarudzbe = value;
            }
        }

        public List<Sadnica> Sadnice
        {
            get
            {
                return sadnice;
            }

            set
            {
                sadnice = value;
            }
        }

        public Narudzba(DateTime datumNarudzbe, List<Sadnica> izabraneSadnice)
        {
            this.DatumNarudzbe = datumNarudzbe;
            RedniBrojNarudzbe = RedniBrojNarudzbe + 1;
            this.Sadnice = izabraneSadnice;

        }
        public static int sljedeciBrojNaudzbe()
        {
            return RedniBrojNarudzbe + 1;
        }

        public void dodajIzabarnuSadnicu(Sadnica sadnica)
        {
            Sadnice.Add(sadnica);
        }
        public bool validirajNarudzbu()
        {
            if (this.sadnice.prodato - sadnice.kolicina < 0)
                return false;
            else
                return true;
        }
        public bool rezervirajNarudzbu()
        {
            this.sadnice.Prodato = this.sadnice.Prodato - this.Kolicina;

            this.sadnice.prodato = this.sadnice.prodato - this.Kolicina;
        }


    }
}