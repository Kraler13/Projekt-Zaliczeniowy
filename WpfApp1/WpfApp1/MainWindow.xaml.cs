using System;
using System.Collections.Generic;
using System.Linq;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Baza db;
        public MainWindow()
        {
            InitializeComponent();

            db = new Baza();

            samochodCMB.ItemsSource = db.Samochods.ToList();
            samochodCMB.SelectedIndex = 0;
            silnikCMB.ItemsSource = db.Silniks.ToList();
            silnikCMB.SelectedIndex = 0;
            lakierCMB.ItemsSource = db.Lakiers.ToList();
            lakierCMB.SelectedIndex = 0;
        }

        private void adminBtn_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow lw = new LoginWindow(this);
            lw.ShowDialog();
        }

        private void calculate()
        {
            decimal cena = 0;

            if (samochodCMB.SelectedItem != null)
            {
                Samochod samochod = (Samochod)samochodCMB.SelectedItem;

                cena += samochod.Cena;
            }

            if (silnikCMB.SelectedItem != null)
            {
                Silnik silnik = (Silnik)silnikCMB.SelectedItem;

                cena += silnik.Cena;
            }
            if (lakierCMB.SelectedItem != null)
            {
                Lakier lakier = (Lakier)lakierCMB.SelectedItem;

                cena += lakier.Cena;
            }
            cenaLonczna.Content = "Cena łączna" + cena + "zł";
        }

        private void samochodCMB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            calculate();
        }

        private void silnikCMB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            calculate();
        }

        private void lakierCMB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            calculate();
        }
    }
}
