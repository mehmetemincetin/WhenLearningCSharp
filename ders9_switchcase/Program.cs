int sayı;
Console.Write("GÜNE DENK GELEN SAYIYI GİRİNİZ:");
sayı = Convert.ToInt32(Console.ReadLine());

switch (sayı)
{
    case 1:Console.Write("GÜN=PAZARTESİ");
        break;
    case 2:Console.Write("Gün=Salı");
        break;
    case 3:Console.Write("Gün=Çarşamba");
        break;
    case 4:Console.Write("Gün=Perşembe");
        break;
    case 5:Console.Write("Gün=Cuma");
        break;
    case 6:Console.Write("Gün=cumartesi");
        break;
    case 7:Console.Write("Gün=pazar");
        break;
    default:Console.Write("HATALI GÜN GİRİŞİ");
        break;
}

Console.ReadLine();