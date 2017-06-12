using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGreenhouse.Model
{
    public class Sadnica 

    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        int id;
        private float cijena;
        private int kolicina;
        private string naziv;
        private int pozicija;
        private int prodato;

        public Sadnica(float cijena, int kolicina,string naziv,int pozicija)
        {
            this.pozicija = pozicija;
            this.naziv = naziv;
            this.cijena = cijena;
            this.kolicina = kolicina;
            this.prodato = 0;
        }

        public Sadnica()
        {
            this.prodato = 0;
        }


       //Ovo je stvar za viewmodel a ne za model
        //public int Pozicija
        //{
        //    get
        //    {
        //        return pozicija;
        //    }

        //    set
        //    {
        //        pozicija = value;
        //        OnPropertyChanged("Pozicija");

              
        //    }
        //}

        public string Naziv
        {
            get
            {
                return naziv;
                
            }

            set
            {
                naziv = value;
            }
        }

        public float Cijena
        {
            get
            {
                return cijena;
            }

            set
            {
                cijena = value;
            }
        }

        public int Kolicina
        {
            get
            {
                return kolicina;
            }

            set
            {
                kolicina = value;
            }
        }

        public int Prodato
        {
            get
            {
                return prodato;
            }

            set
            {
                prodato = value;
            }
        }

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

        public bool dostupnost()
        {
            return kolicina!=0;
        }

        public bool rezervirajSadnicu(int koliko)
        {
            if (kolicina - koliko < 0) return false;
            kolicina = kolicina - koliko;
            prodato += koliko;
            return true;
        }
    }
}
