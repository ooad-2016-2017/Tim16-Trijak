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
    class IzmjenaStanjaSadnicaViewModel : MainViewModelBas
    {
        ObservableCollection<Sadnica> lista = new ObservableCollection<Sadnica>();
        int kolicina_ = 0;
        public INavigationService NavigationService { get; set; }
        public ICommand Sacuvaj { get; set; }
        public Sadnica odabrana_ { get; set; }
        public IzmjenaStanjaSadnicaViewModel()
        {
            Sacuvaj = new RelayCommand<object>(SacuvajPromjene, parameter => true);
            NavigationService = new NavigationService();
            using (var db = new GreenhouseContext())
            {
                lista = new ObservableCollection<Sadnica>(db.Sadnice.ToList());
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

        public ObservableCollection<Sadnica> Lista
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
                    odabrana_.Kolicina = kolicina_;
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

        }

    }
}
