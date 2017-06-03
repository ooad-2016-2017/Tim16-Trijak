using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
    public sealed partial class Zemljoradnik_pocetni : Page
    {
        public Zemljoradnik_pocetni()
        {
            this.InitializeComponent();
        }

        private void senzori_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Informacije_sa_senzora), null);
        }

        private void izmijenisadnice_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Izmjena_stanja_sadnica), null);
        }

        private void dodajuklonisortu_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Dodavanje_uklanjanje_sadnica), null);
        }

        private void promijenicijenu_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Izmjena_cijena_sadnica), null);
        }

        private void upisinarudzbu_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Upisivanje_narudzbe), null);
        }

        
    }
}
