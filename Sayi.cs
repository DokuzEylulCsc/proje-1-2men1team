namespace dosyadaki_hakikat
{
    abstract class Sayi
    {
        string girdi;//dosyadan veriyi string olarak alacak

        public string Girdi { get => girdi; set => girdi = value; }
        public double Deger { get; set; }
    }
}
