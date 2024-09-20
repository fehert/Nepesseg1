using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
             Console.WriteLine("A beolvasott országok száma:"+orszagok.Count);
             sr.Close();
            foreach(var k in orszagok)
            {
                if (k.Orszagnev == "Kína")
                {
                    Console.WriteLine("Kína népsűrűsége:"+k.Neps()+"fő/km2");
                }
            }
           Console.ReadLine();
        }
    }
}
