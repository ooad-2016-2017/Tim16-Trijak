using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGreenhouse.Model
{
    public class PreuzimanjeInformacija
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        int id;
        private double vlaznostZraka;
        private double vlaznostZemljista;
        private double nivoVode;
        private double osvijetljenost;
        private double temperatura;

        public double VlaznostZraka
        {
            get
            {
                return vlaznostZraka;
            }

            set
            {
                vlaznostZraka = value;
            }
        }

        public double VlaznostZemljista
        {
            get
            {
                return vlaznostZemljista;
            }

            set
            {
                vlaznostZemljista = value;
            }
        }

        public double NivoVode
        {
            get
            {
                return nivoVode;
            }

            set
            {
                nivoVode = value;
            }
        }

        public double Osvijetljenost
        {
            get
            {
                return osvijetljenost;
            }

            set
            {
                osvijetljenost = value;
            }
        }

        public double Temperatura
        {
            get
            {
                return temperatura;
            }

            set
            {
                temperatura = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public void pokreniSistemZaNavodnjavanje() { }
    }
}
