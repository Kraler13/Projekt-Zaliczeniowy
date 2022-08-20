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
    /// Logika interakcji dla klasy LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public MainWindow mw;
        public LoginWindow(MainWindow mw)
        {
            InitializeComponent();
            this.mw = mw;
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            Uzytkownik admin = mw.db.Uzytkowniks.FirstOrDefault(f => f.Login == loginTxt.Text && f.Haslo ==hasloTxt.Text);
            if(admin != null)
            {
                AdminWindow aw = new AdminWindow(mw);
                aw.ShowDialog();
            }
            else
            {
                MessageBox.Show("Podany złe dane");
            }
        }
    }
}
