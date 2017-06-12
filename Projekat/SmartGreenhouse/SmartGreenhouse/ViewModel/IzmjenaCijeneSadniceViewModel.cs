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
using Windows.UI.Xaml.Controls;

namespace SmartGreenhouse.ViewModel
{
    class IzmjenaCijeneSadnicaViewModel : MainViewModelBas
    {
        ObservableCollection<Sadnica> lista = new ObservableCollection<Sadnica>();
        int cijena_ = 0;
        public INavigationService NavigationService { get; set; }
        public ICommand Sacuvaj { get; set; }
        public Sadnica odabrana_ { get; set; }
        /*
        public IzmjenaCijeneSadnicaViewModel()
        {
            Sacuvaj = new RelayCommand<object>(SacuvajPromjene, parameter => true);
            NavigationService = new NavigationService();
            using (var db = new GreenhouseContext())
            {
                lista = new ObservableCollection<Sadnica>(db.Sadnice.ToList());
              //  mylistView.ItemsSource = lista;
            }
        }
        public int Cijena
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

       /* public ObservableCollection<Sadnica> Lista
        {
            get
            {
                return lista;
            }
            set
            {
                lista = value;
                OnPropertyChanged("Collection");
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

        public async void SacuvajPromjene(object parameter)
        {
            if (odabrana_ != null)
            {
                using (var db = new GreenhouseContext())
                {
                    db.Sadnice.Remove(odabrana_);
                    odabrana_.Cijena = cijena_;
                    db.Sadnice.Add(odabrana_);

                    var dialog = new MessageDialog("Izmjena upješno izvršena!");
                    await dialog.ShowAsync();

                }
            }
            else
            {
                var dialog = new MessageDialog("Niste izvršili nikakvu izmjenu!");
                await dialog.ShowAsync();
            }

        } */
        Sadnica sad1 = new Sadnica(5,300,"Mrkva");
        Sadnica sad2 = new Sadnica(2,200, "Paprika");
        Sadnica sad3 = new Sadnica(3,100, "Krompir");

        public IzmjenaCijeneSadnicaViewModel()
        {
            Sacuvaj = new RelayCommand<object>(SacuvajPromjene, parameter => true);
            NavigationService = new NavigationService();
            lista.Add(sad1);
            lista.Add(sad2);
            lista.Add(sad3);
        }
        public int Cijena
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

        public async void SacuvajPromjene(object parameter)
        {
            lista.Remove(odabrana_);
            odabrana_.Cijena = cijena_;
            lista.Add(odabrana_);
            var dialog2 = new MessageDialog("Izmjene su uspješno izvršene!");
            await dialog2.ShowAsync();
        }
    }
}
