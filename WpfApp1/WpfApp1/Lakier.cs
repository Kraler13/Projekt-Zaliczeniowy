using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Lakier
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public string Kolor { get; set; }
        public decimal Cena { get; set; }


        public List<Samochod> Samochods { get; set; }

        public Lakier(string nazwa, string kolor, decimal cena)
        {
            Nazwa = nazwa;
            Kolor = kolor;
            Cena = cena;
        }

        public override string ToString()
        {
            return $"{Nazwa} - {Kolor}, {Cena}zł";
        }
    }
}
