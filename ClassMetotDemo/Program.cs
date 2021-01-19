using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Musteri_Id = 456;
            musteri1.Musteri_Adi = "Müyesser";
            musteri1.Musteri_SoyAdi = "Cançelik";
            musteri1.Musteri_Birimi = "Bilgi İşlem Daire Başkanlığı";

            Musteri musteri2 = new Musteri();
            musteri2.Musteri_Id = 789;
            musteri2.Musteri_Adi = "Pınar";
            musteri2.Musteri_SoyAdi = "Kozanoğlu";
            musteri2.Musteri_Birimi = "Genel Sekreterlik";

            Musteri musteri3 = new Musteri();
            musteri3.Musteri_Id = 157;
            musteri3.Musteri_Adi = "Hasan";
            musteri3.Musteri_SoyAdi = "Yıldız";
            musteri3.Musteri_Birimi = "İnsan Kaynakları";

            Console.WriteLine("------------------------EKLEME---------------------------------");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Musteri_Ekleme(musteri1);
            musteriManager.Musteri_Ekleme(musteri2);
            musteriManager.Musteri_Ekleme(musteri3);

            Console.WriteLine("-----------------------GÜNCELLEME----------------------------------");

            musteriManager.Musteri_Guncelleme(musteri1);
            musteriManager.Musteri_Guncelleme(musteri2);
            musteriManager.Musteri_Guncelleme(musteri3);

            Console.WriteLine("---------------------SİLME------------------------------------");

            musteriManager.Musteri_Silme(musteri1);
            musteriManager.Musteri_Silme(musteri2);
            musteriManager.Musteri_Silme(musteri3);
        }
    }

    class Musteri
    {
        public int Musteri_Id { get; set; }
        public string Musteri_Adi { get; set; }
        public string Musteri_SoyAdi { get; set; }
        public string Musteri_Birimi { get; set; }
    }

    class MusteriManager
    {
        public void Musteri_Ekleme(Musteri musteri)
        {
            Console.WriteLine("Şirkete yeni bir kullanıcı eklendi: " + musteri.Musteri_Id + " " + musteri.Musteri_Adi + " " + musteri.Musteri_SoyAdi + " " + musteri.Musteri_Birimi);
        }
        public void Musteri_Guncelleme(Musteri musteri)
        {
            Console.WriteLine("Kullanıcı güncellendi: " + musteri.Musteri_Id + " " + musteri.Musteri_Adi + " " + musteri.Musteri_SoyAdi + " " + musteri.Musteri_Birimi);
        }
        public void Musteri_Silme(Musteri musteri)
        {
            Console.WriteLine("Kullanıcı silindi: " + musteri.Musteri_Id + " " + musteri.Musteri_Adi + " " + musteri.Musteri_SoyAdi + " " + musteri.Musteri_Birimi);
        }
    }

}
