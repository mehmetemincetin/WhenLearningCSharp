Console.Write("Baklava Dilim Sayısı:");
int deger;
deger = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();


for (int i = 1; i <= deger; i++)
{
    //boşluk
    for (int x = deger; x > i; x--)
    {
        Console.Write(" ");
    }
    for(int y = 1; y <= i; y++)
    {
        Console.Write("*" + " ");
    }
    Console.WriteLine();
}
for(int k = 1; k <= deger; k++)
{
    for(int m = 1; m <= k; m++)
    {
        Console.Write(" ");
    }
    for(int n = deger; n > k; n--)
    {
        Console.Write("*" + " ");
    }
    Console.WriteLine();
}
Console.Read();