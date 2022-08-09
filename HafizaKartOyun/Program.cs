Random rnd = new Random();
int RandomInt;
bool Game = true;
int Input1, Input2;
int Run1i, Run1j;
int Run2i, Run2j;
int Fill = 1;
int MoveNumber = 0;
int PairFound = 0;

string[] Cards = { "A", "B", "C", "D", "E", "F", "G", "H", "A", "B", "C", "D", "E", "F", "G", "H" };
string[,] GameBoardShow = new string[4, 4];
string[,] GameBoardData = new string[4, 4]; ;

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
    RANDOM:
        RandomInt = rnd.Next(16);
        if (Cards[RandomInt].Equals("0"))
            goto RANDOM;
        GameBoardData[i, j] = Cards[RandomInt];
        Cards[RandomInt] = "0";
        GameBoardShow[i, j] = (Fill++) + "";
    }
}

var watch = System.Diagnostics.Stopwatch.StartNew();
while (Game)
{
    if (PairFound == 8)
    {
        watch.Stop();
        Console.WriteLine("Oyun Bitti.! TEBRİKLER");
        Console.WriteLine("Toplam Adım Sayısı : " + MoveNumber);
        Console.WriteLine($"Oyun Süresi: {watch.Elapsed.Minutes} Dakika");
        Environment.Exit(0);
    }
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            if (i < 2)
                Console.Write("| " + GameBoardShow[i, j] + "  | ");
            else if (i == 2 && j == 0)
                Console.Write("| " + GameBoardShow[i, j] + "  | ");
            else if (!int.TryParse(GameBoardShow[i, j], out int tmp))
                Console.Write("| " + GameBoardShow[i, j] + "  | ");
            else
                Console.Write("| " + GameBoardShow[i, j] + " | ");

        }
        Console.WriteLine();
    }
    Console.WriteLine("***************************");


INPUT1:
    Console.WriteLine("Lütfen 1. kartı Seçiniz:");
    if (!int.TryParse(Console.ReadLine(), out Input1))
    {
        Console.WriteLine("1/16 Arası Değer Girin.!");
        goto INPUT1;
    }
    if (Input1 <= 0 || Input1 > 16)
    {
        Console.WriteLine("1/16 Arası Değer Girin.!");
        goto INPUT1;
    }
INPUT2:
    Console.WriteLine("Lütfen 2. kartı Seçiniz:");
    if (!int.TryParse(Console.ReadLine(), out Input2))
    {
        Console.WriteLine("1/16 Arası Değer Girin.!");
        goto INPUT2;
    }
    if (Input2 <= 0 || Input2 > 16)
    {
        Console.WriteLine("1/16 Arası Değer Girin.!");
        goto INPUT2;
    }

    MoveNumber++;

    if (Input1 % 4 != 0)
    {
        Run1i = Input1 / 4;
        Run1j = Input1 % 4 - 1;
    }
    else
    {
        Run1i = Input1 / 4 - 1;
        Run1j = 3;
    }

    if (Input2 % 4 != 0)
    {
        Run2i = Input2 / 4;
        Run2j = Input2 % 4 - 1;
    }
    else
    {
        Run2i = Input2 / 4 - 1;
        Run2j = 3;
    }

    GameBoardShow[Run1i, Run1j] = GameBoardData[Run1i, Run1j];
    GameBoardShow[Run2i, Run2j] = GameBoardData[Run2i, Run2j];
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            if (i < 2)
                Console.Write("| " + GameBoardShow[i, j] + "  | ");
            else if (i == 2 && j == 0)
                Console.Write("| " + GameBoardShow[i, j] + "  | ");
            else if (!int.TryParse(GameBoardShow[i, j], out int tmp))
                Console.Write("| " + GameBoardShow[i, j] + "  | ");
            else
                Console.Write("| " + GameBoardShow[i, j] + " | ");

        }
        Console.WriteLine();
    }
    if (!GameBoardData[Run1i, Run1j].Equals(GameBoardData[Run2i, Run2j]))
    {
        GameBoardShow[Run1i, Run1j] = Input1 + "";
        GameBoardShow[Run2i, Run2j] = Input2 + "";
    }
    else
        PairFound++;
    Console.WriteLine("***************************");

}