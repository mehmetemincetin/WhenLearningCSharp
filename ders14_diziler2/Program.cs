int[] sayılar = new int[2];
for (int i = 0; i < 2; i++)
{
    Console.Write(i+1 + " .sayıyı giriniz:") ;
    sayılar[i] = Convert.ToInt32(Console.ReadLine());

}
int enbuyuk;
enbuyuk = sayılar[0];
for (int i = 1; i< 2;i++)
{
    if (enbuyuk < sayılar[i])
    {
        enbuyuk = sayılar[i];
    }
}

Console.WriteLine("En büyük sayı:"+enbuyuk);
Console.ReadLine();
Console.Clear();

//--------------------------------------------------------------//


string[] isim = new string[3];
int[] s1 = new int[3];
int[] s2 = new int[3];
int[] ort = new int[3];
for(int j = 0; j < 3; j++)
{
    Console.Clear();
    Console.Write(j + 1 + ")Öğrencinin adı:");
    isim[j] = Console.ReadLine();

    Console.Write(j + 1 + ")sınav1:");
    s1[j]=Convert.ToInt16(Console.ReadLine());

    Console.Write(j + 1 + ")sınav2:");
    s2[j] = Convert.ToInt32(Console.ReadLine());

    ort[j] = (s1[j] + s2[j]) / 2;
}

Console.Write("öğrenci sinav1   sinav2 ortalama");
Console.WriteLine();
for (int j = 0; j < 3; j++)
{
    Console.WriteLine("    " + isim[j] + "   " + s1[j] + "   " + s2[j] + "          " + ort[j]);
}
Console.ReadLine();
