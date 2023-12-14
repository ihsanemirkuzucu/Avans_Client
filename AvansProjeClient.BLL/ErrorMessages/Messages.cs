using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AvansProjeClient.BLL.ErrorMessages
{
    public static class Messages
    {
        private static Dictionary<string, string> _messageDictionary;
        
        static Messages()
        {
            string json = File.ReadAllText($"C:\\Users\\User\\Desktop\\AvansProjeClient\\AvansProjeClient.BLL\\MessagesStorage.json", Encoding.UTF8);
            _messageDictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
        }

        public static string UserNotFound => GetMessage("UserNotFound");
        public static string PasswordError => GetMessage("PasswordError");
        public static string SuccessfullLogin => GetMessage("SuccessfullLogin");
        public static string UserAlreadyExists => GetMessage("UserAlreadyExists");
        public static string UserRegisteredSuccess => GetMessage("UserRegisteredSuccess");
        public static string LoginError => GetMessage("LoginError");
        public static string RegisterError => GetMessage("RegisterError");
        public static string PasswordConfirmError => GetMessage("PasswordConfirmError");
        public static string MailFormatError => GetMessage("MailFormatError");
        public static string LoginInputNullError => GetMessage("LoginInputNullError");
        public static string GeneralSuccess => GetMessage("GeneralSuccess");
        public static string GeneralError => GetMessage("GeneralError");


        private static string GetMessage(string key)
        {
            if (_messageDictionary.TryGetValue(key, out var message))
            {
                return message;
            }
            return $"{key} mesaj bilgisi bulunamadı.";
        }
    }
}
