using SmartGreenhouse.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGreenhouse.ViewModel
{
    class IzmjenaCijeneSadniceViewModel
{
       // private ObservableCollection<Sadnica> _listaSadnica;
        private Sadnica oznacenaSadnica;

        public IzmjenaCijeneSadniceViewModel() {
            IzmjeniCijenu = new RelayCommand(izmjeniCijenu);            oznacenaSadnica = null;
        }


        public RelayCommand IzmjeniCijenu { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }        public float izmjeniCijenu(object parametar) {
            //this.oznacenaSadnica.Cijena=
        }
    }
}
