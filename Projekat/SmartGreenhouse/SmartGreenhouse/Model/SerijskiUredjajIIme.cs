using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.SerialCommunication;

namespace SmartGreenhouse.Model
{
    public class SerijskiUredjajIIme
    { 
        SerialDevice uredjaj;
        String ime;

        public SerijskiUredjajIIme(SerialDevice uredjaj, String ime)
        {
            this.uredjaj = uredjaj;
            this.ime = ime;
        }

        public SerialDevice Uredjaj
        {
            get
            {
                return uredjaj;
            }

            set
            {
                uredjaj = value;
            }
        }

        internal String Ime
        {
            get
            {
                return ime;
            }

            set
            {
                ime = value;
            }
        }

        

        
    }
}
