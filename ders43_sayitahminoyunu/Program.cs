int tahmin = 0;
int hafiza;
int sayac = 0;
Random rastgele = new Random();
hafiza = rastgele.Next(1, 100);
while (tahmin != hafiza)
{
    sayac++;
    Console.Write("Sayı giriniz:");
    tahmin = Convert.ToInt32(Console.ReadLine());
    if (tahmin > hafiza)
    {
        Console.WriteLine("Daha Küçük Sayı Giriniz!");

    }
    else if (tahmin < hafiza)
    {
        Console.WriteLine("Daha Büyük Sayı Giriniz!");
    }
}
Console.WriteLine("Tebrikler........");
Console.WriteLine("{0}.DENEMEDE BULDUNUZ", sayac);
Console.Read();
