metotlar mtr = new metotlar();
int z=mtr.topla(1, 3);
Console.Write("Toplam:" + z);
Console.Read();

class metotlar
{
    public int topla(int a, int b)
    {
        return a + b;
    }
 
}