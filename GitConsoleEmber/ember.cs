using System;
using System.Collections.Generic;
using System.Text;

namespace GitConsoleEmber
{
    class ember
    {
        public string nev { get; set; }
        public int kor { get; set; }
        public string cim { get; set; }
        public int fizetes { get; set; }

        public ember(string nev, int kor, string cim, int fizetes)
        {
            this.nev = nev;
            this.kor = kor;
            this.cim = cim;
            this.fizetes = fizetes;
        }

        public override string ToString()
        {
            return $"Nev: {nev} , kor: {kor} , cím: {cim} , fizetés: {fizetes}";
        }

        public override bool Equals(object obj)
        {
            return obj is ember ember &&
                   nev == ember.nev &&
                   kor == ember.kor &&
                   cim == ember.cim;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(nev, kor, cim);
        }
    }
}
