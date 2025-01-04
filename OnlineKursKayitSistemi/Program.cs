using KursKayitSistemi;

{
    KayitSistemi kayitSistemi = new KayitSistemi();

    //Kurs Oluşturma
    kayitSistemi.kurslar.Add(new Kurs("Programlamaya Başlangıç", "Phobos", 0, 500));
    kayitSistemi.kurslar.Add(new Kurs("C# Başlangıç", "Phorion", 0, 500));
    kayitSistemi.kurslar.Add(new Kurs("İleri Seviye Matematik", "Phobos", 0, 250));

    while (true)
    {
        //Menü gösterimi
        Console.WriteLine("Kurs Kayıt Sistemi\n");
        Console.WriteLine("1. Öğrenci Kaydet");
        Console.WriteLine("2. Öğrenciye Kurs Ata");
        Console.WriteLine("3. Öğrencinin Kurslarını Listele");
        Console.WriteLine("4. Kursları Listele");
        Console.WriteLine("5. Çıkış");
        Console.WriteLine("\nYapmak istediğiniz işlemi seçin:");

        string secim = Console.ReadLine(); //Kullanıcıdan seçim alma

        switch (secim)
        {
            case "1":
                kayitSistemi.ogrenciler.Add(kayitSistemi.OgrenciKayit());
                break;
                
            case "2":
                Console.WriteLine("Öğrenci No: ");
                if (int.TryParse(Console.ReadLine(), out int ogrenciNo))
                {
                    kayitSistemi.KursKayit(ogrenciNo);
                }
                else
                {
                    Console.WriteLine("Geçersiz öğrenci Numarası.");
                }
                break;
                
            case "3":
                kayitSistemi.OgrenciKurslariniListele();
                break;
                
            case "4":
                kayitSistemi.KurslariListele();
                break;
                
            case "5":
                Environment.Exit(0); //Programdan Çık
                break;
            default:
                Console.WriteLine("Geçersiz Seçim.");
                break;
        }
        Console.WriteLine("\nDevam etmek için bir tuşa basın...");
        Console.ReadKey();
        Console.Clear();
    }
    //Kursları Listeleme
    kayitSistemi.KurslariListele();

    //Öğrenci Kaydı
    Ogrenci yeniOgrenci = kayitSistemi.OgrenciKayit();
    kayitSistemi.ogrenciler.Add(yeniOgrenci);

    //Kursa Öğrenci Kaydetme
    kayitSistemi.KursKayit(yeniOgrenci.OgrenciNo);
    
    kayitSistemi.KurslariListele();

    //Öğrenci kursları listeleme
    kayitSistemi.OgrenciKurslariniListele();
    kayitSistemi.OgrenciKurslariniListele();
    Console.ReadKey();

}