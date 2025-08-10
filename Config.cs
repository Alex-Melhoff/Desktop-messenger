using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace MonoX
{
    internal static class Config
    {
        public static string[] EmailEndings = {"@yandex.ru", 
                                        "@gmail.com",
                                        "@mail.ru", 
                                        "@inbox.ru", 
                                        "@bk.ru", 
                                        "@hotmail.com", 
                                        "@live.com", 
                                        "@xakep.ru",
                                        "@furmail.ru"};
        public static bool IsLetter(char c)
        {
            return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= 'а' && c <= 'я') || (c >= 'А' && c <= 'Я');
        }
    }
}
