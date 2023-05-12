int i;
i = 1;
while (i < 10)
{
    Console.WriteLine("MERHABA İSTANBUL");
    i++;

}


Console.WriteLine("-----------------------------------");


int sayı;
Console.Write("bir sayı girin:");
sayı = Convert.ToInt32(Console.ReadLine());
while (sayı % 2 == 0)
{
    Console.Write("Bir Sayı Girin:");
    sayı = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("tek sayı giridiniz");


Console.WriteLine("------------------------------------");


int rakam;
Console.Write("FAKTÖRYELİ GİRİNİZ:");
rakam = Convert.ToInt32(Console.ReadLine());
int faktöryel = 1;
while (rakam > 1)
{
    faktöryel = faktöryel * rakam;
    rakam--;
}

Console.Write(faktöryel);
Console.ReadLine();






