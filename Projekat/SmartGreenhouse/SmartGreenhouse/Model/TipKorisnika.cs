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
        public int id=0;
        public String naziv="";

        public TipKorisnika(String naziv, int id)
        {
            this.naziv = naziv;
            this.id = id;
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
