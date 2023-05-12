string ad, soyad, şehir;
int sınav1, sınav2, sınav3, ortalama;

Console.WriteLine("ÖĞRENCİ BİLGİ");
ad = "mehmet";
soyad = "taş";
şehir = "mersin";

Console.WriteLine("ad=" + ad);
Console.WriteLine("soyad=" + soyad);
Console.WriteLine("şehir=" + şehir);

Console.WriteLine();
Console.WriteLine("oğrenci notları");
Console.WriteLine();

sınav1 = 90;
sınav2 = 80;
sınav3 = 70;

Console.WriteLine("sıanv1=" + sınav1);
Console.WriteLine("sınav2=" + sınav2);
Console.WriteLine("sınav3=" + sınav3);

Console.WriteLine();
Console.WriteLine("ORTALAMA BİLGİSİ");
Console.WriteLine();

ortalama = (sınav1 + sınav2 + sınav3) / 3;

Console.WriteLine("ortalama=" + ortalama);

Console.Read();