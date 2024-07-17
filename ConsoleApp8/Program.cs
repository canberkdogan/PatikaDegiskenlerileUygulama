using System;

class Program
{
    static void Main(string[] args)
    {
        // Kullanıcıdan bilgileri al
        Console.Write("T.C. Kimlik Numarası:");
        string tcKimlikNo = Console.ReadLine();

        Console.Write("Adı:");
        string ad = Console.ReadLine();

        Console.Write("Soyadı:");
        string soyad = Console.ReadLine();

        Console.Write("Telefon Numarası:");
        string telefon = Console.ReadLine();

        Console.Write("Yaş:");
        string yas = Console.ReadLine();

        Console.Write("İlk Aldığı Ürünün Fiyatı:");
        decimal ilkUrunFiyati = Convert.ToDecimal(Console.ReadLine()); // para birimi küsuratlı olma ihitmali nedeniyle decimal kullandım



        Console.Write("İkinci Aldığı Ürünün Fiyatı:");
        decimal ikinciUrunFiyati = Convert.ToDecimal(Console.ReadLine());

        // Toplam harcama hesapla
        decimal toplamHarcama = ilkUrunFiyati + ikinciUrunFiyati;

        // Patika puanı hesapla
        decimal patikaPuan = toplamHarcama * 0.10m;

        // Bilgileri yan yana düzenle
        Console.WriteLine($"-----------------------");
        Console.WriteLine($"{tcKimlikNo} tc numaralı {ad} {soyad} isimli kişi için kayıt oluşturulmuştur.");
        Console.WriteLine($"{telefon} numarasına bildirim mesajı gönderilmiştir.");
        Console.WriteLine($"{toplamHarcama} toplam harcama karşılığı kazanılan %10 patika puan miktarı -> {patikaPuan} TL'dir.");






        // Bilgileri ekrana yazdır
        Console.Write("\nKullanıcı Bilgileri:");
        Console.Write("bilgiler");
    }
}