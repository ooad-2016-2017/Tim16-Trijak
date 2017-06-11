using SmartGreenhouse.Helper;
using SmartGreenhouse.Model;
using SmartGreenhouse.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Popups;

namespace SmartGreenhouse.ViewModel
{
    class PrijavaViewModel : MainViewModelBas
    {
        private Korisnik korisnik_ = null;
        private string ime_ = "";
        private string prezime_ = "";
        private string lozinka_ = "";
        public ICommand LogIn { get; set; }
        public INavigationService NavigationService { get; set; }
        public PrijavaViewModel()
        {
            LogIn = new RelayCommand<object>(PrijaviSe, parameter => true);
            NavigationService = new NavigationService();


            korisnik_ = new Korisnik();
            korisnik_.Ime = ime_;
            korisnik_.Prezime = prezime_;
            korisnik_.Naziv = "Direktor";
            //korisnik_.tip.Id = u.Id;
            korisnik_.Lozinka = lozinka_;
            //korisnik_.tip.Naziv = u.Naziv;

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

        public async void PrijaviSe(object parameter)
        {
            NavigationService.Navigate(typeof(Zemljoradnik_pocetni));
            var tip11 = new TipKorisnika("Zemljoradnik", 2);
            using (var db = new GreenhouseContext())
            {
                db.TipoviKorisnika.Add(tip11);
            }
            if (korisnik_.Naziv == "Zemljoradnik")
            {
                NavigationService.Navigate(typeof(Zemljoradnik_pocetni));
            } else if (korisnik_.Naziv == "Direktor")
            {
                NavigationService.Navigate(typeof(Direktor_pocetni));
            }
        
            // korisnik_ = new Korisnik();
            // korisnik_.Ime = ime_;
            // korisnik_.Prezime = prezime_;
            // korisnik_.Lozinka = lozinka_;



            /* if (korisnik_ != null)
             {
                 using (var db = new GreenhouseContext())

                     db.TipoviKorisnika.Add(korisnik_.tip);
             } else
             {
                 var dialog = new MessageDialog("Neispravna prijava.\n Pokušajte ponovo.");
                 dialog.Title = "Error";
                 await dialog.ShowAsync();
             }
             /* if (ime_ == "" || prezime_ == "" || lozinka_ == "")
              {
                  var dialog = new MessageDialog("Neispravna prijava.\n Pokušajte ponovo.");
                  dialog.Title = "Error";
                  await dialog.ShowAsync();
              }
              else
              {
                  using (var db = new GreenhouseContext())
                  {
                      if (db.Korisnici.Count() > 0)
                      {
                          var u = db.Korisnici.Where(b => b.Ime == ime_ && b.Prezime == prezime_ && b.Lozinka == lozinka_).FirstOrDefault();
                          if (u.tip.Id == 1)
                          {
                              NavigationService.Navigate(typeof(Direktor_pocetni));
                          }
                          else if (u.tip.Id == 2)
                          {
                              NavigationService.Navigate(typeof(Zemljoradnik_pocetni));
                          }
                          else
                          {
                              var korisnik = db.Korisnici.FirstOrDefault(b => b.Ime == ime_ || b.Prezime == prezime_ || b.Lozinka == lozinka_);
                              if (korisnik != null)
                              {
                                  if (korisnik.Ime != ime_ || korisnik.lozinka != lozinka_ || korisnik.Prezime != prezime_)
                                  {
                                      var dialog = new MessageDialog("Pogrešni podaci.\n Pokušajte ponovo.");
                                      ime_ = "";
                                      prezime_ = "";
                                      lozinka_ = "";
                                      dialog.Title = "Error";
                                      await dialog.ShowAsync();
                                  }
                              }
                          }

                      }
                      else
                      {
                          var dialog = new MessageDialog("Pogrešni podaci.\n Pokušajte ponovo.");
                          ime_ = "";
                          prezime_ = "";
                          lozinka_ = "";
                          dialog.Title = "Error";
                          await dialog.ShowAsync();
                      }

                  }

              } */
        }
    }
}
