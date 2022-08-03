using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Samochod
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Marka { get; set; }
        public string Kategori { get; set; }
        public decimal Cena { get; set; }
        public int SilnikId { get; set; }
        public int LakierId { get; set; }

        public Silnik Silnik { get; set; }
        public Lakier Lakier { get; set; }

        public Samochod(string model, string marka, string kategori, decimal cena, int silnikId, int lakierId)
        {
            Model = model;
            Marka = marka;
            Kategori = kategori;
            Cena = cena;
            SilnikId = silnikId;
            LakierId = lakierId;
        }

        public override string ToString()
        {
            return $"{Marka} {Model}";
        }
    }
}
