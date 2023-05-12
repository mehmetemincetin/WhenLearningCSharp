int sınav1, sınav2, sınav3, ortalama;
Console.Write("1.sınavı giriniz:");
sınav1 = Convert.ToInt32(Console.ReadLine());
Console.Write("2.sınavı giriniz:");
sınav2= Convert.ToInt32(Console.ReadLine());
Console.Write("3.sınavı giriniz:");
sınav3 = Convert.ToInt32(Console.ReadLine());

ortalama = (sınav1 + sınav2 + sınav3) / 3;
Console.WriteLine("ortalama=" + ortalama);

if (ortalama > 0 && ortalama < 30) 
{
    Console.WriteLine("durum:çok kötü");
}
else if (ortalama >= 30 && ortalama < 50) 
{
    Console.WriteLine("durum:iyi değil");
}
else if (ortalama >= 50 && ortalama < 75) 
{
    Console.WriteLine("durum:iyi");
}
else if (ortalama >= 75 && ortalama < 100) 
{
    Console.WriteLine("durum:harika");
}
Console.ReadLine();







