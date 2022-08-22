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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Logika interakcji dla klasy AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public MainWindow mw;
        public AdminWindow(MainWindow mw)
        {
            InitializeComponent();

            this.mw = mw;

            Reload();
        }

        /// <summary>
        /// Ta funkcja odświerza wszystkie tabele
        /// </summary>
        public void Reload()
        {
            LakieryGrid.ItemsSource = null;
            LakieryGrid.ItemsSource = mw.db.Lakiers.ToList();
            SilnikGrid.ItemsSource = null;
            SilnikGrid.ItemsSource = mw.db.Silniks.ToList();
            SamochodyGrid.ItemsSource = null;
            SamochodyGrid.ItemsSource = mw.db.Samochods.ToList();
        }

        private void dodajLakierBtn_Click(object sender, RoutedEventArgs e)
        {
            DodajLakierWindow dw = new DodajLakierWindow(mw, this);
            dw.ShowDialog();
        }

        private void usunBatton_Click(object sender, RoutedEventArgs e)
        {
            if (LakieryGrid.SelectedItem != null && LakieryGrid.SelectedItem is Lakier)
            {
                Lakier r = (Lakier)LakieryGrid.SelectedItem;
                Lakier lakier = mw.db.Lakiers.Find(r.Id);
                mw.db.Lakiers.Remove(lakier);
                mw.db.SaveChanges();

                Reload();
            }
            else
            {
                MessageBox.Show("Wybierz lakier");
            }
        }

        private void LakieryGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void usunSilnikBatton_Click(object sender, RoutedEventArgs e)
        {
            if (SilnikGrid.SelectedItem != null && SilnikGrid.SelectedItem is Silnik)
            {
                Silnik r = (Silnik)SilnikGrid.SelectedItem;
                Silnik silnik = mw.db.Silniks.Find(r.Id);
                mw.db.Silniks.Remove(silnik);
                mw.db.SaveChanges();

                Reload();
            }
            else
            {
                MessageBox.Show("Wybierz silnik");
            }
        }

        private void dodajSilnikBtn_Click(object sender, RoutedEventArgs e)
        {
            DodajSilnikWindow dw = new DodajSilnikWindow(mw, this);
            dw.ShowDialog();
        }

        private void usunSamochodBatton_Click(object sender, RoutedEventArgs e)
        {
            if (SamochodyGrid.SelectedItem != null && SamochodyGrid.SelectedItem is Samochod)
            {
                Samochod r = (Samochod)SamochodyGrid.SelectedItem;
                Samochod samochod = mw.db.Samochods.Find(r.Id);
                mw.db.Samochods.Remove(samochod);
                mw.db.SaveChanges();

                Reload();
            }
            else
            {
                MessageBox.Show("Wybierz silnik");
            }
        }

        private void dodajSamochodBtn_Click(object sender, RoutedEventArgs e)
        {
            DodajSamochodWindow dw = new DodajSamochodWindow(mw, this);
            dw.ShowDialog();
        }
    }
}
