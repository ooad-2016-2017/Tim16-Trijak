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

        public SerijskiUredjajIIme(SerialDevice uredjaj, string ime)
        {
            this.Uredjaj = uredjaj;
            this.Ime = ime;
        }

        public SerialDevice Uredjaj { get => uredjaj; set => uredjaj = value; }
        public string Ime { get => ime; set => ime = value; }
    }
}
