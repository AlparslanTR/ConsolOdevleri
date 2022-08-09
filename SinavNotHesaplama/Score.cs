using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinavNotHesaplama
{
    public class Score
    {
        public double score { get; set; }
        public double percentage { get; set; }

        public Score(double score, double percentage)
        {
            this.score = score;
            this.percentage = percentage;
        }
    }
}
