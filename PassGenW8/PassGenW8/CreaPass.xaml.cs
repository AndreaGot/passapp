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
using System.Text;
using System.Windows;
using Windows.ApplicationModel.DataTransfer;
using Windows.UI.Popups;




// Il modello di elemento per la pagina vuota è documentato all'indirizzo http://go.microsoft.com/fwlink/?LinkId=234238

namespace PassGenW8
{
    /// <summary>
    /// Pagina vuota che può essere utilizzata autonomamente oppure esplorata all'interno di un frame.
    /// </summary>
    public sealed partial class CreaPass : Page
    {

        private static Random random = new Random((int)DateTime.Now.Ticks);
        int inizio = 33;

        public CreaPass()
        {
            this.InitializeComponent();
        }

        private  void backButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int lung;
            try
            {
                lung = Convert.ToInt32(txtNum.Text);
            }
            catch
            {
             CancelCommandButton_Click(sender, e);
                return;
            }


            StringBuilder builder = new StringBuilder();

            char ch;

            if (lung < 6 || lung > 24)
            {
                CancelCommandButton_Click(sender, e);
                return;
            }

            for (int i = 0; i < lung; i++)
            {
                ch = Convert.ToChar(random.Next(inizio, 122));
                builder.Append(ch);
            }

            txtPass.Text = builder.ToString();

            lblPass.Visibility = Visibility.Visible;
            txtPass.Visibility = Visibility.Visible;
            btnCopia.Visibility = Visibility.Visible;

        }

        private async void CancelCommandButton_Click(object sender, RoutedEventArgs e)
        {
            // Create the message dialog and set its content
            var messageDialog = new MessageDialog("Inserisci un numero compreso tra 6 e 24");

            // Show the message dialog
            await messageDialog.ShowAsync();
        }

        private void btnCopia_Click(object sender, RoutedEventArgs e)
        {
            DataPackage dataPackage = new DataPackage();
            dataPackage.SetText(txtPass.Text);
            Clipboard.SetContent(dataPackage);
        }



    }
}
