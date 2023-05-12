Console.WriteLine("**ALİ AMCANIN KİTAPÇI DÜKKANI");
Console.WriteLine();
double x, indirim, ödenecek;
Console.Write("miktarı giriniz:");
x = Convert.ToDouble(Console.ReadLine());
if (x < 100)
{
    indirim = x * 10 / 100;
    Console.WriteLine("indirim:" + indirim);
    ödenecek = x - indirim;
    Console.WriteLine("ödenecek miktar:" + ödenecek);
}
if (x>=100 && x < 150)
{
    indirim = x * 15 / 100;
    Console.WriteLine("indirim:" + indirim);
    ödenecek = x - indirim;
    Console.WriteLine("ödenecek miktar:" + ödenecek);
}
if(x>=150 && x < 200)
{
    indirim = x * 20 / 100;
    Console.WriteLine("indirim:" + indirim);
    ödenecek = x - indirim;
    Console.WriteLine("ödenecek miktar:" + ödenecek);

}

Console.Read();
