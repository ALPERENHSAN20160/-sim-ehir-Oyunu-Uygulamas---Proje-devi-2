using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İsimSehirUygulama
{
    public interface IIsimSehirForm
    {
        string IIsim { get; set; }
        string ISehir {  get; set; }
        string IHayvan { get; set; }
        string IBitki { get; set; }
        string IEsya { get; set; }

        void BilgileriGoster();

    }
}
