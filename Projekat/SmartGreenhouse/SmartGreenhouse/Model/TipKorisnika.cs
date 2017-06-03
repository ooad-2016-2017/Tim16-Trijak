using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGreenhouse.Model
{
    public class TipKorisnika
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        int id;
        private String naziv;

        public TipKorisnika(String naziv)
        {
            this.naziv = naziv;
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

        
    }
}
