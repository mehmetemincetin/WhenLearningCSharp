int sınav1, sınav2, ortalama;

Console.Write("birinici sınavınız=");
sınav1 = Convert.ToInt32(Console.ReadLine());

Console.Write("ikinci sınav giriniz=");
sınav2 = Convert.ToInt32(Console.ReadLine());

ortalama = (sınav1 + sınav2) / 2;
Console.WriteLine("ortalama=" + ortalama);
if (ortalama >= 50)
{
    Console.WriteLine("karar=öğrenci dersi geçti");
}
else
{
    Console.WriteLine("karar=öğrenci dersten kaldı");

}
Console.ReadLine();

