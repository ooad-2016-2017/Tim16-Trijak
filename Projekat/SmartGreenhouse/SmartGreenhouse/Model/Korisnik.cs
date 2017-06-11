using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGreenhouse.Model
{
    class Korisnik
    {
        public string ime;
        public string prezime;
        public string lozinka;
        //  public TipKorisnika tip;
        public string naziv; 

        public Korisnik()
        {

        }

        public Korisnik(string ime1, string prezime1, string lozinka1, string n)
        {
            ime = ime1;
            prezime = prezime1;
            lozinka = lozinka1;
            naziv=n;
           // tip.Id = i;
        }

        public string Ime
        {
            get
            {
                return ime;
            }

            set
            {
                ime = value;
            }
        }

        public string Prezime
        {
            get
            {
                return prezime;
            }

            set
            {
                prezime = value;
            }
        }
        public string Lozinka
        {
            get
            {
                return lozinka;
            }

            set
            {
                lozinka = value;
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

      /*  public TipKorisnika Tip
        {
            get
            {
                return tip;
            }

            set
            {
                tip = value;
            }
        }*/
    }
}

