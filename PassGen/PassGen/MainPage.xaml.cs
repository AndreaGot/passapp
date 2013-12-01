using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PassGen.Resources;

namespace PassGen
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Costruttore
        public MainPage()
        {
            InitializeComponent();

            // Codice di esempio per localizzare la ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void btnCrea_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Crea.xaml", UriKind.Relative));
        }

        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Istruzioni.xaml", UriKind.Relative));
        }

        private void btnChi_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Informazioni.xaml", UriKind.Relative));
        }

        // Codice di esempio per la realizzazione di una ApplicationBar localizzata
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Imposta la barra delle applicazioni della pagina su una nuova istanza di ApplicationBar
        //    ApplicationBar = nuova ApplicationBar();

        //    // Crea un nuovo pulsante e imposta il valore del testo sulla stringa localizzata da AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Crea una nuova voce di menu con la stringa localizzata da AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}