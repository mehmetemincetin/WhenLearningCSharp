Console.Write("MATRİSLERDE TOPLAM");
int[,] matris1 = { { 1, 2, 3, 4 }, { 4, 5, 6, 7 } };
int[,] matris2 = { { 12, 13, 14, 15 }, { 16, 17, 18, 19 } };
int[,] toplam = new int[2, 4];
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 4; j++)
    {
        toplam[i, j] = matris1[i, j] + matris2[i, j];
    }
}
for (int k = 0; k < 2; k++)
{
    Console.WriteLine();
    for (int m = 0; m < 4; m++)
    {
        Console.Write(toplam[k, m] + " ");

    }
}
Console.Read();