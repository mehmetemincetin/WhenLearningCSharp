int[,] dizi = new int[2, 2];
dizi[0, 0] = 25;
dizi[0, 1] = 35;
dizi[1, 0] = 17;
dizi[1, 1] = 16;
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
        Console.Write("  {0}", dizi[i, j]);
    Console.WriteLine();
}
Console.Read();
Console.Clear();
//--------------------------------------------------------//
int[,] diz = new int[3,3];
diz[0, 0] = 10;
diz[0, 1] = 20;
diz[0, 2] = 30;
diz[1, 0] = 40;
diz[1, 1] = 50;
diz[1, 2] = 60;
diz[2, 0] = 70;
diz[2, 1] = 80;
diz[2, 2] = 90;
for(int k = 0; k < 3; k++)
{
    for (int l = 0; l < 3; l++)
        Console.Write("  {0}", diz[k,l]);
    Console.WriteLine();
}
Console.Read();