using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string MaintenanceTime = "Sistem bakımda.";
        public static string CarAdded = "Araba eklendi.";
        public static string CarDeleted = "Araba başarıyla silindi.";
        public static string CarDailyPriceInvalid = "Lütfen 0'dan büyük bir günlük ücret giriniz.";
        public static string CarUpdated = "Araba başarıyla güncellendi.";
        public static string CarsListed = "Arabalar listelendi.";

        public static string BrandNameInvalid = "Lütfen 2 karakterden uzun bir marka ismi giriniz!";
        public static string BrandAdded = "Marka başarıyla eklendi.";
        public static string BrandExists = "Lütfen mevcut olmayan bir marka ismi giriniz!";
        public static string BrandDeleted = "Marka başarıyla silindi.";
        public static string BrandsListed = "Markalar listelendi.";
        public static string BrandUpdated = "Marka başarıyla güncellendi.";

        public static string ColorAdded = "Renk başarıyla eklendi.";
        public static string ColorExists = "Lütfen mevcut olmayan bir renk giriniz!";
        public static string ColorDeleted = "Renk başarıyla silindi.";
        public static string ColorsListed = "Renkler listelendi.";
        public static string ColorUpdated = "Renk başarıyla güncellendi.";

        public static string UserAdded = "Kullanıcı başarıyla eklendi.";
        public static string UserExists = "Email adresi kayıtlı. Lütfen farklı bir email giriniz!";
        public static string UserDeleted = "Kullanıcı başarıyla silindi.";
        public static string UsersListed = "Kullanıcılar listelendi.";
        public static string UserUpdated = "Kullanıcı başarıyla güncellendi.";

        public static string RentalAdded = "Kullanıcı başarıyla eklendi.";
        public static string RentalInvalid = "Araç kiralama için uygun değil!";
        public static string RentalDeleted = "Kiralama bilgisi başarıyla silindi.";
        public static string RentalsListed = "Kiralama bilgileri listelendi.";
        public static string RentalUpdated = "Kiralama bilgisi başarıyla güncellendi.";

        public static string CustomerAdded = "Müşteri başarıyla eklendi.";
        public static string CustomerDeleted = "Müşteri başarıyla silindi.";
        public static string CustomersListed = "Müşteriler listelendi.";
        public static string CustomerUpdated = "Müşteri başarıyla güncellendi.";

        public static string CarImageAdded = "Fotoğraf başarıyla eklendi.";
        public static string CarImageDeleted = "Fotoğraf başarıyla silindi.";
        public static string CarImagesListed = "Fotoğraflar listelendi.";
        public static string CarImageUpdated = "Fotoğraf başarıyla güncellendi.";
        public static string CarImageLimitExceeded = "Fotoğraf yükleme sınırı aşıldı!";

        public static string AuthorizationDenied = "Yetkiniz yok!";
        public static string UserRegistered = "Kayıt oldu.";
        public static string UserNotFound = "Kullanıcı bulunamadı!";
        public static string PasswordError = "Parola hatası!";
        public static string SuccessfulLogin = "Başarılı giriş.";
        public static string UserAlreadyExists = "Kullanıcı mevcut!";
        public static string AccessTokenCreated = "Token oluşturuldu.";
    }
}
