# Traversal Seyahat Projesi

##  Genel Bakış

🌍 Bu projede bir seyahat şirketinin işleyişi web site tasarımı, admin paneli ve kullanıcı paneli üzerinden gerçekleştirildi. Vitrin sayfası ile kullanıcılara etkileyici bir web site tasarımı sunuldu. Kullanıcı paneli ile kullanıcıların rezervasyon oluşturma, rezervasyon bilgilerine ulaşma, profil bilgilerini güncelleme gibi bir çok özellik eklendi. Admin tarafında web site yönetimini, kullanıcı yönetimini sağlamak amacıyla kapsamlı bir admin paneli oluşturuldu.

### ✨ [Web Site](#-web-site-1)

 **🏠 Anasayfa**:  Kullanıcılara tur rotaları listelenir. Referansların yorumları görüntülenir.

 **ℹ️ Hakkımızda**:  Web site hakkında açıklamalar bulunur.

 **🗺️ Rotalar**:  Tur rotaları listelenir. Seçilen tur rotasına ait bir blog yazısı ve yorumlar görüntülenir.  
  ➕ **Yorum ekleme özelliği eklendi.**

 **👨‍💼 Rehberlerimiz**:  Tur rotalarının rehberleri listelenir.

 **📩 İletişim**:  Mesaj bırakma özelliği eklendi.

 **✉️ Abone Ol**:  Mail bültenine abone olmak isteyen kullanıcıların mail adresleri kaydedilir.

### 🌞 [Kullanıcı Paneli](#-kullanıcı-paneli-1)

 **📊 Dashboard**:   Kullanıcı, web site ve kendi profil istatistiklerini görebilir.  
  ➕ Son eklenen tur rotaları hakkında bilgi alabilir.  
  ➕ Rehber ve tur bilgilerini görsel yönü güçlü bir tasarımla görüntüler.

 **🌐 Menü Dili Değiştirme**:   Kullanıcı, menü dilini Türkçe/İngilizce/Fransızca olarak değiştirebilir.

 **👤 Profilim** :  Kullanıcı bilgilerini güncelleyebilir. Profil fotoğrafı yükleyebilir.

 **📋 Aktif Rezervasyonlar**:  Kullanıcının aktif rezervasyonları listelenir.

 **📜 Geçmiş Rezervasyonlar**:   Kullanıcının daha önce yaptığı rezervasyonları listelenir.

 **⏳ Onay Bekleyen Rezervasyonlar**:   Kullanıcının admin tarafından onaylanması beklenen rezervasyonları listelenir.

 **🆕 Yeni Rezervasyonlar**:   Kullanıcı, aktif olan tur rotalarına yeni rezervasyon yapabilir.

 **💬 Yorumlarım**:   Kullanıcının tur rotalarına yaptığı yorumlar listelenir ve güncellenebilir.

 **🔍 Tur Rotaları**:   Tur rotaları listelenir ve kullanıcı dilediği rotayı arayabilir.

 **🔗 Siteye Git**:   Web sitesine geri dönebilir.  
  ➖ **Çıkış Yap** ile panelden çıkabilir.

