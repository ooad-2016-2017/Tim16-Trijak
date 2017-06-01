using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGreenhouse.Model
{
    public class Ponuda
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        int id;
        private int brojSadnica;
        private List<Sadnica> sadniceUPonudi;

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

        public int BrojSadnica
        {
            get
            {
                return brojSadnica;
            }

            set
            {
                brojSadnica = value;
            }
        }

        public List<Sadnica> SadniceUPonudi
        {
            get
            {
                return sadniceUPonudi;
            }

            set
            {
                sadniceUPonudi = value;
            }
        }

        public Ponuda(List<Sadnica> sadniceUPonudi)
        {
            this.SadniceUPonudi = sadniceUPonudi;
            this.BrojSadnica = sadniceUPonudi.Count;
        }

        public Ponuda() { }

        public void dodajSadnicu(Sadnica sadnica)
        {
            this.SadniceUPonudi.Add(sadnica);
        }

        public void obrisiSadnicu(Sadnica sadnica)
        {
            this.SadniceUPonudi.Remove(sadnica);
        }

        public int vratiRedniBrojSadnice(Sadnica sadnica)
        {
            return SadniceUPonudi.IndexOf(sadnica);
        }
        
    }
}
