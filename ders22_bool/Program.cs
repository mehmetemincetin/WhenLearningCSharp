int sayi;
Console.Write("Sayıyı girin:");
sayi = Convert.ToInt32(Console.ReadLine());
bool durum1 = sayi > 0;
bool durum2 = sayi > 10;
Console.WriteLine("sayı pozitif mi {0}", durum1);
Console.WriteLine("sayı 10 dan büyük mü {0}", durum2);
Console.Read();
Console.Clear();
//-------------------------------------------------------//
Console.Write("şifreyi girin:");
int sifre;
sifre = Convert.ToInt32(Console.ReadLine());
bool durum4 = sifre == 1234;
Console.Write("şifre doğru mu {0}", durum4);
Console.Read();





