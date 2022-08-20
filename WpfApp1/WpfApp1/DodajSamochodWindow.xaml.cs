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
    /// Logika interakcji dla klasy DodajSamochodWindow.xaml
    /// </summary>
    public partial class DodajSamochodWindow : Window
    {
        public MainWindow mw;
        public AdminWindow aw;
        public DodajSamochodWindow(MainWindow mw, AdminWindow aw)
        {
            InitializeComponent();

            this.mw = mw;
            this.aw = aw;

            kategoria1.ItemsSource = new string[] { "Miejski", "Crossover", "SUV", "Limuzyna" };
        }

        private void zapiszButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(markaTxt.Text) || string.IsNullOrEmpty(modelTxt.Text) || !decimal.TryParse(cenaTxt.Text, out decimal cena))
            {
                MessageBox.Show("Wprowadzono złe dane");
            }
            else
            {
                Samochod samochod = new Samochod(markaTxt.Text, modelTxt.Text, kategoria1.SelectedItem.ToString(), cena, null, null);
                mw.db.Samochods.Add(samochod);
                mw.db.SaveChanges();

                aw.Reload();
                this.Close();
            }
        }
    }
}
