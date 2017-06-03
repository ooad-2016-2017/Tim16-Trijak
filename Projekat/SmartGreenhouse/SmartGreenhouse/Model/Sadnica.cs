using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGreenhouse.Model
{
<<<<<<< HEAD
    public class Sadnica : INotifyPropertyChanged
=======
    public class Sadnica
>>>>>>> 4acd067a6716ccc56c2c9434ce5a71694a40ce3c

    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        int id;
        private int pozicija;
        private String naziv;
        private float cijena;
        private int kolicina;
        private int prodato;

        public Sadnica(int pozicija, string naziv, float cijena, int kolicina)
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

        public int Pozicija
        {
            get
            {
                return pozicija;
            }

            set
            {
                pozicija = value;
<<<<<<< HEAD
                OnPropertyChanged("Pozicija");

=======
              
>>>>>>> 4acd067a6716ccc56c2c9434ce5a71694a40ce3c
            }
        }

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
