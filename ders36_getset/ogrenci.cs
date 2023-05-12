class öğrenci
{
    private string ad;
    private string soyad;
    private int yas;
    private string alan;



    public string ADİ
    {
        get { return ad; }
        set { ad = value; }
    }
    public string SOYADİ
    {
        get { return soyad; }
        set { soyad = value; }
    }
    public string ALANI
    {
        get { return alan; }
        set { alan = value; }
    }
    public int YASI
    {
        get { return yas; }
        set
        {
            if (value < 18)
            {
                yas = 18;
            }
            else
            {
                yas = value;
            }
        }


    }













}
