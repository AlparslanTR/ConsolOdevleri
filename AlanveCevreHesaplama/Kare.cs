using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlanveCevreHesaplama
{
    public class Kare : ICalculation
    {
        public Kare(double kenar1)
        {
            this.kenar1 = kenar1;
        }

        public double kenar1 { get; set; }
        public double AlanHesapla() => kenar1 * kenar1;
        public double CevreHesapla() => kenar1 * 4;
    }
}
