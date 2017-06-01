using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGreenhouse.Model
{
    public class Izvjestaj
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        int id;
        private DateTime datumIzvjestaja;
        private Sadnica[] vrstaSadnice;
        private TipIzvjestaja tipIzvjestaja;

        public Izvjestaj(DateTime datumIzvjestaja, Sadnica[] vrstaSadnice, TipIzvjestaja tipIzvjestaja)
        {
            this.datumIzvjestaja = datumIzvjestaja;
            this.vrstaSadnice = vrstaSadnice;
            this.tipIzvjestaja = tipIzvjestaja;
        }

        public Izvjestaj() { }

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

        internal Sadnica[] VrstaSadnice
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

        public TipIzvjestaja TipIzvjestaja
        {
            get
            {
                return tipIzvjestaja;
            }

            set
            {
                tipIzvjestaja = value;
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
    }
}
