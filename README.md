# KÜTÜPHANE OTOMASYONU

Kütüphane otomasyon sistemi, kütüphanedeki tüm kitap, üye ve ödünç alma işlemlerini dijital ortamda yönetmek amacıyla tasarlanmıştır. Bu, kütüphanecilere, üyelerine ve yöneticilere zaman kazandıracak ve veri kayıplarını en aza indirecektir. Sistemin temel işlevleri şunlar olacaktır.

*	Kitapların eklenmesi, güncellenmesi ve silinmesi
*	Üyelerin kaydı, güncellenmesi ve silinmesi
*	Kitap ödünç alma ve iade işlemleri
*	Kitapların stok takibi
*	Kitap ve üye verilerinin raporlanması

Bu sistemin kullanıcılara sunduğu temel faydalar şunlar olacaktır:
*	Kütüphanede bulunan kitapların düzenli takibi
*	Üyelerin ödünç alma işlemlerinin izlenmesi
*	Hızlı veri erişimi ve işlemler
•	Kütüphane yönetiminden daha verimli bir iş akışı

# PROJEDE KULLANILAN TEKNOLOJİLER: 

Microsoft Visual Studio Community 2022 (64-bit) Professional sürümünü bu linkten indirebilirsiniz. 

-> https://visualstudio.microsoft.com/tr/downloads/

MySQL Workbench veri tabanı programını bu linkten indirebilirsiniz.

-> https://dev.mysql.com/downloads/windows    


# MYSQL VERİTABANININ OLUŞTURULMASI

MySQL Workbench veri tabanı programının kurulumundan sonra “kullanıcı adı: root parola: 12345678” olarak kaydedilir. 

Program açılışında aşağıdaki yolları izleyerek “kutuphane” isminde veritabanı oluşturulur.

Ana klasörde bulunan “kutuphane.sql” dosyasını bilgisayarınıza indirip aşağıdaki yolları izleyerek programa eklenmesi gerekir.

“Administrator” bölümü ve daha sonra “Data Import/Restore” bölümlerine tıklanır.

![image](https://github.com/user-attachments/assets/b82e460d-79b3-4397-a401-9237cdb1cbdf)

Açılan pencerede numaralandırılmış yollar takip edilir. 2 numaralı bölümden indirdiğimiz “kutuphane.sql” dosyasını ekleyeceğiz. 3 numaralı bölümde veri tabanı dosyamızın ismini “kutuphane” olarak belirliyoruz. 5 numaralı bölümde de veri tabanı dosyamızı programımıza yüklüyoruz.

![image](https://github.com/user-attachments/assets/9e187ef0-8ee9-4515-aabc-5073f13ef409)

Kütüphane veri tabanının gözükmesi için sırasıyla “Schemas” ve “yenileme tuşlarına” tıklanmalıdır. 

![image](https://github.com/user-attachments/assets/59b6407e-c868-4b64-a7a2-946dddee3b98)


# VERİ TABANI TASARIMI

“kitaplar, ogrenciler, kitap_turleri ve odunc_kitaplar” olmak üzere 4 adet tablo bulunmaktadır. Tablolar birbirleriyle ilişkilendirilmiştir. Aşağıda Database Schema Dosyasının görünümü verilmiştir.

![image](https://github.com/user-attachments/assets/5461486c-62e2-4309-a97a-be14750d4e30)


# KÜTÜPHANE OTOMASYONU ARAYÜZ TASARIMI 

Bu bölüm Kütüphane Otomasyonu Arayüzünün genel taslağını içermektedir. _“Ana Form, Kitap İşlemleri, Öğrenci İşlemleri, Ödünç İşlemleri ve Tür İşlemleri bölümlerinin”_ bulunduğu sayfalarla ilgili yapılan görsel çalışmaları içermektedir.

![image](https://github.com/user-attachments/assets/7afe22a7-0ca5-47c7-b838-745bce9d9c14)


## Kitap İşlemleri Sayfasının Tasarımı

Kitap İşlemleri sayfası; kütüphanedeki kitaplar ile ilgili ekleme, silme, güncelleme, listeleme ve arama gibi işlemlerin yapılacağı sayfadır.

![image](https://github.com/user-attachments/assets/6c5ce610-ba06-4b30-bcd4-848f8e9cf24c)


## Öğrenci İşlemleri Sayfasının Tasarımı

Öğrenci İşlemleri sayfası; öğrenciler ile ilgili ekleme, silme, güncelleme, listeleme ve arama gibi işlemlerin yapılacağı sayfadır. 

![image](https://github.com/user-attachments/assets/29b1b3f3-37b5-465e-a29f-437590e0cf03)


## Kitap Tür İşlemleri Sayfasının Tasarımı

Kitap Tür İşlemleri sayfası; kitap türleri ile ilgili ekleme, silme, güncelleme, listeleme gibi işlemlerin yapılacağı sayfadır. 

![image](https://github.com/user-attachments/assets/5188d3f5-327d-4d28-94fa-d2cad81621a8)


## Ödünç Kitap İşlemleri Sayfasının Tasarımı

Ödünç Kitap İşlemleri sayfası, kütüphanedeki kitapların öğrencilere ödünç olarak verilmesi ve geri alınması işlemlerinin yapılacağı sayfadır. Ödünç kitap verme ve geri alma işlemlerinde tarih olarak, sistem tarafından o günün tarihi otomatik olarak verilecektir.

![image](https://github.com/user-attachments/assets/a0de4aac-1ec5-4527-9e27-3f83ab00a5e8)
























