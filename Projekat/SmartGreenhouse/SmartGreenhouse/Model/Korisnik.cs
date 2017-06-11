﻿using System;
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
        public TipKorisnika tip;

        public Korisnik()
        {

        }

        public Korisnik(string ime, string prezime, string lozinka, string naziv, int id)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.lozinka = lozinka;
            this.tip.Id = id;
            this.tip.Naziv = naziv;
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

        public TipKorisnika Tip
        {
            get
            {
                return tip;
            }

            set
            {
                tip = value;
            }
        }
    }
}

