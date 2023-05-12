int sayı;
Console.WriteLine("***sayı 5 e tam bölünüyor mu***");
Console.WriteLine();

Console.Write("sayıyı girin:");
sayı = Convert.ToInt32(Console.ReadLine());

if (sayı % 5 == 0)
{
    Console.WriteLine("SAYI 5 E TAM BÖLÜNÜR");
}
else
{
    Console.WriteLine("sayı 5 e tam bölünmez");
}

Console.WriteLine();

Console.WriteLine("***sayı tek mi çift mi***");
Console.WriteLine();

int sayı1;
Console.Write("sayıyı giriniz:");
sayı1 = Convert.ToInt32(Console.ReadLine());

if (sayı % 2 == 0)
{
    Console.WriteLine("sayı çifttir");

}

else
{
    Console.WriteLine("sayı tektir");
}
Console.Read();

