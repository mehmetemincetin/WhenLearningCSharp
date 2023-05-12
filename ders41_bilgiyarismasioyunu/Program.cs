Console.WriteLine("*****************************************************");
Console.WriteLine("    Emin Çetin'in yarışma programına Hoş geldiniz      \n ");
Console.Title="Bilgi Yarışması";
string ad, soyad;
Console.Write("Adınız:");
ad = Convert.ToString(Console.ReadLine());
Console.Write("Soyadınız:");
soyad = Convert.ToString(Console.ReadLine());
Console.WriteLine("**********Başlıyoruz Enter Tuşuna Basınız*********\n");
Console.WriteLine("*******Her Yanıttan Sonra Enter Tuşuna Basmayı Unutmayınız****\n");
Console.WriteLine("******Cevapları Küçük Harflerle verin*******\n");
Console.ReadLine();
int dogru, yanlis, para;
dogru = 0;
yanlis = 0;
para = 0;

string s1;
Console.WriteLine("Soru 1-\"SİNEKLİ BAKKAL\"Romanın yazarı kimdir?.");
s1 = Convert.ToString(Console.ReadLine());
string c1;
Console.Write(" A-Reşat nuri Güntekin\n B-Halide edip adıvar\n C-Zİya gökalp\n D-Ömer seyfettin\n Cevabınız nedir:");
c1 = Console.ReadLine();
if (c1 =="b")
{
    dogru = dogru + 1;
    para = para + 1000;
    Console.WriteLine("Tebrikler Cevap Doğru Enter Tuşuna Basınız");
    Console.ReadLine();
}
else
{
    yanlis = yanlis + 1;
    Console.WriteLine("Maalesef Cevap B Enter Tuşuna Basınız");
    Console.ReadLine();
}
string s2;
Console.WriteLine("soru 2-Aşağıda verilen ilk çağ uygarlıklarından hangisi yazıyı icat etmiştir?");
s2 = Convert.ToString(Console.ReadLine());
string c2;
Console.Write(" A-Hititler\n B-Elamlar\n C-Sümerler\n D-Urartular\n Cevabınız nedir:");
c2 = Console.ReadLine();
if (c2 =="c")
{
    dogru = dogru + 1;
    para = para + 1000;
    Console.WriteLine("Tebrikler Cevap Doğru Enter Tuşuna Basınız");
    Console.ReadLine();
}
else
{
    yanlis = yanlis + 1;
    Console.WriteLine("Maalesef Cevap C Enter Tuşuna Basınız");
    Console.ReadLine();
}

string s3;
Console.WriteLine("soru 3-Maki hangi bölgenin bitki örtüsüdür?");
s3 = Convert.ToString(Console.ReadLine());
string c3;
Console.Write(" A-Akdeniz\n B-Ege\n C-Marmara\n D-Karadeniz\n Cevabınız nedir:");
c3 = Console.ReadLine();
if (c3 =="a")
{
    dogru = dogru + 1;
    para = para + 1000;
    Console.WriteLine("Tebrikler Cevap Doğru Enter Tuşuna Basınız");
    Console.ReadLine();
}
else
{
    yanlis = yanlis + 1;
    Console.WriteLine("Maalesef Cevap A Enter Tuşuna Basınız");
    Console.ReadLine();
}

string s4;
Console.WriteLine("Soru 4-Tsunami felaketinde en fazla zarar gören güney asya ülkesi hangisidir?");
s4 = Convert.ToString(Console.ReadLine());
string c4;
Console.Write(" A-Endonezya\n B-Srilanka\n C-Bağcılar\n D-Tayland\n Cevabınız nedir:");
c4 = Console.ReadLine();
if (c4 == "a")
{
    dogru = dogru + 1;
    para = para + 1000;
    Console.WriteLine("Tebrikler Cevap Doğru Enter Tuşuna Basınız");
    Console.ReadLine();
}
else
{
    yanlis = yanlis + 1;
    Console.WriteLine("Maalesef Cevap A Enter Tuşuna Basınız");
    Console.ReadLine();
}

string s5;
Console.WriteLine("soru 5-2003 yılında euro vizyon şarkı yarışmasında ülkemizi temsil eden ve yarışmada birinci gelen sanatçımız kimdir?");
s5 = Convert.ToString(Console.ReadLine());
string c5;
Console.Write(" A-Grup Athena\n B-Sertap Erener\n C-Şebnem Paker\n D-Ajda Pekkan\n Cevabınız nedir:");
c5 = Console.ReadLine();
if (c5 == "b")
{
    dogru = dogru + 1;
    para = para + 1000;
    Console.WriteLine("Tebrikler Cevap Doğru Enter Tuşuna Basınız");
    Console.ReadLine();
}
else
{
    yanlis = yanlis + 1;
    Console.WriteLine("Maalesef Cevap B Enter Tuşuna Basınız");
    Console.ReadLine();
}
Console.WriteLine("Adınız:" + ad);
Console.WriteLine("Soyadınız:" + soyad);
Console.WriteLine("Doğru Sayısı:" + dogru);
Console.WriteLine("Yanlış Sayısı:" + yanlis);
Console.WriteLine("Toplam Kazandığınız Para:" + para);
Console.Read();