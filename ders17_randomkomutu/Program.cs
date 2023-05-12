Random rastgele = new Random();
int a;
a = rastgele.Next(0,10);
Console.WriteLine(a);
Console.ReadLine();
Console.Clear();
//----------------------------------//
Random sey = new Random();
int sayi;
sayi = sey.Next(50);
Console.WriteLine(sayi);
Console.Read();
Console.Clear();
//----------------------------------//
Console.WriteLine("***Şehir Atama Programı***");
string[] sehirler = { "adana", "mersin", "trabzon", "izmir" };
int b;
b= rastgele.Next(0,sehirler.Length);
Console.WriteLine(b);
Console.Write(sehirler[b]);
Console.Read();
