int[] sayilar = { 4, 1, 5, 7, 8, -9, -8, -10, 78, 89 };
foreach (int i in sayilar)
{
if(i>0 && i % 2 ==0)
    {
        Console.WriteLine(i);
    }
}
Console.Read();
Console.Clear();
//---------BÜYÜKTEN KÜÇÜĞE SIRALAMA-----------//
int[] rakamlar = new int[5];
for(int j=0;j<5; j++)
{
    Console.Write("Sayıyı Girin:");
    rakamlar[j] = Convert.ToInt32(Console.ReadLine());
}
Array.Sort(rakamlar);
foreach(int j in rakamlar)
{
    Console.WriteLine(j);
}
Console.Read();
Console.Clear();
//----------KÜÇÜKTEN BÜYÜĞE SIRALAMA----------//
int[] em = new int[5];

for (int j = 0; j < 5; j++)
{
    Console.Write("Sayıyı Girin:");
   em[j] = Convert.ToInt32(Console.ReadLine());
}
Array.Reverse(em);
foreach (int j in em)
{
    Console.WriteLine(j);
}
Console.Read();
Console.Clear();
//---------en büyük,en küçük--------//
int[] rez = new int[5];
for (int k = 0; k < 5; k++)
{
    Console.Write("SAYIYI GİRİNİZ:");
    rez[k] = Convert.ToInt32(Console.ReadLine());
}
Array.Sort(rez);
Console.WriteLine("en küçük elemanı:" + rez[0]);
Console.WriteLine("en büyük elemanı:" + rez[4]);
Console.WriteLine("dizinin boyutu:" + rez.Length);
Console.Read();












