using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba Eklendi";
        public static string DescriptionsInvalid = "Tanım geçersiz";
        public static  string MaintenanceTime ="Bakım Zamanı";
        public static string CarsListed ="Arabalar Listelendi";
        public static string UserAdded="Kullanıcı Eklendi";
        public static string UsersListed= "Kullanıcılar Listelendi";
        public static string CompanyNameInvalid="geçersiz şirket adı";
        public static string CustomerAdded = "Müşteri Eklendi";
        public static string ReturnDatePassed="Teslim tarihi gecikti";
        public static string RentalAdded="Kiralananlar Eklendi";
        public static string RentalsListed= "Kiralananlar Listelendi";
        public static string ColorsListed = "Renkler Listelendi";
        public static string BrandsListed= "Markalar Listelendi";
        public static string BrandAdded = "Marka eklendi";
        public static string ColorAdded = "renk eklendi";
        public static string CarImageAdded="araba fotoğrafı eklendi";
        public static string CarImageListed= "araba fotoğrafı listelendi";
        public static string CarImageCountError="Araba resim sayısı 5 ten fazla olamaz";
        public static string ThisImageAlreadyExists="Bu resim zaten sistemde var";
        public static string CarDeleted="Araba silindi";
        public static string CarImageDeleted="Resim silindi";
        public static string CarImageUpdated="Resim güncellendi";
        public static string AuthorizationDenied;
        public static string UserRegistered="kayıt oldu";
        public static string UserNotFound="Kullanıcı bulunamadı";
        public static string PasswordError="Parola hatalı";
        public static string SuccessfulLogin="başarılı giriş";
        public static string UserAlreadyExists="kullanıcı zaten var";
        public static string AccessTokenCreated="Token oluşturuldu";
    }
}
