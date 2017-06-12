using SmartGreenhouse.Helper;
using SmartGreenhouse.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls;

namespace SmartGreenhouse.ViewModel
{
    class IzvjestajViewModel:MainViewModelBas

    {
        private List<Narudzba> narudzbe = new List<Narudzba>();

        IzvjestajViewModel()
        {
            using (var db = new GreenhouseContext())
            {
                narudzbe = db.Narudzbe.ToList();
            }
        }
        public List<Narudzba> Collection
        {
            get
            {
                return narudzbe;
            }

            set
            {
                narudzbe = value;
                OnPropertyChanged("Collection");
            }
        }


        //        private DateTime datum;
        //        private TipIzvjestaja tip;

        //        private INavigationService navigationService;
        //        public Sadnica Sadnica
        //        {
        //            get => sadnica; set => sadnica = value;
        //            }
        //        public TipIzvjetaja Tip
        //        {
        //            get => tip; set => tip = value; }
        //        public DateTime datum
        //        {
        //            get => datum; set => datum = value; }

        //public INavigationService NavigationService
        //        {
        //            get => navigationService; set => navigationService = value; }

        //            public event PropertyChangedEventHandler PropertyChanged;
        //        protected void OnPropertyChanged(string propertyName)
        //        {
        //            if (PropertyChanged != null)
        //            {
        //                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        //            }


        //        }


    }
}
