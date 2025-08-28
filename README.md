# Büyük Verilerle Çalışmak

Bu proje, C# ve SQL Server kullanarak büyük verilerle çalışmayı gösteren bir masaüstü uygulamasıdır. Proje, bir `Kisi` (Kişi) nesnesini kullanarak temel CRUD (Create, Read, Update, Delete) operasyonlarını gerçekleştiren katmanlı bir mimari yapıya sahiptir.

## Proje Yapısı

Proje, veritabanı, iş mantığı ve sunum katmanlarını ayırmak için katmanlı bir mimari kullanır:

- **Entities**: Veritabanı tablolarını temsil eden sınıfları (`Kisi.cs`) içerir.
- **DataAccessLayer**: Veritabanı bağlantılarını ve sorgularını yönetir (`DataAccessLayer.cs`). SQL enjeksiyonu gibi güvenlik açıklarını önlemek için parametreli sorgular kullanılır.
- **BusinessLogicLayer**: İş kurallarını ve operasyonları içerir, `DataAccessLayer` ile iletişim kurar (`BusinessLogicLayer.cs`).
- **Presentation Layer (Form1.cs)**: Kullanıcı arayüzünü ve kullanıcı girdilerini yönetir.

## Özellikler

- **Veri Ekleme**: Kullanıcı bilgileri (İsim, Soyisim, E-posta, Telefon ve Resim) veritabanına kaydedilir.
- **Veri Listeleme**: Veritabanındaki kişiler bir `ComboBox`'ta listelenir.
- **Detay Görüntüleme**: `ComboBox`'tan bir kişi seçildiğinde, detayları otomatik olarak ilgili alanlara yüklenir.
- **Stored Procedure Kullanımı**: Veri ekleme işlemi için stored procedure (`KisiEkle`) kullanılır.

## Teknolojiler

- **Programlama Dili**: C#
- **Veritabanı**: SQL Server
- **IDE**: Visual Studio
- **Kullanılan Kütüphaneler**: System.Data.SqlClient, System.IO, System.Windows.Forms

## Kurulum ve Çalıştırma

1.  Proje dosyalarını yerel makinenize klonlayın.
2.  Visual Studio'da projeyi açın.
3.  `DataAccessLayer.cs` dosyasındaki SQL Server bağlantı dizgesini (`SqlConnection`) kendi sunucu bilgilerinize göre güncelleyin.
    `Data Source=ABDULLAH\\SQLEXPRESS01;Initial Catalog=BuyukDatalarIleCalismak;Integrated Security=True;`
4.  Projede kullanılan veritabanı tablosunu ve stored procedure'u SQL Server'ınızda oluşturun. (`KisiEkle` adında bir stored procedure'a ihtiyacınız olacaktır.)
5.  Projenizi derleyin ve çalıştırın.



---