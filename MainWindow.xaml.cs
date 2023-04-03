using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kartkowka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Generuj(object sender, RoutedEventArgs e)
        {
            string abc = "abcdefghijklmnoprstuwxyz";
            string cyfry1 = "1234567890";
            string znaki1 = "~!@#$%^&*()_+{}[];:',<.>/?";
            string ABC = "ABCDEFGHIJKLMNOPRSTUWXYZ";
            int random = 0;
            int random1 = 0;
            string haslo = "";
            if ((int.TryParse(l.Text, out int a)) && a >= 4)
            {
                if (duze.IsChecked == true)
                {
                    random = RandomNumberGenerator.GetInt32(ABC.Length);
                    haslo = ABC[random] + haslo;
                    a = a - 1;
                }
                if (znaki.IsChecked == true)
                {
                    random = RandomNumberGenerator.GetInt32(znaki1.Length);
                    haslo = znaki1[random] + haslo;
                    a = a - 1;
                }
                if (cyfry.IsChecked == true)
                {
                    random = RandomNumberGenerator.GetInt32(cyfry1.Length);
                    haslo = cyfry1[random] + haslo;
                    a = a - 1;
                }
                for (int i = 0; i < a; i++)
                {
                    random = RandomNumberGenerator.GetInt32(abc.Length);
                    haslo += abc[random];
                }

                MessageBox.Show(haslo, "Zajebiste zadanie", MessageBoxButton.OK);
            }
            else
            {
                MessageBox.Show("Niepoprawna liczba znaków", "Błąd!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            }
        }
    }

