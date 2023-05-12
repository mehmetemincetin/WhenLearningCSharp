StreamWriter dosya = new StreamWriter(@"/Users/emincetin/Desktop");
string veri;
Console.Write("Buraya notunuzu giriniz:");
veri = Console.ReadLine();
dosya.WriteLine(veri);
dosya.Close();
