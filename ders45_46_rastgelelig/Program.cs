Console.WriteLine("Rastgele Lig Turnuvasına Hoş Geldiniz...\n");
Console.WriteLine("Katılan Tüm Takımlara Başarılar...\n");
int gs = 0, fb = 0, bjk = 0, ts = 0,sayac=1;
int a1,b1,c1,d1;
if (sayac == 1)
{


    Random rastgele = new Random();
    a1 = rastgele.Next(0, 6); b1 = rastgele.Next(0, 6); c1 = rastgele.Next(0, 6); d1 = rastgele.Next(0, 6);
    Console.WriteLine("1.hafta Skorları");
    Console.WriteLine("---------------------");
    Console.WriteLine("Galatasaray " + a1 + "-" + b1 + " Fenerbahçe");
    if (a1 > b1)
    {
        gs = gs + 3;
    }
    if (b1 > a1)
    {
        fb = fb + 3;
    }
    if (a1 == b1)
    {
        gs = gs + 1;
        fb = fb + 1;

    }
    Console.WriteLine("Beşiktaş " + c1 + "-" + d1 + " TrabzonSpor");
    if (c1 > d1)
    {
        bjk = bjk + 3;
    }
    if (d1 > c1)
    {
        ts = ts + 3;
    }
    if (c1 == d1)
    {
        bjk = bjk + 1;
        ts = ts + 1;

    }

    sayac++;
    Console.ReadLine();
}
if (sayac == 2)
{
    Random rastgele = new Random();
    a1 = rastgele.Next(0, 6); b1 = rastgele.Next(0, 6); c1 = rastgele.Next(0, 6); d1 = rastgele.Next(0, 6);
    a1 = rastgele.Next(0, 6); b1 = rastgele.Next(0, 6); c1 = rastgele.Next(0, 6); d1 = rastgele.Next(0, 6);
    Console.WriteLine("2.hafta Skorları");
    Console.WriteLine("---------------------");
    Console.WriteLine("Galatasaray " + a1 + "-" + b1 + " Fenerbahçe");
    if (a1 > b1)
    {
        gs = gs + 3;
    }
    if (b1 > a1)
    {
        fb = fb + 3;
    }
    if (a1 == b1)
    {
        gs = gs + 1;
        fb = fb + 1;

    }
    Console.WriteLine("Beşiktaş " + c1 + "-" + d1 + " TrabzonSpor");
    if (c1 > d1)
    {
        bjk = bjk + 3;
    }
    if (d1 > c1)
    {
        ts = ts + 3;
    }
    if (c1 == d1)
    {
        bjk = bjk + 1;
        ts = ts + 1;

    }

    sayac++;
    Console.ReadLine();

}
if (sayac == 3)
{
    Random rastgele = new Random();
    a1 = rastgele.Next(0, 6); b1 = rastgele.Next(0, 6); c1 = rastgele.Next(0, 6); d1 = rastgele.Next(0, 6);
    a1 = rastgele.Next(0, 6); b1 = rastgele.Next(0, 6); c1 = rastgele.Next(0, 6); d1 = rastgele.Next(0, 6);
    Console.WriteLine("3.hafta Skorları");
    Console.WriteLine("---------------------");
    Console.WriteLine("Galatasaray " + a1 + "-" + b1 + " Fenerbahçe");
    if (a1 > b1)
    {
        gs = gs + 3;
    }
    if (b1 > a1)
    {
        fb = fb + 3;
    }
    if (a1 == b1)
    {
        gs = gs + 1;
        fb = fb + 1;

    }

    Console.WriteLine("Beşiktaş " + c1 + "-" + d1 + " TrabzonSpor");
    if (c1 > d1)
    {
        bjk = bjk + 3;
    }
    if (d1 > c1)
    {
        ts = ts + 3;
    }
    if (c1 == d1)
    {
        bjk = bjk + 1;
        ts = ts + 1;

    }
    sayac++;
    Console.ReadLine();
}
if (sayac == 4)
{
    Console.WriteLine("Maçlar Tamamlandı...\n");
    Console.WriteLine("Puan Tablosu\n");
    Console.WriteLine("Galatasaray:" + gs);
    Console.WriteLine("Fenerbahçe:" + fb);
    Console.WriteLine("Beşiktaş:" + bjk);
    Console.WriteLine("Trabzonspor:" + ts);
}
Console.Read();

