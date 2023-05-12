DateTime zaman;
zaman = DateTime.Now;
Console.Write("Tarih ve Saat:{0}", zaman);
Console.Read();
Console.WriteLine();
//---------------------------------------------------//
DateTime zamann;
zamann = DateTime.Now;
int ay = zamann.Month;
int gün = zamann.Day;
int yil = zamann.Year;

DayOfWeek haftanıngünü = zamann.DayOfWeek;
Console.WriteLine("Gün:{0}", gün);
Console.WriteLine("Ay:{0}", ay);
Console.WriteLine("Yıl:{0}", yil);
Console.WriteLine("Haftanın Günü:{0}", haftanıngünü);
Console.Read();
//-----------------------------------------------------//
DateTime zama;
zama = DateTime.Now;
Console.WriteLine("*****C# dersleri tarih ve saat fonksiyonları********\n");
Console.WriteLine("Kısa Tarih:{0:d}", zama);
Console.WriteLine("Uzun Tarih:{0:D}", zama);
Console.WriteLine("tam tarih:{0:f}", zama);
Console.WriteLine("tam tarih 2:{0:F}", zama);
Console.WriteLine("Tarih:{0:g}", zama);
Console.Read();

