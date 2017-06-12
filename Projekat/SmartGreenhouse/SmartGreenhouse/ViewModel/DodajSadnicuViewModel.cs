using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using SmartGreenhouse.Helper;
using SmartGreenhouse.Model;
using Windows.UI.Popups;

namespace SmartGreenhouse.ViewModel
{
    class DodajSadnicuViewModel : MainViewModelBas
    {
        int id;
        private String naziv_ = "";
        private float cijena_ = 0;
        private int kolicina_ = 0;
        public ICommand Sacuvaj { get; set; }
        public INavigationService NavigationService { get; set; }
        public Sadnica odabrana_ { get; set; }
        public ObservableCollection<Sadnica> prikazaneSadnice_ = new ObservableCollection<Sadnica>();
        public Sadnica sadnica_ = null;
        public DodajSadnicuViewModel()
        {
            Sacuvaj = new RelayCommand<object>(SacuvajPromjene, parameter => true);
            NavigationService = new NavigationService();
            using (var db = new GreenhouseContext())
            {
                prikazaneSadnice_ = new ObservableCollection<Sadnica>(db.Sadnice.ToList());
            }
            sadnica_.Naziv = naziv_;
            sadnica_.Kolicina = kolicina_;
            sadnica_.Cijena = cijena_;
        }
        public string Naziv
        {
            get
            {
                return naziv_;
            }
            set
            {
                naziv_ = value;
                OnPropertyChanged("Naziv");
            }
        }

        public float Cijena
        {
            get
            {
                return cijena_;
            }
            set
            {
                cijena_ = value;
                OnPropertyChanged("Cijena");
            }
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

        public async void SacuvajPromjene(object parameter)
        {
            var dialog1 = new MessageDialog("Evo me!");
            await dialog1.ShowAsync();

            if (odabrana_ != null)
            {
                using (var db = new GreenhouseContext())
                {
                    db.Sadnice.Remove(odabrana_);
                }
            }
            else if (naziv_ != "" && kolicina_ != 0 && cijena_ != 0)
            {
                using (var db = new GreenhouseContext())
                {
                    db.Sadnice.Add(sadnica_);
                }
            }
            else
            {
                var dialog2 = new MessageDialog("Greška!");
                await dialog2.ShowAsync();
            }
        }

        /*  private String nazivSadnice;
  =======
          /*
          private String nazivSadnice;
  >>>>>>> 4acd067a6716ccc56c2c9434ce5a71694a40ce3c
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
  <<<<<<< HEAD
          }*/



    }
}