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
    public sealed partial class Direktor_pocetni : Page
    {
        public Direktor_pocetni()
        {
            this.InitializeComponent();
        }

        private void prikazinarudzbe_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Arhiva_narudzbi), null);
        }

        private void registrradnika_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Registracija_radnika), null);
        }

        private void prikazisedmizvj_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Izvjestaj_o_prodaji), null);
        }

        private void prikazimjesizvj_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Izvjestaj_o_prodaji), null);
        }

        private void prikazigodizvj_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Izvjestaj_o_prodaji), null);
        }
    }
}
