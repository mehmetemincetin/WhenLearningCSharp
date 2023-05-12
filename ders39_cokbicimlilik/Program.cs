class insan

    {
        public virtual void selamver()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Title = "ölürüm türkiyem";
            Console.WriteLine("GÜNLER GEÇMEZ Mİ BENSİZ");
        }
    }
    class türk : insan
    {
        public override void selamver()
        {
            Console.Write("Esenlikler");
        }
    }


türk trk = new türk();
trk.selamver();
Console.Read();
