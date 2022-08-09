using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlanveCevreHesaplama
{
    public class Daire : ICalculation
    {
        public Daire(double yariCap)
        {
            this.YariCap = yariCap;
        }

        public double YariCap { get; set; }
        public double AlanHesapla()=> Math.PI * YariCap * YariCap;
        public double CevreHesapla()=> 2 * Math.PI * YariCap;
    }
}
