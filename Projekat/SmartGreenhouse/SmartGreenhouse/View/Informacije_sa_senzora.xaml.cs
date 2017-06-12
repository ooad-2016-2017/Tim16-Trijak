using SmartGreenhouse.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.SerialCommunication;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace SmartGreenhouse.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Informacije_sa_senzora : Page
    {
        Arduino uredjaj;
        List<string> stringovi;
        List<SerialDevice> uredjaji;
        List<String> listaSenzora;
        public const String TEMPERATURA = "Temperatura", VLAZNOST_ZEMLJE = "Vlažnost zemlje",
            OSVJETLJENJE = "Osvjetljenje", VLAZNOST_ZRAKA = "Vlažnost zraka", STANJE_REZERVOARA = "Stanje rezervoara";

        public Informacije_sa_senzora()
        {
            this.InitializeComponent();
            listaSenzora = new List<String>{ TEMPERATURA, VLAZNOST_ZEMLJE, OSVJETLJENJE, VLAZNOST_ZRAKA, STANJE_REZERVOARA };
        }

        private void nazad_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Zemljoradnik_pocetni), null);
        }

        private async void osvjezi_Click(object sender, RoutedEventArgs e)
        {
          await Arduino.skenirajPortove();
            stringovi = new List<string>();
            uredjaji = new List<SerialDevice>();
           foreach(SerijskiUredjajIIme i in Arduino.serijskiUredjaji)
            {
                 stringovi.Add(i.Ime);
                 uredjaji.Add(i.Uredjaj);
            }
            lista.ItemsSource = stringovi;
            senzori.ItemsSource = listaSenzora;
        }

        private void lista_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string ime = lista.SelectedItem.ToString();
            if (ime != null)
            {
             uredjaj = new Arduino(uredjaji[stringovi.IndexOf(ime)]);
                uredjaj = new Arduino(uredjaji[0]);
            }
            
        }

        private async void senzori_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            String selektovani = senzori.SelectedItem.ToString();
            switch(selektovani)
            {
                case TEMPERATURA:
                    await uredjaj.dajTemperaturu();
                    rezultat.Text = uredjaj.temperatura;
                    uredjaj.temperatura = "Nije očitano";
                    break;
                case VLAZNOST_ZEMLJE:
                    await uredjaj.dajVlaznostZemlje();
                    rezultat.Text = uredjaj.vlaznostZemlje;
                    uredjaj.vlaznostZemlje = "Nije očitano";
                    break;
                case OSVJETLJENJE:
                    await uredjaj.dajOsvjetljenje();
                    rezultat.Text = uredjaj.osvjetljenje;
                    uredjaj.osvjetljenje = "Nije očitano";
                    break;
                case VLAZNOST_ZRAKA:
                    await uredjaj.dajVlaznostZraka();
                    rezultat.Text = uredjaj.vlaznostZraka;
                    uredjaj.vlaznostZraka = "Nije očitano";
                    break;
                case STANJE_REZERVOARA:
                    await uredjaj.dajStanjeRezervoara();
                    rezultat.Text = uredjaj.stanjeRezervoara;
                    uredjaj.stanjeRezervoara = "Nije očitano";
                    break;

                default:
                    break;
            }
        }
    }
}
