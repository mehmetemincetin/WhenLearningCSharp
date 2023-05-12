Console.Write("kenar sayısını giriniz:");
int kare;
kare = Convert.ToInt32(Console.ReadLine());

//üst kenar
for(int i = 0; i < kare; i++)
{
    Console.Write("* ");
}
Console.WriteLine();

//sol kenar
for(int j = 0; j < kare - 2; j++)
{
    Console.Write("*");

    //aradaki boşluklar
    for(int k = 0; k < kare-2; k++)
    {
        Console.Write("  ");
    }
    //sağ kenar
    Console.Write(" *");
    Console.WriteLine();
}
//alt kenar
for(int n = 0; n < kare; n++)
{
    Console.Write("* ");
}
Console.Read();













