int max;
char menu = '0';
while (true)
{
MENU:
Console.WriteLine("*********************");
Console.WriteLine("Pascal Üçgenine Hoşgeldiniz.! Giriş İçin 1 Çıkmak İçin 0");
Console.WriteLine("*********************");
menu =Convert.ToChar (Console.ReadLine());
    if (menu == '1')
    {
    PASCAL:
        Console.WriteLine("Pascal Üçgeni İçin Satır Sayısını Girin: ");
        if (!int.TryParse(Console.ReadLine(), out max))
        {
            Console.WriteLine("Sayı Girmek Zorundasın.!");
            goto PASCAL;
        }
        if (max <= 0)
        {
            Console.WriteLine("0 dan Küçük Sayı Giremezsin.!");
            goto PASCAL;
        }
        int space = max - 1;
        for (int i = 0; i < max; i++)
        {
            int start = 1;
            for (int j = 0; j < (space); j++)
            {
                Console.Write("  ");
            }
            for (int k = 0; k <= i; k++)
            {
                Console.Write("  " + start + "  ");
                start = start * (i - k) / (k + 1);
            }
            for (int j = 0; j < space; j++)
            {
                Console.Write("  ");
            }
            Console.WriteLine();
            space--;
        }
    }
    else if (menu == '0')
    {
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("Değeriniz Yanlış");
    }
}


