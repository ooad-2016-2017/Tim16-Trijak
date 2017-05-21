using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGreenhouse.Model
{
    public class Ponuda
    {
        private int brojSadnica;
        private List<Sadnica> sadniceUPonudi;

        public Ponuda(List<Sadnica> sadniceUPonudi)
        {
            this.sadniceUPonudi = sadniceUPonudi;
            this.brojSadnica = sadniceUPonudi.Count;
        }

        public Ponuda() { }

        public void dodajSadnicu(Sadnica sadnica)
        {
            this.sadniceUPonudi.Add(sadnica);
        }

        public void obrisiSadnicu(Sadnica sadnica)
        {
            this.sadniceUPonudi.Remove(sadnica);
        }

        public int vratiRedniBrojSadnice(Sadnica sadnica)
        {
            return sadniceUPonudi.IndexOf(sadnica);
        }
        
    }
}
