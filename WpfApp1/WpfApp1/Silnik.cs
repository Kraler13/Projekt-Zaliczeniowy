using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Silnik
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public int Pojemność { get; set; }
        public string Paliwo { get; set; }
        public decimal Cena { get; set; }

        public List<Samochod> Samochods { get; set; }

        public Silnik(string nazwa, int pojemność, string paliwo, decimal cena)
        {
            Nazwa = nazwa;
            Pojemność = pojemność;
            Paliwo = paliwo;
            Cena = cena;
        }
        public override string ToString()
        {
            return $"{Nazwa} - {Pojemność} - {Paliwo}, {Cena}zł";
        }
    }
}
