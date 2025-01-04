namespace KursKayitSistemi
{
    internal class Ogrenci
    {
        public string OgrenciAdi { get; set; }
        public int OgrenciNo { get; set; }
        public List<Kurs> KayitliKurslar { get; set; }

        public Ogrenci()
        {
            OgrenciAdi = "Öğrenci İsmi";
            OgrenciNo = 156;
            KayitliKurslar = new List<Kurs>();
        }

        public Ogrenci(string ogrenciAdi, int ogrenciNo)
        {
            OgrenciAdi = ogrenciAdi;
            OgrenciNo = ogrenciNo;
            KayitliKurslar = new List<Kurs>();
        }
        public void KursEkle(Kurs kurs)
        {
            KayitliKurslar.Add(kurs);
        }
        public void KursListele()
        {
            Console.WriteLine($"Öğrenci Adı: {OgrenciAdi}");
            Console.WriteLine($"Öğrenci No: {OgrenciNo}");
            Console.WriteLine("Kayıtlı Kurslar:");
            foreach (var kurs in KayitliKurslar)
            {
                kurs.BilgileriGoster();
            }
        }

       
    }


    

}
