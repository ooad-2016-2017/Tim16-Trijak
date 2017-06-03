using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGreenhouse.Model
{
    public class TipIzvjestaja
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        int id;
        private string naziv;
        

        public TipIzvjestaja(string naziv)
        {
            this.naziv = naziv;
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
