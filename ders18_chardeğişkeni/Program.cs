Char cinsiyet;
Console.Write("cinsiyeti girin:");
cinsiyet = Convert.ToChar(Console.ReadLine());
if (cinsiyet == 'e' || cinsiyet=='E')
{
    Console.Write("cinsiyet erkektir");
}
else if (cinsiyet == 'k' || cinsiyet=='K')
{
    Console.Write("cinsiyet kızdır");
}
else
{
    Console.Write("yanlış değer girdiniz");
}
Console.ReadLine();
Console.Clear();
//-------------------------------------------------------------------------------------------------//
char ders;
Console.WriteLine("........YKS ders menüsü.......\n");
Console.WriteLine("TÜRKÇE");
Console.WriteLine("MATEMATİK");
Console.WriteLine("SOSYAL BİLGİSİ");
Console.WriteLine("FEN BİLGİSİ\n");
Console.Write("HANGİ DERSİN BİLGİLERİNİ GÖRMEK İSTİYORSANIZ DERSİN BAŞ HARFİNİ GİRİNİZ:");
ders = Convert.ToChar(Console.ReadLine());
Console.WriteLine();
if (ders == 't' || ders == 'T')
{
    Console.Write("türkçe dersi paragraf ağırlıklı olup dil bilgisi soruları da içerir.\n");
}
else if (ders == 'm' || ders == 'M')
{
    Console.Write("matematik dersi temel mat1 konuları ve 8,9 tane geometri sorusu içerir.\n");
}
else if (ders == 's' || ders == 'S')
{
    Console.Write("sosyal bilgiler inkılap tarih ve coğrafya konularını içerir.\n");
}
else if (ders == 'f' || ders=='F')
{
    Console.Write("fen dersi fizik kimya ve biyoloji derslerini içerir.\n");
}
else
{
    Console.Write("bulunmayan harf giridiniz");
}
Console.ReadLine();















