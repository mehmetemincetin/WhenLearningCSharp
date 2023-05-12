int satir,sütün;
Console.Write("Satır sayısını giriniz:");
satir = Convert.ToInt32(Console.ReadLine());
Console.Write("Sütün sayısını giriniz:");
sütün = Convert.ToInt32(Console.ReadLine());
int[,] matris = new int[satir, sütün];

for(int i = 0; i < satir; i++)
{
    for(int j = 0; j < sütün; j++)
    {
        Console.Write("Matrisin {0}x{1} Degeri:", i + 1, j + 1);
        matris[i, j] = Convert.ToInt32(Console.ReadLine());
    }
   
}
for(int k = 0; k < satir; k++)
{
    for(int n = 0; n < sütün; n++)
    {
     Console.Write(matris[k, n] + " ");
    }
    Console.WriteLine();
}
//Transpoze
Console.WriteLine();
for(int x = 0; x <sütün; x++)
{
    for(int y = 0; y < satir; y++)
    {
        Console.Write(matris[y, x] + " ");
    }
    Console.WriteLine();
}
//kat sayi ile carpma
Console.WriteLine();
int her;
Console.Write("kaç ile çarpılacagını giriniiz:");
her = Convert.ToInt16(Console.ReadLine());
Console.WriteLine();
for (int s = 0; s < satir; s++)
{
    for (int p = 0; p < sütün; p++)

    {
        
        Console.Write(matris[s, p] * her + " ");


    }
        Console.WriteLine();
}

Console.ReadLine();
//---------------------------------------------------------------//
Console.WriteLine("determinant");
int a, b, c, d ,sonuc;
Console.Write("A sayısını girin:");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("B sayısını girin:");
b = Convert.ToInt32(Console.ReadLine());
Console.Write("C sayınısını giriniz:");
c = Convert.ToInt32(Console.ReadLine());
Console.Write("D sayısnı girin:");
d = Convert.ToInt32(Console.ReadLine());

sonuc = Math.Abs((a * d) - (b * c));
Console.Write("Determinant:" + sonuc);
Console.Read();







