﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGreenhouse.Model
{
    public class TipKorisnika
    {
        private String naziv;
        private int id;

        public TipKorisnika(String naziv, int iD)
        {
            this.naziv = naziv;
            id = iD;
        }

        public String Naziv
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

        public int ID
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
    }
}
