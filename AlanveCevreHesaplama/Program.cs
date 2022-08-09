using AlanveCevreHesaplama;
// OOP ile Yapıldı.
string menu;
string calculation;
while (true)
{
    Console.WriteLine("1-Hesaplama \n0-Çıkış");
    menu = Console.ReadLine();
    switch (menu)
    {
        case "1":
        MENU:
            calculation = "";
            Console.WriteLine("1-Alan \n2-Çevre");
            switch (Console.ReadLine())
            {
                case "1":
                    calculation = "Alan";
                    break;
                case "2":
                    calculation = "Çevre";
                    break;
                default:
                    Console.WriteLine("Yanlış Seçim Tekrar Deneyiniz.!");
                    goto MENU;
            }
        CHOISE:
            Console.WriteLine("1-Üçgen \n2-Kare \n3-Dikdörtgen \n4-Daire");
            switch (Console.ReadLine())
            {
                case "1":
                    Ucgen sekil;
                UCGENTIP:
                    Console.WriteLine("Üçgen Tipleri:");
                    Console.WriteLine("1-Eşkenar \n2-İkizkenar\n3-Çeşitkenar");
                    switch (Console.ReadLine())
                    {
                        case "1":
                        ESKENAR:
                            Console.WriteLine("Eşkenar Üçgen Kenar Uzunluğunu Girin:");
                            double eskenar;
                            if (!double.TryParse(Console.ReadLine(), out eskenar))
                            {
                                Console.WriteLine("Sayı Girin:");
                                goto ESKENAR;
                            }
                            if (eskenar <= 0)
                            {
                                Console.WriteLine("0 veya 0'dan Küçük Sayı Giremezsiniz.!");
                                goto ESKENAR;
                            }
                            sekil = new Ucgen(eskenar, eskenar, eskenar);
                            if (calculation.Equals("Alan"))
                            {
                                Console.WriteLine("Eşkenar Üçgenin Alanı : " + sekil.AlanHesapla());
                            }
                            else
                                Console.WriteLine("Eşkenar Üçgenin Çevresi : " + sekil.CevreHesapla());
                            break;
                        case "2":
                            double kenar1, kenar2;
                        KenarAlma1:
                            Console.WriteLine("İkizkenar Üçgenin Eşit Kenar Uzunluklarını Girin:");
                            if (!double.TryParse(Console.ReadLine(), out kenar1))
                            {
                                Console.WriteLine("Sayı Girin:");
                                goto KenarAlma1;
                            }
                            if (kenar1 <= 0)
                            {
                                Console.WriteLine("0 veya 0'dan Küçük Sayı Giremezsiniz.!");
                                goto KenarAlma1;
                            }
                        KenarAlma2:
                            Console.WriteLine("İkizkenar Üçgenin Eşit Olmayan Kenar Uzunluğunu Girin:");
                            if (!double.TryParse(Console.ReadLine(), out kenar2))
                            {
                                Console.WriteLine("Sayı Girin:");
                                goto KenarAlma2;
                            }
                            if (kenar2 <= 0)
                            {
                                Console.WriteLine("0 veya 0'dan Küçük Sayı Giremezsiniz.!");
                                goto KenarAlma2;
                            }
                            if (kenar1 * 2 <= kenar2)
                            {
                                Console.WriteLine("Geçersiz Üçgen!  tekrar Deneyin.!");
                                goto KenarAlma1;
                            }
                            sekil = new Ucgen(kenar1, kenar1, kenar2);
                            if (calculation.Equals("Alan"))
                            {
                                Console.WriteLine("İkizkenar Üçgenin Alanı : " + sekil.AlanHesapla());
                            }
                            else
                                Console.WriteLine("İkizkenar Üçgenin Çevresi : " + sekil.CevreHesapla());
                            break;
                        case "3":
                            double ceskenar1, ceskenar2, ceskenar3;
                        EskenarAlma1:
                            Console.WriteLine("Çeşitkenar Üçgenin 1. Kenar Uzunluğunu Girin:");
                            if (!double.TryParse(Console.ReadLine(), out ceskenar1))
                            {
                                Console.WriteLine("Sayı Girin:");
                                goto EskenarAlma1;
                            }
                            if (ceskenar1 <= 0)
                            {
                                Console.WriteLine("0 veya 0'dan Küçük Sayı Giremezsiniz.!");
                                goto EskenarAlma1;
                            }
                        EskenarAlma2:
                            Console.WriteLine("Çeşitkenar Üçgenin 2. Kenar Uzunluğunu Girin:");
                            if (!double.TryParse(Console.ReadLine(), out ceskenar2))
                            {
                                Console.WriteLine("Sayı Girin:");
                                goto EskenarAlma2;
                            }
                            if (ceskenar2 <= 0)
                            {
                                Console.WriteLine("0 veya 0'dan Küçük Sayı Giremezsiniz.!");
                                goto EskenarAlma2;
                            }
                        EskenarAlma3:
                            Console.WriteLine("Çeşitkenar Üçgenin 3. Kenar Uzunluğunu Girin:");
                            if (!double.TryParse(Console.ReadLine(), out ceskenar3))
                            {
                                Console.WriteLine("Sayı Girin:");
                                goto EskenarAlma3;
                            }
                            if (ceskenar3 <= 0)
                            {
                                Console.WriteLine("0 veya 0'dan Küçük Sayı Giremezsiniz.!");
                                goto EskenarAlma3;
                            }
                            if (ceskenar1 + ceskenar2 <= ceskenar3 || ceskenar1 + ceskenar3 <= ceskenar2 || ceskenar2 + ceskenar3 <= ceskenar1)
                            {
                                Console.WriteLine("Geçersiz Üçgen! Tekrar Deneyin");
                                goto EskenarAlma1;
                            }
                            else
                                sekil = new Ucgen(ceskenar1, ceskenar1, ceskenar2);
                            if (calculation.Equals("Alan"))
                            {
                                Console.WriteLine("Çeşitkenar Üçgenin Alanı : " + sekil.AlanHesapla());
                            }
                            else
                                Console.WriteLine("Çeşitkenar Üçgenin Çevresi : " + sekil.AlanHesapla());
                            break;
                        default:
                            Console.WriteLine("Hatalı Üçgen Tipi Seçtiniz.! Tekrar Deneyin.!");
                            goto UCGENTIP;
                    }
                    break;
                case "2":
                    double karekenar;
                karekenar:
                    Console.WriteLine("Karenin Kenar Uzunluğunu Girin:");
                    if (!double.TryParse(Console.ReadLine(), out karekenar))
                    {
                        Console.WriteLine("Sayı Girin:");
                        goto karekenar;
                    }
                    if (karekenar <= 0)
                    {
                        Console.WriteLine("0 veya 0'dan Küçük Sayı Giremezsiniz.!");
                        goto karekenar;
                    }
                    Kare kare = new Kare(karekenar);
                    if (calculation.Equals("Alan"))
                    {
                        Console.WriteLine("Karenin alanı : " + kare.AlanHesapla());
                    }
                    else
                        Console.WriteLine("Karenin cevresi : " + kare.CevreHesapla());
                    break;
                case "3":
                    double dikkenar1, dikkenar2;
                DikKenar1:
                    Console.WriteLine("Dikdörtgenin 1. Kenar Uzunluğunu Girin:");
                    if (!double.TryParse(Console.ReadLine(), out dikkenar1))
                    {
                        Console.WriteLine("Sayı Girin:");
                        goto DikKenar1;
                    }
                    if (dikkenar1 <= 0)
                    {
                        Console.WriteLine("0 veya 0'dan Küçük Sayı Giremezsiniz.!");
                        goto DikKenar1;
                    }
                DikKenar2:
                    Console.WriteLine("Dikdörtgenin 2. Kenar Uzunluğunu Girin:");
                    if (!double.TryParse(Console.ReadLine(), out dikkenar2))
                    {
                        Console.WriteLine("Sayı Girin:");
                        goto DikKenar2;
                    }
                    if (dikkenar2 <= 0)
                    {
                        Console.WriteLine("0 veya 0'dan Küçük Sayı Giremezsiniz.!");
                        goto DikKenar2;
                    }
                    Dikdortgen dort = new Dikdortgen(dikkenar1, dikkenar2);
                    if (calculation.Equals("Alan"))
                    {
                        Console.WriteLine("Dikdortgenin Alanı : " + dort.AlanHesapla());
                    }
                    else
                        Console.WriteLine("Dikdortgenin Çevresi : " + dort.CevreHesapla());
                    break;
                case "4":
                    double yaricap;
                YariCap:
                    Console.WriteLine("Dairenin Yariçap Uzunluğunu Girin:");
                    if (!double.TryParse(Console.ReadLine(), out yaricap))
                    {
                        Console.WriteLine("Sayı Girin:");
                        goto YariCap;
                    }
                    if (yaricap <= 0)
                    {
                        Console.WriteLine("0 veya 0'dan Küçük Sayı Giremezsiniz.!");
                        goto YariCap;
                    }
                    Daire daire = new Daire(yaricap);
                    if (calculation.Equals("Alan"))
                    {
                        Console.WriteLine("Dairenin Alanı : " + daire.AlanHesapla());
                    }
                    else
                        Console.WriteLine("Dairenin Çevresi : " + daire.CevreHesapla());
                    break;
                default:
                    Console.WriteLine("Hatalı Seçim Lütfen Ekrandaki Rakamlardan Birini Seçin.!");
                    goto CHOISE;
            }
            break;
        case "0":
            Console.WriteLine("Çıkış Yapıldı.");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Yanlış Seçim Sadece Ekranda İstenilen Rakamı Giriniz.!");
            break;
    }
}