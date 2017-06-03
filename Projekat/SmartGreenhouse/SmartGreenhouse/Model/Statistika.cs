using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGreenhouse.Model
{
    public class Statistika
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        int id;
        private Sadnica vrstaSadnice;
        private DateTime datumIzvjestaja;

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

        public Sadnica VrstaSadnice
        {
            get
            {
                return vrstaSadnice;
            }

            set
            {
                vrstaSadnice = value;
            }
        }

        public DateTime DatumIzvjestaja
        {
            get
            {
                return datumIzvjestaja;
            }

            set
            {
                datumIzvjestaja = value;
            }
        }

        public Statistika() { }

        public int vratiBrojPreostalihSadnica()
        {
            return this.VrstaSadnice.Kolicina;
        }

        public int vratiBrojProdatihSadnica()
        {
            return this.VrstaSadnice.Prodato;
        }

        public float vratiNovcaniPrihod()
        {
            return this.VrstaSadnice.Prodato * this.VrstaSadnice.Cijena;
        }

    }
}
