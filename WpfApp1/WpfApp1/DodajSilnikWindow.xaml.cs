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
    /// Logika interakcji dla klasy DodajSilnikWindow.xaml
    /// </summary>
    public partial class DodajSilnikWindow : Window
    {
        public MainWindow mw;
        public AdminWindow aw;
        public DodajSilnikWindow(MainWindow mw, AdminWindow aw)
        {
            InitializeComponent();

            this.mw = mw;
            this.aw = aw;

            paliwo1.ItemsSource = new string[] { "Benzyna", "Elektryczny", "Diesel", "LPG" };
        }

        private void zapiszButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(nazwaTxt.Text) || !int.TryParse(pojemnoscTxt.Text, out int pojemnosc) || !decimal.TryParse(cenaTxt.Text, out decimal cena))
            {
                MessageBox.Show("Wprowadzono złe dane");
            }
            else
            {
                Silnik silnik = new Silnik(nazwaTxt.Text, pojemnosc, paliwo1.SelectedItem.ToString(), cena);
                mw.db.Silniks.Add(silnik);
                mw.db.SaveChanges();

                aw.Reload();
                this.Close();
            }
        }
    }
}
