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

![signUp](https://github.com/user-attachments/assets/98d9a435-d976-436e-a690-15fe1f72680e)
![signin](https://github.com/user-attachments/assets/42127918-3be1-41c3-b54e-f23bbf4537ce)


### 🔒 Şifremi Unuttum / Şifre Güncelleme İşlemleri

♻️ Kullanıcının mail adresine şifre yenileme linki gönderilir. Bu link üzerinden kullanıcı şifresini yenileyebilir.

![şifre1](https://github.com/user-attachments/assets/fad44e86-04cc-4853-b339-9b86292f3c78)
![şifre2](https://github.com/user-attachments/assets/50da0cfe-dd52-45da-9dd7-ccb5ed4dc48a)
![şifre3](https://github.com/user-attachments/assets/b9737925-cc81-4829-9958-49b540b18312)


### 🚀 Kullanılan Teknolojiler

<table>
  <tr>
    <td>🎉 Asp.Net Core (5.0) ile hazırlanmıştır.</td>
    <td>📘 Repository Design Pattern kullanıldı.</td>
  </tr>
  <tr>
    <td>📚 Entity Framework kullanılmıştır.</td>
    <td>🔨 CodeFirst yaklaşımı uygulanmıştır.</td>
  </tr>
  <tr>
    <td>🏢 N Katmanlı Mimari ile oluşturuldu.</td>
    <td>🏗️ DTO Layer kullanıldı.</td>
  </tr>
  <tr>
    <td>💾 MSSQL veri tabanı kullanılmıştır.</td>
    <td>📈 CRUD işlemleri yapılmıştır.</td>
  </tr>
  <tr>
    <td>📖 LINQ sorguları kullanıldı.</td>
    <td>⚙️ Validation Rules uygulandı.</td>
  </tr>
  <tr>
    <td>⚠️ API Kullanımı mevcuttur.</td>
    <td>📋 SignalR ile gerçek zamanlı iletişim sağlandı.</td>
  </tr>
  <tr>
    <td>📝 Data Annotations kullanıldı.</td>
    <td>📂 Mapper entegrasyonu yapıldı.</td>
  </tr>
  <tr>
    <td>🔑 Çoklu Dil Desteği sağlandı.</td>
    <td>🔐 CQRS ve UnitOfWork Design Pattern eklendi.</td>
  </tr>
  <tr>
    <td>📧 Mail Gönderimi & Şifremi Unuttum İşlemleri yapılmıştır.</td>
    <td>🔐 Authentication ve Authorize işlemleri entegre edildi.</td>
  </tr>
</table>


### 📂 Veri Tabanı

![sql](https://github.com/user-attachments/assets/65162b2f-5f9a-4d08-88f5-50969e5f280e)


### ✨ Web Site
![default1](https://github.com/user-attachments/assets/ad7671f0-7417-41c1-b3ea-0cfd825d0ae3)
![default2](https://github.com/user-attachments/assets/5629a2e5-a2a8-47fa-8b24-0f88f4c43951)
![default3](https://github.com/user-attachments/assets/cd3459b4-d855-4ee4-b435-7ea752612b0e)
![default4](https://github.com/user-attachments/assets/84ff44b9-6303-4efe-9c75-cc87d41e90d1)
![default5](https://github.com/user-attachments/assets/8ef1661b-350c-45a5-b17f-c894ce7bd664)
![default6](https://github.com/user-attachments/assets/a6522069-1ece-407f-912e-c928f150ab46)



### 🌞 Kullanıcı Paneli
![member1](https://github.com/user-attachments/assets/add68239-8c14-47eb-a91b-ccafb65eda73)
![member2](https://github.com/user-attachments/assets/1dfbaa0f-dca0-42c0-b811-0a3843e8b01e)
![member3](https://github.com/user-attachments/assets/07f333ff-0cc9-402f-a309-05164b2643be)
![member4](https://github.com/user-attachments/assets/7477698b-3ba9-4577-9840-462b9cccc08b)
![member5](https://github.com/user-attachments/assets/e9d7b07f-172f-451e-8f4e-d9277c2c7a24)
![member6](https://github.com/user-attachments/assets/f22ac041-dd94-41ea-8cee-1f8ebee59f7c)
![member7](https://github.com/user-attachments/assets/87067802-18db-443a-bc53-dd2001b11ace)
![member8](https://github.com/user-attachments/assets/a0c011ac-8b03-45b6-8589-944679b45017)



### 🔑 Admin Paneli

![admin1](https://github.com/user-attachments/assets/e792fa48-7b7e-469d-9f73-991fe674e30e)
![admin2](https://github.com/user-attachments/assets/0cb2fd4a-b111-4855-84b3-a95e711d95e5)
![admin3](https://github.com/user-attachments/assets/ba48eb9a-c595-4bdf-9fc9-bcb6f3273ceb)
![admin4](https://github.com/user-attachments/assets/619d7370-8642-4ca7-bc90-adef9b0c9a3d)
![admin5](https://github.com/user-attachments/assets/d400bd0a-76f1-4ae4-9ca0-0e60fc98ab16)
![admin6](https://github.com/user-attachments/assets/0789bdf9-213e-42a0-9528-49814d49bd48)
![admin7](https://github.com/user-attachments/assets/5c705d0b-555d-47ba-965e-4893ec8a2b3b)
![admin8](https://github.com/user-attachments/assets/941bef24-7048-4ff3-b944-a9a7fd231305)
![admin9](https://github.com/user-attachments/assets/52fedec0-c8ff-4d2b-89a1-8e4d2328d236)
![admin10](https://github.com/user-attachments/assets/97ab78a0-b92e-4a94-be16-3bff86ad480b)
![admin11](https://github.com/user-attachments/assets/1dd3570a-2446-44b8-ae5f-c3769233aca7)
![admin12](https://github.com/user-attachments/assets/5aad96b6-20c6-438c-8449-30deb04a4179)
![admin13](https://github.com/user-attachments/assets/f440c9ad-8c08-41f2-abc6-683a3570689a)
![admin14](https://github.com/user-attachments/assets/fe553ee2-b51b-427a-be23-75abd3a0caa1)
![admin15](https://github.com/user-attachments/assets/bd0beec4-d8b8-4207-830c-55c0abf144be)
![admin16](https://github.com/user-attachments/assets/b56f25fe-d115-4a45-a5d1-157a848265e4)
![admin17](https://github.com/user-attachments/assets/dbec2213-90c3-4ae5-a5f9-69fd0cd2f4a4)
![admin18](https://github.com/user-attachments/assets/a8ff952e-4a1f-4c89-ba38-91a60055db05)
![admin19](https://github.com/user-attachments/assets/d8b573c7-4fb7-47fd-93d7-f5d95c4705df)
![admin20](https://github.com/user-attachments/assets/912dda3d-e804-481f-bfa4-10b96be96949)
![admin21](https://github.com/user-attachments/assets/442088d3-74a7-4ad4-b8a7-5db5f01160d3)
![admin22](https://github.com/user-attachments/assets/75aafb92-bded-4cd7-bd03-550e3c4501c4)
![admin23](https://github.com/user-attachments/assets/d4bc5681-4782-4459-b898-e7c7a49d0e07)
![admin24](https://github.com/user-attachments/assets/c832bef5-7c37-486f-8934-e1dbd7b7fce0)
![admin25](https://github.com/user-attachments/assets/12f8df6b-2f86-42cb-9cb9-3bd97a447c50)


![statikexcel](https://github.com/user-attachments/assets/904c1a0e-652a-4001-97c0-eaed7d1998a0)
![statikpdf](https://github.com/user-attachments/assets/2c27a136-a3f5-425a-9137-b16cbaf248aa)


### 📈 SignalR Kullanımı

https://github.com/user-attachments/assets/86e9a704-20c5-415d-a43a-b7d76a177552

![signalRss](https://github.com/user-attachments/assets/60970d86-f67a-4c9f-816d-d90bdfbcffcf)































