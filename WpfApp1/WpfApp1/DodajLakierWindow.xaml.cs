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
    /// Logika interakcji dla klasy DodajLakierWindow.xaml
    /// </summary>
    public partial class DodajLakierWindow : Window
    {
        public MainWindow mw;
        public AdminWindow aw;

        public DodajLakierWindow(MainWindow mw, AdminWindow aw)
        {
            InitializeComponent();

            this.mw = mw;
            this.aw = aw;
        }

        private void dodaj_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(nazwaTxt.Text) || string.IsNullOrEmpty(kolorTxt.Text) || !decimal.TryParse(cenaTxt.Text, out decimal cena))
            {
                MessageBox.Show("Wprowadzono złe dane");
            }
            else
            {
                Lakier lakier = new Lakier(nazwaTxt.Text, kolorTxt.Text, cena);
                mw.db.Lakiers.Add(lakier);
                mw.db.SaveChanges();

                aw.Reload();
                this.Close();
            }
        }
    }
}
