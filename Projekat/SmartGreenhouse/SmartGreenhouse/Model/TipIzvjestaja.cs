using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGreenhouse.Model
{
    public class TipIzvjestaja
    {
        private string naziv;
        private string id;

        public TipIzvjestaja(string naziv, string iD)
        {
            this.naziv = naziv;
            id = iD;
        }

        public TipIzvjestaja() { }

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

        public string ID
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
