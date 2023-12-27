using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İsimSehirUygulama
{
    public abstract class Genel_Bilgi
    {
        public string İsim { get; set; }

        public string Sehirler { get; set; }

        public string Hayvanlar { get; set; }

        public string Esyalar { get; set; }   

        public string Bitkiler { get; set; }

        public Genel_Bilgi() { }
    }
}
