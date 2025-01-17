using System;

namespace InheritanceExample
{
    public class Ogretmen : BaseKisi
    {
        public decimal Maas { get; set; }

        public void OgretmenBilgiYazdir()
        {
            // Base sınıfın metodunu çağırıyoruz
            AdSoyadYazdir();
            Console.WriteLine($"Maaş: {Maas:C}");
        }
    }
}
