int sayı1, sayı2, toplam, carpım, fark, bolum;
Console.WriteLine("********ARİTMETİK DÖRT İŞLEM**********");

Console.WriteLine();

Console.Write("Birinici Sayıyı Giriniz=");
sayı1 = Convert.ToInt32(Console.ReadLine());

Console.Write("ikinci sayıyı giriniz=");
sayı2 = Convert.ToInt32(Console.ReadLine());

toplam = sayı1 + sayı2;
Console.WriteLine("toplam=" + toplam);

carpım = sayı1 * sayı2;
Console.WriteLine("carpım=" + carpım);

fark = sayı2 - sayı2;
Console.WriteLine("fark=" + fark);

bolum = sayı1 / sayı2;
Console.WriteLine("bolum=" + bolum);

Console.Read();