### 🔑 [Admin Paneli](#-admin-paneli-1)

 **📊 Dashboard**:  Admini bir kontrol paneli karşılar.

 **🗺️ Rotalar**:  Tur rotaları eklenebilir, silinebilir veya güncellenebilir.

 **💬 Yorumlar**:  Kullanıcıların bloglara yaptığı yorumlar görüntülenir ve silinebilir.

 **👥 Misafirler**:  Kullanıcılar listelenir. Bilgileri güncellenebilir, yaptıkları yorumlar ve rezervasyon geçmişi görüntülenebilir.

 **📩 Mesajlar**:   Web sitesindeki iletişim alanından gelen mesajlar listelenir.

 **👨‍💼 Rehberler**:  Rehber bilgileri güncellenebilir.

 **✨ Öne Çıkanlar**:   Web sitesindeki öne çıkan rotalar güncellenebilir.

 **📋 Referanslar**:    Referans ekleme ve güncelleme işlemleri yapılabilir.

 **📣 Duyurular**:   Kullanıcılara duyurular oluşturulabilir.

 **📋 Rezervasyonlar**: Kullanıcıların rezervasyon durumu güncellenebilir ve yeni rezervasyonlar eklenebilir.

 **✉️ Mail Gönder**:  Kullanıcılara mail gönderilebilir.

 **⚙️ Rol İşlemleri**:    Kullanıcılara ve adminlere rol atanabilir. Roller güncellenebilir.

 **⚡ Hızlı İşlemler**:  Ajax kullanılarak tur rotaları üzerinde ekle/sil/listele/güncelle işlemleri yapılabilir.

 **📊 Excel / Pdf Raporları**:   Tur rotaları ve kullanıcı bilgileri Excel veya PDF formatında indirilebilir.

 **🚪 Çıkış Yap**:    Admin panelinden çıkış yapılabilir.

 [**📈 SignalR Kullanımı**](#-signalr-kullanımı):  Random değerlerle web site ziyaretçi sayısı anlık olarak güncellendi.

###  📝 Kayıt Ol ve Giriş Yap Sayfaları

**🔐 Kayıt Ol**:   Kullanıcı bilgileri Validation Rules(Doğrulama Kuralları) uygulanarak veri tabanına kayıt edilir.

**🔑 Giriş Yap**: Kayıt olan kullanıcı bilgilerini girerek Misafir Paneline giriş yapar.

![SİGNUP](https://github.com/user-attachments/assets/ba1002db-b2b9-424e-8ebd-b098ce1098ea)
![signin](https://github.com/user-attachments/assets/26377731-9dd5-4538-b1e5-f417bdbcb155)


### 🔒 Şifremi Unuttum / Şifre Güncelleme İşlemleri

♻️ Kullanıcının mail adresine şifre yenileme linki gönderilir. Bu link üzerinden kullanıcı şifresini yenileyebilir.

![şifre1](https://github.com/user-attachments/assets/fad44e86-04cc-4853-b339-9b86292f3c78)
![şifre2](https://github.com/user-attachments/assets/50da0cfe-dd52-45da-9dd7-ccb5ed4dc48a)
![şifre3](https://github.com/user-attachments/assets/b9737925-cc81-4829-9958-49b540b18312)


### 📂 Veri Tabanı

![sql](https://github.com/user-attachments/assets/65162b2f-5f9a-4d08-88f5-50969e5f280e)


### ✨ Web Site

![default1](https://github.com/user-attachments/assets/154d524b-9f56-49ea-9c2a-d2d26a49650c)
![default2](https://github.com/user-attachments/assets/311e47ad-e93f-44fb-87fd-f88eedb0c30e)
![default3](https://github.com/user-attachments/assets/ca247099-1eed-4d92-9d8e-7acbeb0c993e)
![default4](https://github.com/user-attachments/assets/9c2eae59-bb06-4246-b452-99a6531a2894)
![default5](https://github.com/user-attachments/assets/85e4aa8e-0622-483e-849e-eb8c38e54acc)
![default6](https://github.com/user-attachments/assets/06ec2c1e-faa1-4e0e-b189-4c45162fd1c3)

### 🌞 Kullanıcı Paneli
![member1](https://github.com/user-attachments/assets/e8e8beb5-931c-4ae3-aff4-e7a9801de296)
![member2](https://github.com/user-attachments/assets/2cdf333b-b813-4c61-83b0-2ee28ef6d478)
![member3](https://github.com/user-attachments/assets/223689e0-414d-4451-be5c-d48b6631fa1a)
![member4](https://github.com/user-attachments/assets/6ae6ddf6-54f1-40a9-a463-04295bf7271c)
![member5](https://github.com/user-attachments/assets/0375a34f-7d06-4452-bf1f-3178597b543f)
![member6](https://github.com/user-attachments/assets/0f1c0b52-4c24-48b0-8ec7-eb2498e52b07)
![member7](https://github.com/user-attachments/assets/d8241077-bf8d-492f-abe7-388c480cea3e)
![member8](https://github.com/user-attachments/assets/83b09cfc-a559-43f5-8035-514c6d60b466)

### 🔑 Admin Paneli

![admin1](https://github.com/user-attachments/assets/63697703-4b8d-4700-bc06-a8e7235822f9)
![admin2](https://github.com/user-attachments/assets/80684185-f528-4ad5-b9af-5fa73d263dba)
![admin3](https://github.com/user-attachments/assets/d8beb256-9c06-478d-85e6-4ab42db73bcc)
![admin4](https://github.com/user-attachments/assets/59e23695-bf26-4c47-9f31-34dec44349a3)
![admin5](https://github.com/user-attachments/assets/2e516877-674f-4afb-8296-2dd4c6c0ae27)
![admin6](https://github.com/user-attachments/assets/f813b245-7e35-47a8-a5cc-5b2a07e5203a)
![admin7](https://github.com/user-attachments/assets/2a261321-707b-4f28-bde7-1f8f08d1ae0e)
![admin8](https://github.com/user-attachments/assets/8385b679-a55f-45eb-9e51-33ffcde7fd63)
![admin9](https://github.com/user-attachments/assets/b31bb004-26c1-4af0-bc92-f12b5481708d)
![admin10](https://github.com/user-attachments/assets/9b733c0b-5284-4fd0-968c-0d8ad87466b9)
![admin11](https://github.com/user-attachments/assets/e6908499-d747-4162-9626-37ca06727956)
![admin12](https://github.com/user-attachments/assets/9981e50d-6d44-4af4-b789-4080256e16ee)
![admin13](https://github.com/user-attachments/assets/8fe55ee6-a1d2-4eb5-a0cf-8c371744e790)
![admin14](https://github.com/user-attachments/assets/3638490b-b421-4604-8054-9b3cbc21253a)
![admin15](https://github.com/user-attachments/assets/0beb8bd3-8d2f-4dc2-9c6f-a058c04dfef2)
![admin16](https://github.com/user-attachments/assets/7c6beec6-b5e7-4072-a3de-e964ecf7cb36)
![admin17](https://github.com/user-attachments/assets/076c5cf6-7816-4d48-9af4-661230551312)
![admin18](https://github.com/user-attachments/assets/8accfaf6-cad3-45be-8a9b-d1a1d733acc4)
![admin18-1](https://github.com/user-attachments/assets/550e16f6-5e8a-45f4-8ff0-e29d661f0b76)
![admin18-2](https://github.com/user-attachments/assets/fda7a0d3-d44a-4e98-9b04-e08cf2869f04)
![admin19](https://github.com/user-attachments/assets/dd36e06f-655b-416e-896a-754cf3b673f9)
![admin20](https://github.com/user-attachments/assets/55de5368-04ec-4772-9557-8959b6499f54)
![admin21](https://github.com/user-attachments/assets/0383d3d4-f68e-462f-bf4f-bfd393d4716e)
![admin22](https://github.com/user-attachments/assets/c401e3b0-0545-4036-ace6-4e39d3c0a091)
![admin23](https://github.com/user-attachments/assets/0d486cf8-9789-4a38-9661-20c76a6ca3e9)
![admin24](https://github.com/user-attachments/assets/77c5075b-92da-47c2-8cec-f5335827c08d)
![admin25](https://github.com/user-attachments/assets/ba389ffe-6100-40cb-9f67-b5d402bd5a8c)
![statikexcel](https://github.com/user-attachments/assets/904c1a0e-652a-4001-97c0-eaed7d1998a0)
![statikpdf](https://github.com/user-attachments/assets/2c27a136-a3f5-425a-9137-b16cbaf248aa)


### 📈 SignalR Kullanımı

https://github.com/user-attachments/assets/86e9a704-20c5-415d-a43a-b7d76a177552

![signalRss](https://github.com/user-attachments/assets/60970d86-f67a-4c9f-816d-d90bdfbcffcf)































