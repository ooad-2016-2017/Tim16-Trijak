using SmartGreenhouse.Helper;
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
        private ICommand LogIn { get; set; }
        public INavigationService NavigationService { get; set; }
        public PrijavaViewModel() {
            LogIn = new RelayCommand<object>(PrijaviSe, parameter => true);
               NavigationService = new NavigationService();
        }

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


        //public ICommand ButtonClicked
        //{
        //    get
        //    {
        //        return new RelayCommand(PrijaviSe);
        //    }
        //}

        public void PrijaviSe(object parameter)
        {
            korisnik_ = new Korisnik(Ime, Prezime, Password);
        }

}




}
