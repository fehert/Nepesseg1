using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Fehér Tamás
namespace nepesseg17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Orszag> orszagok = new List<Orszag>();
            StreamReader sr = new StreamReader("adatok-utf8.txt");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                orszagok.Add(new Orszag(sr.ReadLine()));
            }
            Console.WriteLine("A beolvasott országok száma:" + orszagok.Count);
            sr.Close();
            foreach (var k in orszagok)
            {
                if (k.Orszagnev == "Kína")
                {
                    Console.WriteLine("Kína népsűrűsége:" + k.Neps() + "fő/km2");
                }
            }
            int indiasz = 0;
            int kinasz = 0;
            foreach (var v in orszagok)
            {
                if (v.Orszagnev == "India")
                {
                    indiasz = v.Nepesseg;
                }
                if (v.Orszagnev == "Kína")
                {
                    kinasz = v.Nepesseg;
                }
            }
            int kulonbs = kinasz - indiasz;
            Console.WriteLine("Ennyivel éltek többen kínába mint indiába:" + kulonbs);
            int harmadik = 0;
            for (int i = 0; i < orszagok.Count; i++)
            {
                if (orszagok[i].Orszagnev != "Kína" && orszagok[i].Orszagnev != "India" && orszagok[i].Nepesseg > orszagok[harmadik].Nepesseg)
                {
                    harmadik = i;
                }
            }
            Console.WriteLine("A harmadik legnépesebb ország:" + orszagok[harmadik].Orszagnev);
            foreach (var x in orszagok)
            {
                if (x.Megh())
                {
                    Console.WriteLine(x.Orszagnev+" "+x.Fovaros);
                }
            }
                Console.ReadLine();
            
        }
    }
}
