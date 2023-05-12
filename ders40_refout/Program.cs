static void herhangi(out int s)
{
    s = 12;
    s++;
}
int a;
herhangi(out a);
Console.Write(a);
Console.Read();