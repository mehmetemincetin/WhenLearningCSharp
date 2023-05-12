double secim, adet, toplam = 0;
double hesap = 0;
Console.WriteLine("************************************************");
Console.WriteLine("**                      **                    **");
Console.WriteLine("**      Yemekler        **       İçecekler    **");
Console.WriteLine("**                      **                    **");
Console.WriteLine("**  1-Et Döner->7 TL    **    7-Ayran->1 TL   **");
Console.WriteLine("**                      **                    **");
Console.WriteLine("** 2-Tavuk Döner->5 Tl  **    8-Kola->3 TL    **");
Console.WriteLine("**                      **                    **");
Console.WriteLine("**  3-Çorbalar->4 TL    **     9-Su->1 TL     **");
Console.WriteLine("**                      **                    **");
Console.WriteLine("** 4-Salatalar->2.50 TL **    10-Çay->1 TL    **");
Console.WriteLine("**                      **                    **");
Console.WriteLine("**  5-Kuru/Pilav->6 TL  **    11-Fanta->2 TL  **");
Console.WriteLine("**                      **                    **");
Console.WriteLine("**   6-Pide->6.50 TL    **    12-Soda->1 TL   **");
Console.WriteLine("************************************************");
for(int i = 1; i < 100; i++)
{
    Console.WriteLine("");
    Console.Write("Alacağınız Ürün Numarası:");
    secim = Convert.ToDouble(Console.Read());

}
if (secim == 1)
{
    Console.Write("Kaç porsiyon et Döner:");
    adet = Convert.ToDouble(Console.ReadLine());
    toplam = adet * 7;
    hesap = hesap + toplam;

}
else if (secim == 2)
{
    Console.Write("Kaç porsiyon tavuk Döner:");
    adet = Convert.ToDouble(Console.ReadLine());
    toplam = adet * 5;
    hesap = hesap + toplam;
}
else if (secim == 3)
{
    Console.Write("Kaç porsiyon Çorba:");
    adet = Convert.ToDouble(Console.ReadLine());
    toplam = adet * 4;
    hesap = hesap + toplam;
}
else if (secim == 4)
{
    Console.Write("Kaç porsiyon Salata:");
    adet = Convert.ToDouble(Console.ReadLine());
    toplam = adet * 2.50;
    hesap = hesap + toplam;
}
else if (secim == 5)
{
    Console.Write("Kaç porsiyon Kuru Pilav:");
    adet = Convert.ToDouble(Console.ReadLine());
    toplam = adet * 6;
    hesap = hesap + toplam;
}
else if (secim == 6)
{
    Console.Write("Kaç porsiyon Pide:");
    adet = Convert.ToDouble(Console.ReadLine());
    toplam = adet * 6.50;
    hesap = hesap + toplam;
}
else if (secim == 7)
{
    Console.Write("Kaç porsiyon Ayran:");
    adet = Convert.ToDouble(Console.ReadLine());
    toplam = adet * 1;
    hesap = hesap + toplam;
}
else if (secim == 8)
{
    Console.Write("Kaç porsiyon Kola:");
    adet = Convert.ToDouble(Console.ReadLine());
    toplam = adet * 3;
    hesap = hesap + toplam;
}
else if (secim == 9)
{
    Console.Write("Kaç porsiyon Su:");
    adet = Convert.ToDouble(Console.ReadLine());
    toplam = adet * 1;
    hesap = hesap + toplam;
}
else if (secim == 10)
{
    Console.Write("Kaç porsiyon Çay :");
    adet = Convert.ToDouble(Console.ReadLine());
    toplam = adet * 1;
    hesap = hesap + toplam;
}
else if (secim == 11)
{
    Console.Write("Kaç porsiyon Fanta:");
    adet = Convert.ToDouble(Console.ReadLine());
    toplam = adet * 2;
    hesap = hesap + toplam;
}
else if (secim == 12)
{
    Console.Write("Kaç porsiyon Soda:");
    adet = Convert.ToDouble(Console.ReadLine());
    toplam = adet * 1;
    hesap = hesap + toplam;
}
else
{
    Console.WriteLine("Böyle Bİr Seçenek Bulunmamaktadır.");
    Console.WriteLine();
    Console.Write("Başka İsteğiniz Var Mı?");
    string cevap = Console.ReadLine();
    if (cevap == "h" || cevap == "H" || cevap == "Hayır" || cevap == "HAYIR" || cevap == "hayır")
        break;
}
Console.WriteLine("Toplam Ödencek Tutar:" + hesap);
Console.Read();