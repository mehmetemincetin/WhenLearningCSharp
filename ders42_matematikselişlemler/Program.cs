int islem;
Console.WriteLine("Aritmetik İşlemlerMenüsüne Hoş Geldiniz...\n");
Console.WriteLine("**** menü ****");
Console.WriteLine("1-Girilen 2 sayıyla dört işlem yapma");
Console.WriteLine("2-Girilen Sayıya üs alma işlemi");
Console.WriteLine("3-Girilen Sayıya Kök Aldırma İşlemi");
Console.WriteLine("4-Girilen kenarlardan karenin alanı ve çevresini bulma");
Console.WriteLine("5-Girilen kenarlardan dikdörtgen alan ve çevre bulma");
Console.WriteLine("6-Eşkenar üçgende çevre\n");
Console.WriteLine("*******************************");

Console.Write("İşlem yapmak istediğiniz bölüme karşılık gelen numarayı giriniz: ");
islem = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (islem == 1)
{
    int a, b, toplam, fark, carpim, bolum;
    Console.Write("1.sayıyı giriniz:");
    a = Convert.ToInt32(Console.ReadLine());
    Console.Write("2.sayıyı giriniz:");
    b = Convert.ToInt32(Console.ReadLine());

    toplam = a + b;
    fark = a - b;
    carpim = a * b;
    bolum = a / b;
    Console.WriteLine("Toplam:" + toplam);
    Console.WriteLine("Fark:" + fark);
    Console.WriteLine("Çarpım:" + carpim);
    Console.WriteLine("Bölüm:" + bolum);
}
if (islem == 2)
{
    double sayi, us, sonuc;
    Console.Write("Sayıyı Giriniz:");
    sayi = Convert.ToDouble(Console.ReadLine());
    Console.Write("Üssü Giriniz:");
    us = Convert.ToDouble(Console.ReadLine());
    sonuc = Math.Pow(sayi, us);
    Console.WriteLine("Sonuç:" + sonuc);

}
if (islem == 3)
{
    double sayii, sonucc;
    Console.Write("Sayıyı giriniz:");
    sayii = Convert.ToDouble(Console.ReadLine());
    sonucc = Math.Sqrt(sayii);
    Console.WriteLine("Sonuç: " + sonucc);

}
if (islem == 4)
{
    int a, alan, cevre;
    Console.Write("1.Kenarı Gİriniz:");
    a= Convert.ToInt32(Console.ReadLine());
    alan = a * a;
    cevre = 4 * a;
    Console.WriteLine("Alan:" + alan);
    Console.WriteLine("Çevre:" + cevre);

}
if (islem == 5)
{
    int a, b, alan, cevre;
    Console.Write("1.kenarı giriniz:");
    a = Convert.ToInt32(Console.ReadLine());
    Console.Write("2.Kenarı giriniz:");
    b = Convert.ToInt32(Console.ReadLine());
    alan = a * b;
    cevre = 2 * (a + b);
    Console.WriteLine("Alan:"+alan);
    Console.WriteLine("Çevre:" + cevre);
}
if (islem == 6)
{
    int a, cevre;
    Console.Write("Kenarı giriniz:");
    a = Convert.ToInt32(Console.ReadLine());
    cevre = 3 * a;
    Console.WriteLine("Çevre:" + cevre);
}
Console.ReadLine();