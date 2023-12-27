using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İsimSehirUygulama
{
    public class UygulamaKisi
    {
        public string Isim4 { get; set; }
        public string Sehir4 { get; set; }
        public string Hayvan4 { get; set; }
        public string Bitki4 { get; set; }
        public string Esya4 { get; set; }

        public UygulamaKisi(string ısim4, string sehir4, string hayvan4, string bitki4, string esya4)
        {
            Isim4 = ısim4;
            Sehir4 = sehir4;
            Hayvan4 = hayvan4;
            Bitki4 = bitki4;
            Esya4 = esya4;
        }

        public override string ToString()
        {
            return $"{Isim4} {Sehir4} {Hayvan4} {Bitki4} {Esya4}";
        }
    }
}
