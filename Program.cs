Ogrenci ogrenci = new Ogrenci();
ogrenci.Isim = " Ayşe";
ogrenci.Soyisim =" Yılmaz";
ogrenci.Ogrencino = 293;
ogrenci.Sinif = 3;
ogrenci.OgrenciBilgileriniGetir();

ogrenci.SinifAtlat();
ogrenci.OgrenciBilgileriniGetir();

Ogrenci ogrenci1 = new Ogrenci("Deniz", "Arda", 256, 1);
ogrenci1.SinifDüşür();
ogrenci1.SinifDüşür();
ogrenci1.OgrenciBilgileriniGetir();







class Ogrenci
{
    private string isim;
    private string soyisim;

    private int ogrencino;
    private int sinif;

    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int Ogrencino { get => ogrencino; set => ogrencino = value; }
    public int Sinif
     {
         get => sinif; 
         set 
         {
            if (value<1)
            {
            System.Console.WriteLine("Sınıf En Az 1 Olabilir!");
            sinif = 1;
            }
            else
            {
                sinif=value;
            }
         }  
        
     }
    public Ogrenci(string isim, string soyisim, int ogrencino, int sinif)
    {
        Isim = isim;
        Soyisim = soyisim;
        Ogrencino = ogrencino;
        Sinif = sinif;
    }
    public Ogrenci (){}

    public void OgrenciBilgileriniGetir()
    {
        System.Console.WriteLine("******** Öğrenci Bilgileri *********");
        System.Console.WriteLine("Öğrenci Adi      :{0}", this.Isim);
        System.Console.WriteLine("Öğrenci SoyAdı   :{0}", this.Soyisim);
        System.Console.WriteLine("Öğrenci No       :{0}", this.Ogrencino);
        System.Console.WriteLine("Öğrenci Sınıfı   :{0}", this.Sinif);
    } 
    public void SinifAtlat()
    {
        this.Sinif= this.Sinif + 1;
    }
    public void SinifDüşür()
    {
        this.Sinif = this.Sinif - 1;
    }



}