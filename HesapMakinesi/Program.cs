double result;
int mod1, mod2,modresult;
char menu = '0';

    Console.WriteLine("***************");
    Console.WriteLine("Basit Hesap Makinesi");
    Console.WriteLine("***************");
MENU:
    Console.WriteLine("Toplama için 1");
    Console.WriteLine("Çıkarma için 2");
    Console.WriteLine("Çarpma için 3");
    Console.WriteLine("Bölme için 4");
    Console.WriteLine("Mod Alma İçin 5");
    Console.WriteLine("Çıkış için 0");
    menu = Convert.ToChar(Console.ReadLine());
    if (menu == '1')
    {
        Console.Clear();       
        num1:
        Console.WriteLine("İlk Sayıyı Giriniz:");
        string num1 = Console.ReadLine();
        double matchNum1;
        bool result1 = double.TryParse(num1,out matchNum1);
        if (true!=result1)
        {
            goto num1; 
        }
        
        num2:
        Console.WriteLine("İkinci Sayıyı Giriniz:");
        string num2 = Console.ReadLine();
        double matchNum2;
        bool result2 = double.TryParse(num2, out matchNum2);
        if (true!=result2)
        {
            goto num2;
        }
        result =Convert.ToDouble(num1) + Convert.ToDouble(num2);
        Console.WriteLine("Sonuç:" + result);
        goto MENU;
    
    }
else if (menu == '2')
{
    Console.Clear();
num1:
    Console.WriteLine("İlk Sayıyı Giriniz:");
    string num1 = Console.ReadLine();
    double matchNum1;
    bool result1 = double.TryParse(num1, out matchNum1);
    if (true != result1)
    {
        goto num1;
    }

num2:
    Console.WriteLine("İkinci Sayıyı Giriniz:");
    string num2 = Console.ReadLine();
    double matchNum2;
    bool result2 = double.TryParse(num2, out matchNum2);
    if (true != result2)
    {
        goto num2;
    }
    result = Convert.ToDouble(num1) - Convert.ToDouble(num2);
    Console.WriteLine("Sonuç:" + result);
    goto MENU;

}
else if (menu == '3')
{
    Console.Clear();
num1:
    Console.WriteLine("İlk Sayıyı Giriniz:");
    string num1 = Console.ReadLine();
    double matchNum1;
    bool result1 = double.TryParse(num1, out matchNum1);
    if (true != result1)
    {
        goto num1;
    }

num2:
    Console.WriteLine("İkinci Sayıyı Giriniz:");
    string num2 = Console.ReadLine();
    double matchNum2;
    bool result2 = double.TryParse(num2, out matchNum2);
    if (true != result2)
    {
        goto num2;
    }
    result = Convert.ToDouble(num1) * Convert.ToDouble(num2);
    Console.WriteLine("Sonuç:" + result);
    goto MENU;

}
else if (menu == '4')
{
 Console.Clear();
num1:
    Console.WriteLine("İlk Sayıyı Giriniz:");
    string num1 = Console.ReadLine();
    double matchNum1;
    bool result1 = double.TryParse(num1, out matchNum1);
    if (true != result1)
    {
        goto num1;
    }
num2:
    Console.WriteLine("İkinci Sayıyı Giriniz:");
    string num2 = Console.ReadLine();
    double matchNum2;
    bool result2 = double.TryParse(num2, out matchNum2);
    if (true != result2 && matchNum2 <=0)
    {
        goto num2;
    }
    result = Convert.ToDouble(num1) / Convert.ToDouble(num2);
    Console.WriteLine("Sonuç:" + result);
    goto MENU;

}
else if (menu == '5')
    {
    Console.Clear();
num1:
    Console.WriteLine("İlk Sayıyı Giriniz:");
    string num1 = Console.ReadLine();
    double matchNum1;
    bool result1 = double.TryParse(num1, out matchNum1);
    if (true != result1)
    {
        goto num1;
    }
num2:
    Console.WriteLine("İkinci Sayıyı Giriniz:");
    string num2 = Console.ReadLine();
    double matchNum2;
    bool result2 = double.TryParse(num2, out matchNum2);
    if (true != result2 && matchNum2 <= 0)
    {
        goto num2;
    }
    result = Convert.ToDouble(num1) % Convert.ToDouble(num2);
    Console.WriteLine("Sonuç:" + result);
    goto MENU;
}
    else if (menu == '0')
    {
        Environment.Exit(0);
    }

    else
    {
        Console.WriteLine("Lütfen Geçerli Bir Rakam Giriniz.!");
        goto MENU;
    }

        Console.ReadKey();

