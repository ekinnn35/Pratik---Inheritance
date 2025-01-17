using System;

namespace InheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Öğrenci nesnesi oluşturma ve değer atama
            Ogrenci ogrenci = new Ogrenci
            {
                Ad = "Ali",
                Soyad = "Yılmaz",
                OgrenciNo = 12345
            };

            // Öğrenci bilgilerini yazdırma
            Console.WriteLine("Öğrenci Bilgileri:");
            ogrenci.OgrenciBilgiYazdir();

            Console.WriteLine();

            // Öğretmen nesnesi oluşturma ve değer atama
            Ogretmen ogretmen = new Ogretmen
            {
                Ad = "Ajda",
                Soyad = "Pekkan",
                Maas = 7500.50m
            };

            // Öğretmen bilgilerini yazdırma
            Console.WriteLine("Öğretmen Bilgileri:");
            ogretmen.OgretmenBilgiYazdir();
        }
    }
}
