decimal sayi;
sayi = 12345;
Console.Write(sayi);
Console.Read();
Console.Clear();
//----------------------------------------------------------//
decimal s1;
int s2;
s1 = 2.45m;
s2 = 4;
decimal toplam;
toplam = s1 + s2;
Console.Write("toplam:" + toplam);
Console.Read();
Console.Clear();
//--------------------------------------------------------//
decimal x = 0.996m;
decimal y = 999999;
Console.WriteLine("para 1 {0:C}", x);
Console.WriteLine("para 2 {0:C}", y);
Console.WriteLine("x:" + x);
Console.WriteLine("y" + y);
Console.Read();
Console.Clear();
//------------------------------------------------------//
decimal urun1, urun2, toplamm;
int k1, k2;
urun1 = 14.85m;
urun2 = 21.48m;
Console.Write("1.ürünün satis miktari:");
k1 = Convert.ToInt16(Console.ReadLine());
Console.Write("2.urunun satıs miktarını giriniz:");
k2 = Convert.ToInt16(Console.ReadLine());
toplamm = k1 * urun1 + k2 * urun2;
Console.WriteLine("gün sonunda kasaya giren para miktarı:" + toplamm + "TL DİR");
Console.Read();











