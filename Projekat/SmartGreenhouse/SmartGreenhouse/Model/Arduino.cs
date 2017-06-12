using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Enumeration;
using Windows.Devices.SerialCommunication;
using Windows.Storage.Streams;

namespace SmartGreenhouse.Model
{
    public class Arduino
    {
        SerialDevice uredjaj;
        public static List<SerijskiUredjajIIme> serijskiUredjaji;
        public String temperatura;
        public String vlaznostZemlje;
        public String osvjetljenje;
        public String vlaznostZraka;
        public String stanjeRezervoara;

        public SerialDevice Uredjaj { get => uredjaj; set => uredjaj = value; }

        public Arduino(SerialDevice uredjaj)
        {
            this.Uredjaj = uredjaj;
            temperatura = vlaznostZemlje = "Nije procitano";
            uredjaj.BaudRate = 9600;
            uredjaj.DataBits = 8;
            uredjaj.Parity = SerialParity.None;
            uredjaj.Handshake = SerialHandshake.None;
            uredjaj.StopBits = SerialStopBitCount.One;
            uredjaj.ReadTimeout = TimeSpan.FromMilliseconds(1000);
            uredjaj.WriteTimeout = TimeSpan.FromMilliseconds(1000);

        }

        public async static Task skenirajPortove()
        {
            serijskiUredjaji = new List<SerijskiUredjajIIme>();

            var tmp = await DeviceInformation.FindAllAsync(SerialDevice.GetDeviceSelector());
            var infos = tmp.ToList();

            foreach (var i in infos)
            {
                SerialDevice dev = await SerialDevice.FromIdAsync(i.Id);
                serijskiUredjaji.Add(new SerijskiUredjajIIme(dev, i.Name));
            }

        }
            
        public async Task dajTemperaturu()
        {
            DataWriter dw = new DataWriter(Uredjaj.OutputStream);
            dw.WriteString("3");
            await dw.StoreAsync();
            DataReader dr = new DataReader(Uredjaj.InputStream);
            uint primljeno = await dr.LoadAsync(128);
            if(primljeno >= (uint)0)
                temperatura = dr.ReadString(primljeno);
            
        }

        public async Task dajVlaznostZemlje()
        {
            DataWriter dw = new DataWriter(Uredjaj.OutputStream);
            dw.WriteString("2");
            await dw.StoreAsync();
            DataReader dr = new DataReader(Uredjaj.InputStream);
            uint primljeno = await dr.LoadAsync(128);
            if (primljeno >= (uint)0)
                vlaznostZemlje = dr.ReadString(primljeno);

        }

        public async Task dajOsvjetljenje()
        {
            DataWriter dw = new DataWriter(Uredjaj.OutputStream);
            dw.WriteString("1");
            await dw.StoreAsync();
            DataReader dr = new DataReader(Uredjaj.InputStream);
            uint primljeno = await dr.LoadAsync(128);
            if (primljeno >= (uint)0)
                osvjetljenje = dr.ReadString(primljeno);

        }

        public async Task dajVlaznostZraka()
        {
            DataWriter dw = new DataWriter(Uredjaj.OutputStream);
            dw.WriteString("4");
            await dw.StoreAsync();
            DataReader dr = new DataReader(Uredjaj.InputStream);
            uint primljeno = await dr.LoadAsync(128);
            if (primljeno >= (uint)0)
                vlaznostZraka = dr.ReadString(primljeno);

        }

        public async Task dajStanjeRezervoara()
        {
            DataWriter dw = new DataWriter(Uredjaj.OutputStream);
            dw.WriteString("5");
            await dw.StoreAsync();
            DataReader dr = new DataReader(Uredjaj.InputStream);
            uint primljeno = await dr.LoadAsync(128);
            if (primljeno >= (uint)0)
                stanjeRezervoara = dr.ReadString(primljeno);

        }
}
}
