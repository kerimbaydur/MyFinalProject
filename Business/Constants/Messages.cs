﻿using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductUpdated="Ürün güncellendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime="Sistem Bakımda";
        public static string ProductsListed="Ürünler Listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla on ürün olabilir";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceded="Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied = "Yetkiniz yoktur";
        public static string UserRegistered="Kayıt oldu";
        public static string UserNotFound="Kullanıcı bulunamadı";
        public static string PasswordError="Parola hatası";
        public static string SuccessfulLogin="Başarılı giriş";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";

    }
}
