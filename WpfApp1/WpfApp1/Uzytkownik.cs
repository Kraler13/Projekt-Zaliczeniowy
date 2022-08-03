using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Uzytkownik
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Haslo { get; set; }

        public Uzytkownik(string login, string haslo)
        {
            Login = login;
            Haslo = haslo;
        }
    }
}
