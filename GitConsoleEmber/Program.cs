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
