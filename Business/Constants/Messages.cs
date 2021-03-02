using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{//static new'lenmez
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi Geçersiz!";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string ProductCountOfCategoryError = "Bu kategoride ki ürün kotası dolmuştur !!";

        public static string ProductNameAlreadyExits = "Bu isimde zaten bir ürün var";

        public static string CategoryLimitExists = "Kategori limiti aşıldı 15 ten fazla olamaz.";

        public static string AuthorizationDenied = "Yetkiniz Yok !";
        public static string UserRegistered = "Üye olundu Yok !";
        public static string UserNotFound = "Üye olundu Yok !";
        public static string PasswordError = "Üye olundu Yok !";
        public static string SuccessfulLogin = "Üye olundu Yok !";
        public static string UserAlreadyExists = "Üye olundu Yok !";
        public static string AccessTokenCreated = "Üye olundu Yok !";
    }
}
