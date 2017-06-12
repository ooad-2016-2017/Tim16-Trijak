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
        /*
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

  Alternativa*/

        private String naziv_ = "";
        private float cijena_ = 0;
        private int kolicina_ = 0;
        public ICommand Sacuvaj { get; set; }
        public INavigationService NavigationService { get; set; }
        private ObservableCollection<Sadnica> sadnice_ = new ObservableCollection<Sadnica>();
        Sadnica sad1 = new Sadnica(5,300,"Mrkva");
        Sadnica sad2 = new Sadnica(3,250,"Paprika");
        Sadnica sad3 = new Sadnica(6,200, "Krompir");
        Sadnica sadnica_;
        private Sadnica odabrana_;

        public DodajSadnicuViewModel()
        {
            Sacuvaj = new RelayCommand<object>(SacuvajPromjene, parameter => true);
            NavigationService = new NavigationService();
            sadnice_.Add(sad1);
            sadnice_.Add(sad2);
            sadnice_.Add(sad3);
           /* using (var db = new GreenhouseContext())
            {
                db.Sadnice.Add(sad1);
                db.Sadnice.Add(sad2);
                db.Sadnice.Add(sad3);
             db.SaveChanges();
            }*/
           
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
        public Sadnica Odabrana
        {
            get
            {
                return odabrana_;
            }
            set
            {
                odabrana_ = value;
                OnPropertyChanged("Odabrana");
            }
        }
        public async void SacuvajPromjene(object parameter)
        {
            if (sadnica_ != null)
            {
                sadnica_.Naziv = naziv_;
                sadnica_.Kolicina = kolicina_;
                sadnica_.Cijena = cijena_;
                sadnice_.Add(sadnica_);
                using (var db = new GreenhouseContext())
                {
                    db.Sadnice.Add(sadnica_);
                    db.SaveChanges();
                }
            }

            if (odabrana_ != null)
            {
                using (var db = new GreenhouseContext())
                {
                    //var u = db.Sadnice.Where(b => b.Naziv == odabrana_.Naziv).FirstOrDefault();
                    sadnice_.Remove(odabrana_);
                  /*  if(u != null)
                    {
                        db.Sadnice.Remove(odabrana_);
                        db.SaveChanges();
                    } else
                    {
                        var dialog22 = new MessageDialog("Ne možete ukloniti sadnicu koje nema!");
                        await dialog22.ShowAsync();
                    }*/ 
                }
            }
            var dialog2 = new MessageDialog("Izmjene su uspješno izvršene!");
            await dialog2.ShowAsync();
        }
    }
}