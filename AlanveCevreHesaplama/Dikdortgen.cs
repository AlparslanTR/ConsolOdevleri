using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlanveCevreHesaplama
{
    public class Dikdortgen : ICalculation
    {
        public Dikdortgen(double kenar1, double kenar2)
        {
            this.Kenar1 = kenar1;
            this.Kenar2 = kenar2;
        }

        public double Kenar1 { get; set; }
        public double Kenar2 { get; set; }
        public double AlanHesapla() => Kenar1 * Kenar2;
        public double CevreHesapla()=> (Kenar1 * 2) + (Kenar2 * 2);
    }
}
