using SmartGreenhouse.Helper;
using SmartGreenhouse.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Popups;

namespace SmartGreenhouse.ViewModel
{
    class RegistracijaRadnikaViewModel : MainViewModelBas
    {
        private Korisnik korisnik_ = null;
        private string ime_ = "";
        private string prezime_ = "";
        private string lozinka_ = "";
        public ICommand Regis { get; set; }
        public INavigationService NavigationService { get; set; }
        public RegistracijaRadnikaViewModel()
        {
            Regis = new RelayCommand<object>(Registriraj, parameter => true);
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
        public string Lozinka
        {
            get
            {
                return lozinka_;
            }

            set
            {
                lozinka_ = value;
                OnPropertyChanged("Lozinka");
            }
        }
        public async void Registriraj(object parameter)
        {
            korisnik_ = new Korisnik(Ime, Prezime, Lozinka, "Zemljoradnik");
            using (var db = new GreenhouseContext()) { 
            db.Korisnici.Add(korisnik_);
            db.SaveChanges();
        }
            var dialog = new MessageDialog("Korisnik je registrovan!\n");
            await dialog.ShowAsync();

        }

    }
}

