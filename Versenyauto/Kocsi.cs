using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Versenyauto
{
    internal class Kocsi
    {
        public string Make;
        public string Model;
        public int Year;
        public int Speed { get; set; }

        public Kocsi(string make, string model, int year, int speed)
        {
            Make = make;
            Model = model;
            Year = year;
            Speed = 0;
            Sebesseg_nov();
        }

        public void Sebesseg_nov()
        {
            if (Speed == 0)
            {
                int sebesseg = new Random().Next(1, 251);
                Speed = sebesseg;
            }
        }

        public override string? ToString()
        {
            return $"Az én kocsim: {Make}, Modell: {Model}, Évjárat: {Year}, Sebessége: {Speed}";
        }
    }
}
