using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nepesseg17
{
    class Orszag
    {
        public string Orszagnev { get; private set; }
        public int Terulet { get; private set; }
        public int Nepesseg { get; private set; }
        public string Fovaros { get; private set; }
        public int FovarosNepesseg { get; private set; }


        public Orszag(string sor)
        {
            string[] adatok = sor.Split(';');
            Orszagnev = adatok[0];
            Terulet = int.Parse(adatok[1]);
            if (adatok[2].Contains("g"))
            {
                string szorzas = adatok[2];
                Nepesseg = int.Parse(szorzas.Substring(0, szorzas.Length - 1)) * 10000;
            }
            else
            {
                Nepesseg = int.Parse(adatok[2]);
            }
            Fovaros = adatok[3];
            FovarosNepesseg = int.Parse(adatok[4]) * 1000;
        }

    }
}
