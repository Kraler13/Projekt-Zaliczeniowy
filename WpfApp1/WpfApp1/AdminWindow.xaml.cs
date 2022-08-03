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

        public void Reload()
        {
            LakieryGrid.ItemsSource = null;
            LakieryGrid.ItemsSource = mw.db.Lakiers.ToList();
            SilnikGrid.ItemsSource = null;
            SilnikGrid.ItemsSource = mw.db.Lakiers.ToList();
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
            if (SilnikGrid.SelectedItem != null && SilnikGrid.SelectedItem is Lakier)
            {
                Silnik r = (Silnik)LakieryGrid.SelectedItem;
                Silnik silnik = mw.db.Silniks.Find(r.Id);
                mw.db.Silniks.Remove(silnik);
                mw.db.SaveChanges();

                Reload();
            }
            else
            {
                MessageBox.Show("Wybierz lakier");
            }
        }

        private void dodajSilnikBtn_Click(object sender, RoutedEventArgs e)
        {
            DodajSilnikWindow dw = new DodajSilnikWindow(mw, this);
            dw.ShowDialog();
        }
    }
}
