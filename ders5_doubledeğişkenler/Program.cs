Console.WriteLine("ÖĞRENCİ NOT HESAPLAMA");
double sınav1, sınav2, sınav3, ort;
string ad, soyad, no;

Console.WriteLine();

Console.WriteLine("***öğrenci kimlik bilgileri");

Console.WriteLine();

Console.Write("adınız=");
ad = Console.ReadLine();

Console.Write("soyadınız=");
soyad = Console.ReadLine();

Console.Write("no=");
no = Console.ReadLine();

Console.WriteLine();
Console.WriteLine("ÖĞRENCİ SINAV BİLGİLERİ");
Console.WriteLine();

Console.Write("Birinci Sınav=");
sınav1 = Convert.ToDouble(Console.ReadLine());
Console.Write("ikinci sınav giriniz=");
sınav2 = Convert.ToDouble(Console.ReadLine());
Console.Write("üçüncü sınav giriniz=");
sınav3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("ORTALAMA DEĞERİ=");

ort = (sınav1 + sınav2 + sınav3)/3;
Console.Write("ortalama=" + ort);

Console.Read();