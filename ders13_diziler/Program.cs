string[] isimler = { "ali", "mehmet", "ayşe", "fatma" };
Console.Write(isimler[0]);
Console.Read();
Console.WriteLine("***************************");

string[] şehirler = new string[3];
for (int i = 0; i < 3; i++)
{
    Console.Write("şehir:");
    şehirler[i] = Console.ReadLine();
}
Console.WriteLine("*****Şehirler Listesi******");
for(int i = 0; i < 3; i++)
{
    Console.WriteLine(şehirler[i]);
}

Console.ReadLine();


 