using SmartGreenhouse.Model;
using System;
using SmartGreenhouse.Helper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Collections.ObjectModel;
using Windows.UI.Popups;

namespace SmartGreenhouse.ViewModel
{
    class NarudzbaViewModel : MainViewModelBas
    {
        private Narudzba narudzba_;
        private int redniBrojNarudzbe_ = 0;
        private DateTime datumNarudzbe_;
        private int kolicina_ = 0;
        private ICommand Add1 { get; set; }
        private ICommand SendOrder { get; set; }
        public ObservableCollection<Sadnica> sadnice_ = new ObservableCollection<Sadnica>();
        public ObservableCollection<Sadnica> odabraneSadnice_ = new ObservableCollection<Sadnica>();
        public INavigationService NavigationService { get; set; }
        public Sadnica odabrana_ { get; set; }
        public NarudzbaViewModel()
        {
            Add1 = new RelayCommand<object>(Dodaj, parameter => true);
            NavigationService = new NavigationService();
            SendOrder = new RelayCommand<object>(Plasiraj, parameter => true);
        }

        public int Kolicina
        {
            get
            {
                return kolicina_;
            }
            set
            {
                kolicina_ = value;
                OnPropertyChanged("Kolicina");
            }
        }




        public DateTime DatumNarudzbe
        {
            get
            {
                return datumNarudzbe_;
            }
            set
            {
                datumNarudzbe_ = DateTime.Now;
            }
        }

        public ObservableCollection<Sadnica> Sadnice
        {
            get
            {
                return sadnice_;
            }

            set
            {
                sadnice_ = value;
                OnPropertyChanged("Sadnice");
            }
        }

        public Sadnica SelectedItem
        {
            get
            {
                return odabrana_;
            }
            set
            {
                odabrana_ = value;
                OnPropertyChanged("SelectedItem");
            }
        }

        public async void Dodaj(object parameter)
        {
            if (odabrana_ != null)
            {
                using (var db = new GreenhouseContext())
                {
                    int trazeni_Id = 1;
                    var u = db.Sadnice.Where(b => b.Id == trazeni_Id).FirstOrDefault();
                    //u.IsCheckedIn = true;
                    db.SaveChanges();
                    odabraneSadnice_.Add(odabrana_);
                }
            }
            else
            {
                var dialog = new MessageDialog("Niste odabrali sadnicu!");
                dialog.Title = "Error";
                await dialog.ShowAsync();
            }
        }
        public void Plasiraj(object parameter)
        {
            narudzba_ = new Narudzba(redniBrojNarudzbe_, datumNarudzbe_);
        }

    }
}



       


        /*  private ObservableCollection<Artikal> listaArtikala;
  =======
          /*
          private ObservableCollection<Artikal> listaArtikala;
  >>>>>>> 4acd067a6716ccc56c2c9434ce5a71694a40ce3c
          private Sadnica oznacenaSadnica;
          private bool imaNaStanju;
          private Korisnik trenutniKorisnik;
          private string rijecPretrage;
          public NarudzbaViewModel1 () {
              DodajKolicinu = new RelayCommand(dodajKolicinu);
              PretragaKomanda = new RelayCommand(pretragaKomanda);
              DodajSadnicu = new RelayCommand(dodajSadnicu);
              UnesiDatum = new RelayCommand(unesiDatum);
              NapisiNapomenu = new RelayCommand(napisiNapomenu);

          }

          public RelayCommand DodajKolicinu { get; set; }
          public RelayCommand PretragaKomanda { get; set; }
          public RelayCommand DodajSadnicu { get; set; }
          public RelayCommand UnesiDatum { get; set; }
          public RelayCommand NapisiNapomenu { get; set; }

          //Interfejs
   public event PropertyChangedEventHandler PropertyChanged;
          public void OnPropertyChanged(string propertyName)
          {
              if (PropertyChanged != null)
              {
                  PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
              }
          }



          public void dodajSadnicu(object parametar) {}
          public void pretragaKomanda(object parametar) { }
          public void dodajKolicinu(object parametar) { }
          public void unesiDatum(object parametar) { }
          public void napisiNapomenu(object parametar) {
          }


      */


 