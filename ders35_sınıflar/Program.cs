araba arb = new araba();
arb.renk = "siyah";
arb.fiyat = 15000;
arb.model = 2018;
arb.vites = "otomatik";
arb.plaka = "34-istanbul";

Console.WriteLine("Araba Rengi:" + arb.renk);
Console.WriteLine("Fiyatı:" + arb.fiyat);
Console.WriteLine("Modeli:" + arb.model);
Console.WriteLine("Vitesi:" + arb.vites);
Console.WriteLine("Plakası:"+arb.plaka);
Console.WriteLine();

arb.renk = "beyaz";
arb.fiyat = 140000;
arb.model = 2017;
arb.vites = "manuel";
arb.plaka = "33-mersin";

Console.WriteLine("Araba Rengi:" + arb.renk);
Console.WriteLine("Fiyatı:" + arb.fiyat);
Console.WriteLine("Modeli:" + arb.model);
Console.WriteLine("Vitesi:" + arb.vites);
Console.WriteLine("Plakası:" + arb.plaka);
Console.Read();