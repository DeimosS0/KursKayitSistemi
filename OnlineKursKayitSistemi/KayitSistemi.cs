using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursKayitSistemi
{
    internal class KayitSistemi
    {
        public List<Kurs> kurslar = new List<Kurs>(); // Tüm kursları tutmak için
        public List<Ogrenci> ogrenciler = new List<Ogrenci>();

        public void KurslariListele()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Sistemdeki Kurslar:");
            Console.WriteLine("--------------------");
            foreach (var kurs in kurslar)
            {
                kurs.BilgileriGoster();
                Console.WriteLine(); //Boş satır
            }
        }

        public Ogrenci OgrenciKayit()
        {
            Console.Write("Öğrenci Adı: ");
            string ogrenciAdi = Console.ReadLine();

            if (ogrenciAdi == null)
            {
                ogrenciAdi = "Bilinmiyor";
            }

            //Otomatik öğrenci numarası oluşturma 
            int ogrenciNo = ogrenciler.Count + 1;

            Console.WriteLine("Tebrikler! Kaydınız oluşturuldu.");
            Console.WriteLine($"Size atanan Öğrenci No: {ogrenciNo}"); //Atanan numarayı göster
            Console.WriteLine(); //Boş satır
         
            return new Ogrenci(ogrenciAdi, ogrenciNo);
        }
         public void KursKayit(int ogrenciNo)
        {
            Ogrenci ogrenci = ogrenciler.Find(o => o.OgrenciNo == ogrenciNo);
            if (ogrenci == null)
            {
                Console.WriteLine("Öğrenci sistemde kayıtlı değil!");
                return;
            }  
            KurslariListele(); //Kayıtlı kursları listeleme

            Console.WriteLine("Kurs Adı: ");
            string kursAdi = Console.ReadLine();

            Kurs kurs = kurslar.Find(k => k.KursAdi == kursAdi);

            if (kurs == null)
            {
                Console.WriteLine("Kurs bulunamadı!");
                return;
            }

            ogrenci.KursEkle(kurs);
            KurslariListele();
            Console.WriteLine($"{ogrenci.OgrenciAdi} adlı öğrenci {kurs.KursAdi} kursuna kaydedildi");
            Console.WriteLine();
        }

        public void OgrenciKurslariniListele()
        {
            Console.WriteLine("Öğrenci No: ");
            int ogrenciNo = Convert.ToInt32(Console.ReadLine());

            Ogrenci ogrenci = ogrenciler.Find(o => o.OgrenciNo == ogrenciNo);
            if(ogrenci == null)
            {
                Console.WriteLine("Öğrenci bulunamadı!");
                return;
            }
            ogrenci.KursListele();
        }
    }

}
