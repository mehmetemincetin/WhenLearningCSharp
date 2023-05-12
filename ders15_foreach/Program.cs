string[] sehirler = { "mersin", "izmir", "kocaeli", "artvin", "ankara", "erzurum", "sanlıurfa" };
foreach (string j in sehirler)
{
    Console.WriteLine(j);
}
Console.Read();
Console.Clear();
//-----------------------------------------//
int[] sayılar = { 1, 2, 3, 4, 5, 6, 7 };
foreach (int i in sayılar)
{
    Console.WriteLine(i);
}
Console.Read();
Console.Clear();
//------------------------------------------//
int[] değer = { 1, 4, 8, 9 };
int toplam = 0;
foreach(int i in değer)
{
    toplam = toplam + i;
}
Console.Write("toplam:" + toplam);
Console.Read();
Console.Clear();
//----------------------------------------//
int[] rakamlar = { 0, 1, 4, 5, 6, 7, 8, 9 };
foreach(int sayı in rakamlar)
{
    if (sayı % 2 == 0)
    {
        Console.WriteLine(sayı);

    }
}
Console.Read();
Console.Clear();
//---------------------------------------------//
int[] değerler = { 1, 2, 3, 4, 5, 6 };
int sonuc = 1;
foreach(int i in değerler)
{
    sonuc = sonuc * i;
}
Console.Write("6 sayısının faktöryeli:" + sonuc);
Console.Read();

