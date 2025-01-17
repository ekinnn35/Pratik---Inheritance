using System;

namespace InheritanceExample
{
    public class Ogrenci : BaseKisi
    {
        public int OgrenciNo { get; set; }

        public void OgrenciBilgiYazdir()
        {
            // Base sınıfın metodunu çağırıyoruz
            AdSoyadYazdir();
            Console.WriteLine($"Öğrenci Numarası: {OgrenciNo}");
        }
    }
}
