int kenar, karealan, kareçevre;
int kısakenar, uzunkenar, dikalan, dikcevre;

Console.WriteLine("***KARENİN ALAN VE ÇEVRESİNİ BULMA**");

Console.Write("KARENİN BİR KENARINI GİRİNİZ=");
kenar = Convert.ToInt32(Console.ReadLine());
karealan = kenar * kenar;
kareçevre = 4 * kenar;
Console.WriteLine("karealan=" + karealan);
Console.WriteLine("kareçevre=" + kareçevre);

Console.WriteLine();
Console.WriteLine("***DİKDÖRTGEN***");

Console.Write("KISA KENARI GİRİNİZ=");
kısakenar = Convert.ToInt32(Console.ReadLine());
Console.Write("uzun kenarı giriniz=");
uzunkenar = Convert.ToInt32(Console.ReadLine());

dikalan = kısakenar*uzunkenar;
dikcevre = kısakenar * 2 + uzunkenar * 2;

Console.WriteLine("dikdörtgen alanı=" + dikalan);
Console.WriteLine("dikdörgenin çevresi=" + dikcevre);

Console.ReadLine();


