using SmartGreenhouse.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SmartGreenhouse.ViewModel
{
    class PrijavaViewModel : MainViewModelBas
    {
        private Korisnik korisnik_ = null;
        private string ime_ = "";
        private string prezime_ = "";
        private string lozinka_ = "";


        public string Ime
        {
            get
            {
                return ime_;
            }

            set
            {
                ime_ = value;
                OnPropertyChanged("Ime");
            }
        }

        public string Prezime
        {
            get
            {
                return prezime_;
            }

            set
            {
                prezime_ = value;
                OnPropertyChanged("Prezime");
            }
        }

        public string Password
        {
            get
            {
                return lozinka_;
            }

            set
            {
                lozinka_ = value;
                OnPropertyChanged("Password");
            }
        }


        public ICommand ButtonClicked
        {
            get
            {
                return new DelegateCommand(PrijaviSe);
            }
        }

        public void PrijaviSe()
        {
            korisnik_ = new Korisnik(Ime, Prezime, Password);
        }

}




}
