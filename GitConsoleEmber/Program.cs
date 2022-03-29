using System;
using System.Collections.Generic;

namespace GitConsoleEmber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ember> Ember = new List<ember>();
            Ember.Add(new ember("Kis Pista", 36, "Jozska utca 4", 150000));
            Ember.Add(new ember("Nagy Lajos", 45, "Kiraly utca 1", 230000));
            Ember.Add(new ember("Kis Pista", 36, "Jozska utca 4", 150000));
            Ember.Add(new ember("Nagy Lajos", 44, "Kiraly utca 1", 230000));

            Console.Write("Kérem adjon meg egy nevet: ");
            string nev = Console.ReadLine();
            Console.Write("Kérem adjon meg egy Kor: ");
            int kor = int.Parse(Console.ReadLine());
            Console.Write("Kérem adjon meg egy cimet: ");
            string cim = Console.ReadLine();
            Console.Write("Kérem adjon meg egy fizetest: ");
            int fizetes = int.Parse(Console.ReadLine());
            Ember.Add(new ember(nev, kor, cim, fizetes));

            foreach (var item in Ember)
            {
                Console.WriteLine(item.ToString());
            }
            HashSet<ember> Hs = new HashSet<ember>(Ember);
            foreach (var item in Hs)
            {
                Console.WriteLine(item.ToString());
            }


        }
    }
}
