Console.WriteLine("*******9 SAYIISININ TAM KATLARI*********");
Console.WriteLine();
int i;
for (i=1; i<=100; i++)
{
    if (i % 9 == 0)
        Console.WriteLine(i);
}

Console.WriteLine("-------------------------------------------------");
Console.WriteLine("******120 sayısının poziitif tam bölenleri******");
Console.WriteLine();


int sayı = 120;
for(int j=1; j<=120; j++)

{
    if (sayı % j == 0)
        Console.WriteLine(j);
}
Console.WriteLine("----------------------------------------");
Console.WriteLine("********45 sayısının tam bölenleri*******");
Console.WriteLine();
int değişken = 45;
for (int k = 1; k <= 45; k++)
{
    if (değişken % k == 0)
        Console.WriteLine(k);
 
}
Console.WriteLine("----------------------------------------");
Console.WriteLine("******fibbonaci*********");
Console.WriteLine();

int a = 1;
int b = 1;
int c;

Console.WriteLine(a);
Console.WriteLine(b);
for (int l = 1;l <= 10; l++)
{
    c = a + b;
    a = b;
    b = c;
    Console.WriteLine(c);

}
Console.ReadLine();



