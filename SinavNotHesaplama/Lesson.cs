using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinavNotHesaplama
{
    public class Lesson : IRepository
    {
        public string name { get; set; }

        private List<Score> scores;

        public bool pass { get; set; }

        public Lesson(string name)
        {
            this.name = name;
            scores = new List<Score>();
        }
        public void add(double not, double percentege)
        {
            scores.Add(new Score(not, percentege));
        }
        public double Calculate(Score scr)
        {
            return scr.score * scr.percentage / 100;
        }

        public string LetterGrade()
        {
            double total = 0;
            foreach (Score item in scores)
            {
                total += Calculate(item);
            }
            if (90 <= total && total <= 100)
            {
                pass = true;
                return "Puan Ortalamanız: " + total + " Harf Notunuz : AA";
            }
            else if (85 <= total && total < 90)
            {
                pass = true;
                return "Puan Ortalamanız: " + total + " Harf Notunuz : BA";
            }
            else if (80 <= total && total < 85)
            {
                pass = true;
                return "Puan Ortalamanız: " + total + " Harf Notunuz : BB";
            }
            else if (75 <= total && total < 80)
            {
                pass = true;
                return "Puan Ortalamanız: " + total + " Harf Notunuz : CB";
            }
            else if (70 <= total && total < 75)
            {
                pass = true;
                return "Puan Ortalamanız: " + total + " Harf Notunuz : CC";
            }
            else if (65 <= total && total < 70)
            {
                pass = true;
                return "Puan Ortalamanız: " + total + " Harf Notunuz : DC";
            }
            else if (60 <= total && total < 65)
            {
                pass = true;
                return "Puan Ortalamanız: " + total + " Harf Notunuz : DD";
            }
            else
            {
                pass = false;
                return "Puan Ortalamanız: " + total + " Harf Notunuz : FF";
            }
        }

        public string PassOrFail()
        {
            return (pass) ? "Geçtiniz.!" : "Kaldınız.!";
        }

        public bool ValidPercentegeInput()
        {
            double tmp = 0;
            foreach (Score item in scores)
            {
                tmp += item.percentage;
            }
            return (tmp == 100) ? true : false;
        }
        public void Clear()
        {
            scores.Clear();
        }
    }
}
