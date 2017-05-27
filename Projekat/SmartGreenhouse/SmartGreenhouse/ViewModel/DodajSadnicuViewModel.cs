using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGreenhouse.ViewModel
{
    class DodajSadnicuViewModel
    {
        private String nazivSadnice;
        private int kolicina;
        private float cijena;

        public DodajSadnicuViewModel ()
        {
            NazivKomanda=new RelayCommand(dajnaziv);
            KolicinaKomanda=new RelayCommand(dajKolicinu);
            CijenaKomanda=new RelayCommand(dajCijenu);
        }
        public RelayCommand NazivKomanda { get; set; }
        public RelayCommand KolicinaKomanda { get; set; }
        public RelayCommand CijenaKomanda { get; set; }
        public volid dajNaziv() {
            //this.nazivSadnice=
        }
        public volid dajKolicinu()
        {
            //this.kolicina=
        }
        public volid dajCijenu()
        {
            //this.cijena=
        }


    }
}
