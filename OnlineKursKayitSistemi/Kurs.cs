using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursKayitSistemi
{
    internal class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }

        private int _izlenmeOrani; // Property'nin arkasındaki field (değişken)
        public int IzlenmeOranı
        {
            get { return _izlenmeOrani; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _izlenmeOrani = value;
                }
                else
                {
                    Console.WriteLine("Hata: İzlenme oranı 0-100 arasında olmalıdır!");
                }
            }
        }

        private double _fiyat;
        public double Fiyat
        {
            get { return _fiyat; }
            set
            {
                if(value >= 0)
                {
                    _fiyat = value;
                }
                else
                {
                    Console.WriteLine("Hata: Fiyat negatif olamaz!");
                }
            }
        }
        public Kurs()
        {
            KursAdi = "Kurs İsmi";
            Egitmen = "Eğitmen İsmi";
            IzlenmeOranı = 0;
            Fiyat = 0;
        }

        public Kurs(string kursAdi, string egitmen, int izlenmeOrani, double fiyat)
        {
            KursAdi = kursAdi;
            Egitmen = egitmen;
            IzlenmeOranı = izlenmeOrani;
            Fiyat = fiyat;
        }

        public void BilgileriGoster()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Kurs Adı: {0}", KursAdi);
            Console.WriteLine("Eğitmen: {0}", Egitmen);
            Console.WriteLine("İzlenme Oranı: {0}", IzlenmeOranı);
            Console.WriteLine("Fiyat: {0}", Fiyat);
            Console.WriteLine("--------------------");
        }
    }
}




