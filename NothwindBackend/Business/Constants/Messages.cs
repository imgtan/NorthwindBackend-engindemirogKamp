using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün başarıyla eklendi.";
        public static string productDeleted = "Ürün başarıyla silindi.";
        public static string ProductUpdated = "Ürün başarıyla güncellendi.";

        public static string UserNotFound = "Kullanıcı bulunamadı.";

        public static string PasswordError = "Şifre hatalı.";
        public static string SuccessfulLogin = "Giriş başarılı.";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut.";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi.";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";

        public static string EmployeeAdded = "Çalışanın bilgileri başarıyla eklendi.";
        public static string EmployeeDeleted = "Çalışanın bilgileri başarıyla silindi.";
        public static string EmployeeUpdated = "Çalışanın bilgileri başarıyla güncellendi.";
    }
}
