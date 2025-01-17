using System;

namespace InheritanceExample
{
    public class BaseKisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public void AdSoyadYazdir()
        {
            Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}");
        }
    }
}
