Console.Write("Matrislerde Toplama");
int[,] matris1 ={ { 10,12,13,14},{ 15,16,17,18},{ 19,20,21,22},{ 24,25,26,27} };
int[,] matris2 = { { 1, 2, 3, 4 },{ 5, 6, 7, 8 },{ 9, 10, 11, 12 },{ 10, 12, 12, 12 } };
int[,] toplam = new int[4, 4];
for(int i = 0; i < 4; i++)
{
    for ( int j = 0; j < 4; j++)
    {
        toplam[i, j] = matris1[i, j] + matris2[i, j];
    }
}
for (int k = 0; k < 4; k++)
{
    Console.WriteLine();
    for (int m = 0; m < 4; m++)
    {
        Console.Write(toplam[k, m] + " ");
    }

}
Console.Read();


















