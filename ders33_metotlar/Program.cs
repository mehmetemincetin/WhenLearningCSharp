static void yazdır(string bilgi)
{
    for (int i = 0; i < 10; i++)
        Console.WriteLine(bilgi);
}
Console.Write("Metni Girin:");
string blg = Console.ReadLine();
yazdır(blg);//aslında yukarıdaki bilgileri çağırıyorum bu komut ile
Console.Read();
Console.Clear();
//--------------------------------------------------------------------//
static int topla(int s1,int s2)
{
    int t = s1 + s2;
    return t;
}
Console.WriteLine("Toplam:" + topla(20, 15));
Console.WriteLine("Toplam:" + topla(23, 24));
Console.Read();
//--------------------------------------------------------------------//
static int kupu(int sayı)
{
    int kupdeger = sayı * sayı * sayı;
    return kupdeger;
}
Console.Write("Sayıyı Girin:");
int s;
s= Convert.ToInt16(Console.ReadLine());
Console.Write("Sonuç:" + kupu(s));//çağirdim burda
Console.Read();



