class emlak
{
    private string semt;
    private string renk;
    private int odasayısı;
    private int katno;
    private double alan;


    public string Semti
    {
        get { return semt; }
        set { semt = value.ToUpper(); }
    }
    public string Rengi
    {
        get { return renk; }
        set { renk = value.ToLower(); }
    }
    public int Odasayisi
    {
        get { return odasayısı; }
        set { odasayısı = Math.Abs(value); }
    }
    public int Katnumara
    {
        get { return katno; }
        set { katno = Math.Abs(value); }
    }
    public double Alan
    {
        get { return alan; }
        set { alan = Math.Abs(value); }
    }

}