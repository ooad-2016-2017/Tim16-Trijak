using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGreenhouse.Model
{
    public class TipKorisnika
    {
        private String naziv;
        private int ID;

        public TipKorisnika(String naziv, int iD)
        {
            this.naziv = naziv;
            ID = iD;
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

        public int ID1
        {
            get
            {
                return ID;
            }

            set
            {
                ID = value;
            }
        }
    }
}
