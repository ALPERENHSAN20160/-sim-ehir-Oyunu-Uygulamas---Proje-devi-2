using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İsimSehirUygulama
{
    public class IsimSehirOyun : IIsimSehirForm
    {
        public string IIsim {  get; set; }
        public string ISehir { get; set; }
        public string IHayvan { get; set; }
        public string IBitki { get; set; }
        public string IEsya { get; set; }

        public void BilgileriGoster()
        {
            Console.WriteLine($"İsim: {IIsim}");
            Console.WriteLine($"Sehir: {ISehir}");
            Console.WriteLine($"Hayvan: {IHayvan}");
            Console.WriteLine($"Bitki: {IBitki}");
            Console.WriteLine($"Esya: {IEsya}");
        }
    }
}
