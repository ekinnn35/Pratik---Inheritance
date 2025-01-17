Inheritance Example Project
Proje Açıklaması
Bu proje, nesne tabanlı programlama (OOP) konseptlerinden biri olan kalıtım (inheritance) kavramını anlamak ve uygulamak amacıyla oluşturulmuştur. Proje kapsamında, temel bir BaseKisi sınıfından miras alan Ogrenci ve Ogretmen sınıfları tasarlanmıştır.

Sınıflar
BaseKisi

Ortak özellikleri ve davranışları barındırır.
Property'ler: Ad, Soyad.
Metotlar: AdSoyadYazdir().
Ogrenci

BaseKisi sınıfından türetilmiştir.
Ek Property: OgrenciNo.
Metotlar: OgrenciBilgiYazdir() — Öğrenci bilgilerini ekrana yazdırır.
Ogretmen

BaseKisi sınıfından türetilmiştir.
Ek Property: Maas.
Metotlar: OgretmenBilgiYazdir() — Öğretmen bilgilerini ekrana yazdırır.
Proje Yapısı
Proje aşağıdaki dosya ve klasörlerden oluşur:

bash
Kopyala
Düzenle
InheritanceExample/
│
├── BaseKisi.cs        # Temel sınıf, ad ve soyad özelliklerini içerir.
├── Ogrenci.cs         # Öğrenci sınıfı, öğrenci numarası ve ek metot içerir.
├── Ogretmen.cs        # Öğretmen sınıfı, maaş bilgisi ve ek metot içerir.
└── Program.cs         # Ana program dosyası, örnek nesneler oluşturur ve çalıştırır.
Nasıl Çalıştırılır?
Projeyi bir C# geliştirme ortamında (örneğin, Visual Studio veya Rider) açın.
Tüm dosyaların aynı namespace (InheritanceExample) içinde olduğundan emin olun.
Program.cs dosyasını çalıştırın.
Konsol ekranında aşağıdaki gibi bir çıktı göreceksiniz:

Kullanılan Kavramlar
Inheritance (Kalıtım): Ogrenci ve Ogretmen, BaseKisi sınıfından miras alır.
Encapsulation (Kapsülleme): Özellikler (Ad, Soyad, vb.) ve metotlar, sınıf düzeyinde kapsüllenir.
Polymorphism (Çok Biçimlilik): Bir sınıfın, kalıtım yoluyla genişletilmesi ve metotların farklı şekillerde kullanılması sağlanır.
Geliştirme Ortamı
Dil: C#
Platform: .NET Framework veya .NET Core
IDE: Visual Studio 2022 (veya benzeri bir C# geliştirme aracı)
Katkıda Bulunma
Eğer projeyi geliştirmek veya genişletmek isterseniz:

Fork yapın.
Yeni özellikler ekleyin veya mevcut kodu iyileştirin.
Pull Request gönderin.
