using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGreenhouse.Model
{
    class Statistika
    {
        private Sadnica vrstaSadnice;
        private DateTime datumIzvjestaja;

        public Statistika() { }

        public int vratiBrojPreostalihSadnica()
        {
            return this.vrstaSadnice.Kolicina;
        }

        public int vratiBrojProdatihSadnica()
        {
            return this.vrstaSadnice.Prodato;
        }

        public float vratiNovcaniPrihod()
        {
            return this.vrstaSadnice.Prodato * this.vrstaSadnice.Cijena;
        }

    }
}
