static void Main()
{
    // With the main method, the user can summon any method that is designated by the number
        Console.WriteLine("Hangi programı çalıştırmak istersiniz:");
        Console.WriteLine("1 - Rastgele Sayı Bulma Oyunu");
        Console.WriteLine("2 - Hesap Makinesi");
        Console.WriteLine("3 - Ortalama Hesaplama");
        Console.WriteLine("4 - Çıkış");

        Console.Write("Seçiminizi yapın (1/2/3/4): ");
        string secim = Console.ReadLine();

        switch (secim)
        {
            case "1":
                RastgeleSayiBulmaOyunu(); // Case 1 brings up the rastgele sayı bulma oyunu
                break;

            case "2":
                HesapMakinesi(); // Case 2 brings up hesap makinesi
                break;

            case "3":
                OrtalamaHesaplama(); // Case 3 brings up ortalama hesaplama method.
                break;

            case "4":
                Console.WriteLine("Programdan çıkılıyor..."); // User exits the game
                return;

            default:
                Console.WriteLine("Geçersiz seçim! Lütfen 1, 2, 3 veya 4'ü seçin.");
                break;
        }
    
}
Main();

static void RastgeleSayiBulmaOyunu()
{
    // With this method I have created a random number game. It is between 1 and 100 and the user has  
    Random rnd = new Random();
    int rastgeleSayi = rnd.Next(1, 100); // random number between 1 and 100
    int tahmin;
    int can = 5; // Users total life

    Console.WriteLine("\n1 ile 100 arasında bir sayı tahmin edin.");

    while (can > 0) // Below conditions are valid as long as the user has more than 0 life.
    {
        Console.Write("Tahmininiz: ");
        tahmin = Convert.ToInt32(Console.ReadLine());

        if (tahmin < 1 || tahmin > 100) // establishing parameters. If the input is outside of these parameters, it will display below message.
        {
            Console.WriteLine("Lütfen geçerli bir sayı girin.");
            continue;
        }

        if (tahmin < rastgeleSayi) // It will display below messages according if the number is bigger or smaller than our guess.
        {
            Console.WriteLine("Daha yüksek bir sayı tahmin edin.");
        }
        else if (tahmin > rastgeleSayi)
        {
            Console.WriteLine("Daha düşük bir sayı tahmin edin.");
        }
        else
        {
            Console.WriteLine("Tebrikler! Doğru tahmin ettiniz.");
            break;
        }

        can--;
        Console.WriteLine($"Kalan can: {can}"); // diplays our reamining life

        if (can == 0)
        {
            Console.WriteLine($"Maalesef tahmin hakkınız bitti. Doğru sayı: {rastgeleSayi}");
        }
    }
}

static void HesapMakinesi()
{
    // Below I am writing a code for a calculator. User needs to enter 1st and 2nd number also the operation symbol.
    double islemyap(double sayi1, double sayi2, char islem)
    {
        double sonuc = 0;

        if (islem == '+')
            sonuc = sayi1 + sayi2;
        else if (islem == '-')
            sonuc = sayi1 - sayi2;
        else if (islem == '*')
            sonuc = sayi1 * sayi2;
        else if (islem == '/')
            sonuc = sayi1 / sayi2;
        else
            Console.WriteLine("Tanımlı olmayan bir işem yaptınız.");
        return sonuc;
    }

    Console.WriteLine("\nBirinci sayıyı giriniz.");
    double sayi1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("İkinci sayıyı giriniz.");
    double sayi2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Hangi işlemi yapmak istersiniz? ( + - * / )");
    char islem = Convert.ToChar(Console.ReadLine());

    double sonuc = islemyap(sayi1, sayi2, islem);
    Console.WriteLine("İşlemin sonucu: " + sonuc);
    if (sayi2 != 0) // With this condition, I am making sure the user receives error for dividing the 1st number with "0"
    {
        sonuc = sayi1 / sayi2;
    }
    else
    {
        Console.WriteLine("Hata: Bölme işlemi için ikinci sayı sıfır olamaz.");
    }
}

static void OrtalamaHesaplama()
{
    // With this method user finds the avarage grade they receive from all 3 courses.
    double not1, not2, not3, ortalama;

    Console.WriteLine("\nLütfen birinci ders notunuzu giriniz.");
    not1 = Convert.ToDouble(Console.ReadLine());

    if (not1 < 0 || not1 > 100) // Checking for invalid input.
    {
        Console.WriteLine("Geçersiz not girdiniz. lütfen tekrar deneyin.");
        return;
    }
    else
    {
        Console.WriteLine("Birinci ders notunuz: " + not1);
    }

    Console.WriteLine("Lütfen ikinci ders notunuzu giriniz.");
    not2 = Convert.ToDouble(Console.ReadLine());

    if (not2 < 0 || not2 > 100) // Checking for invalid input.
    {
        Console.WriteLine("Geçersiz not girdiniz. lütfen tekrar deneyin.");
        return;
    }
    else
    {
        Console.WriteLine("İkinci ders notunuz: " + not2);
    }

    Console.WriteLine("lütfen üçüncü ders notunuzu giriniz.");
    not3 = Convert.ToDouble(Console.ReadLine());

    if (not3 < 0 || not3 > 100) // Checking for invalid input.
    {
        Console.WriteLine("Geçersiz not girdiniz. lütfen tekrar deneyin.");
        return;
    }
    else
    {
        Console.WriteLine("Üçüncü ders notunuz: " + not3);
    }

    ortalama = ((not1 + not2 + not3) / 3); // Grade avarage.

    Console.WriteLine("\nortalama notunuz: " + ortalama); 

    if (ortalama >= 90) // Checking what grade the student will receive in letters.
    {
        Console.WriteLine("Dersten AA aldınız");
    }
    else if (ortalama >= 85)
    {
        Console.WriteLine("Dersten BA aldınız");
    }
    else if (ortalama >= 80)
    {
        Console.WriteLine("Dersten BB aldınız");
    }
    else if (ortalama >= 75)
    {
        Console.WriteLine("Dersten CB aldınız");
    }
    else if (ortalama >= 70)
    {
        Console.WriteLine("Dersten CC aldınız");
    }
    else if (ortalama >= 65)
    {
        Console.WriteLine("Dersten DC aldınız");
    }
    else if (ortalama >= 60)
    {
        Console.WriteLine("Dersten DD aldınız");
    }
    else if (ortalama >= 55)
    {
        Console.WriteLine("Dersten FD aldınız");
    }
    else
    {
        Console.WriteLine("Dersten FF ile kaldınız.");
    }

}

