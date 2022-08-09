using SinavNotHesaplama;
// OOP ile Yapıldı.
bool loop = true;
string input;
double score;
double percentege;

while (loop)
{
    Console.WriteLine("------------------");
    Console.WriteLine("H,h Sınav Not Hesaplama\nE,e Çıkış");
    Console.WriteLine("------------------");
    input = Console.ReadLine().ToLower();

    switch (input)
    {
        case "h":

            int howMany;
            bool validInput = false;
            string tmpS;
            Lesson tmp;
            bool validPercentageInput = false;
            percentege = 0;

            Console.WriteLine("Ders Adı Girin:");
            tmpS = Console.ReadLine();
            while (tmpS.Equals(""))
            {
                Console.WriteLine("Boş Geçilemez. Tekrar Dene.!");
                tmpS = tmpS = Console.ReadLine();
            }

            tmp = new Lesson(tmpS);
            SCORE:
            Console.WriteLine("Not Adetini Yazınız:");
            while (!int.TryParse(Console.ReadLine(), out howMany))
            {
                Console.WriteLine("Hatalı Seçim Tekrar Deneyin.!");
                goto SCORE;
            }

            while (!validInput)
            {
                for (int i = 0; i < howMany; i++)
                {
                    Console.WriteLine((i + 1+".")+"Puanı Girin:");
                    while (!double.TryParse(Console.ReadLine(), out score))
                    {
                        Console.WriteLine("Hatalı Seçim Tekrar Deneyin.!");
                    }
                    if (score > 100 || score < 0)
                    {
                        Console.WriteLine("Puanınız 0/100 Aralığında Olmalıdır.");
                        i--;
                        continue;
                    }
                    while (!validPercentageInput)
                    {
                        Console.WriteLine((i + 1+".")+"Yüzdenizi Girin(Yüzdeniz 100'e Tamamlanmalıdır.!):");
                        while (!double.TryParse(Console.ReadLine(), out percentege))
                        {
                            Console.WriteLine("Hatalı Seçim Tekrar Deneyin.!");
                        }
                        if (percentege > 100 || percentege < 0)
                        {
                            Console.WriteLine("Yüzdeniz 0/100 Aralığında Olmalıdır.");
                            continue;
                        }
                        validPercentageInput = true;
                    }
                    tmp.add(score, percentege);
                    validPercentageInput = false;
                }
                if (!tmp.ValidPercentegeInput())
                {
                    Console.WriteLine("Yüzdelerinizin Toplamı 100 Olmalıdır.! Tekrar Deneyin.!");
                    tmp.Clear();
                }
                else
                    validInput = true;
            }

            Console.WriteLine(tmp.LetterGrade() + " " + tmp.PassOrFail());
            break;
        case "e":
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Tekrar Seçiniz.!");
            break;
    }
}