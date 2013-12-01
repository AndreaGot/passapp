using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Text;

namespace PassGen
{
    public partial class Crea : PhoneApplicationPage
    {
        private static Random random = new Random((int)DateTime.Now.Ticks);
        int inizio = 33;

        public Crea()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int lung;
            try {
                lung = Convert.ToInt32(txtNum.Text);
            }
            catch { 
                MessageBox.Show("Inserisci un numero compreso tra 6 e 24");
                return;
            }


            StringBuilder builder = new StringBuilder();
            
            char ch;

            if (lung < 6 || lung > 24)
            {
                MessageBox.Show("Inserisci un numero compreso tra 6 e 24");
               return;
            }

            for (int i = 0; i < lung; i++)
            {
                ch = Convert.ToChar(random.Next(inizio, 122));
                builder.Append(ch);
            }

            txtPass.Text = builder.ToString();

            lblPass.Visibility = System.Windows.Visibility.Visible;
            txtPass.Visibility = System.Windows.Visibility.Visible;
            btnCopia.Visibility = System.Windows.Visibility.Visible;

        }

        private void btnCopia_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(txtPass.Text);
        }


    }
}