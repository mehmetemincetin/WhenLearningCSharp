Console.Write("***********girilen mevsimin denk geldiği aylar************");

Console.WriteLine();
Console.WriteLine();
string mevsim;
Console.Write("LÜTFEN BİR MEVSİM GİRİNİZ:");
mevsim = Console.ReadLine();
if (mevsim=="kış")
{
    Console.WriteLine("aralık ocak şubat");
}
else if (mevsim == "yaz")
{
    Console.WriteLine("haziran temmuz ağustos");
}
else if (mevsim =="sonbahar")
{
    Console.WriteLine("eylül ekim kasım");
}
else if (mevsim =="ilkbahar")
{
    Console.WriteLine("mart nisan mayıs");
}

else
{
    Console.Write("BÖYLE BİR MEVSİM BULUNMAMAKTADIR");
}

Console.ReadLine();










