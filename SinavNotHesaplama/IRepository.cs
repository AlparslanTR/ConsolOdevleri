using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinavNotHesaplama
{
    public interface IRepository
    {
        public double Calculate(Score score);
        public string LetterGrade();
        public string PassOrFail();
        public bool ValidPercentegeInput();
    }
}
