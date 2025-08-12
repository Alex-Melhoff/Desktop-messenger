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
        public static bool UserDataAreCorrect(string nickname, string email, string password)
        {
            if (nickname == string.Empty ||
                email == string.Empty ||  // если поле(поля) не заполнено(ны)
                password == string.Empty)
            {
                MessageBox.Show("Заполните все поля");
                return false;
            }

            if (!EmailEndings.Any(email.Contains) ||  // если нет привычного окончания email 
                email.IndexOf('@') == 0 ||                   // или знак '@' стоит первым
                email.Count(x => x == '@') > 1 ||            // или знак '@' не один
                email.Contains(' '))                         // или внутри email есть пробелы
            {
                MessageBox.Show("Некорректный email");
                return false;
            }

            if (password.Length < 8) { MessageBox.Show("Длина пароля меньше 8 символов"); return false; }
            else if (!password.Any(c => IsLetter(c))) { MessageBox.Show("Пароль не содержит букв"); return false; }
            else if (!password.Any(c => char.IsDigit(c))) { MessageBox.Show("Пароль не содержит цифр"); return false; }
            else if (!password.Any(c => c == '-' || c == '_')) { MessageBox.Show("Пароль не содержит символов '-' или '_'"); return false; }
            else return true;
        }
        public static bool UserDataAreCorrect(string email, string password)
        {
            if (email == string.Empty ||  // если поле(поля) не заполнено(ны)
                password == string.Empty)
            {
                MessageBox.Show("Заполните все поля");
                return false;
            }

            if (!EmailEndings.Any(email.Contains) ||  // если нет привычного окончания email 
                email.IndexOf('@') == 0 ||                   // или знак '@' стоит первым
                email.Count(x => x == '@') > 1 ||            // или знак '@' не один
                email.Contains(' '))                         // или внутри email есть пробелы
            {
                MessageBox.Show("Некорректный email");
                return false;
            }

            if (password.Length < 8) { MessageBox.Show("Длина пароля меньше 8 символов"); return false; }
            else if (!password.Any(c => IsLetter(c))) { MessageBox.Show("Пароль не содержит букв"); return false; }
            else if (!password.Any(c => char.IsDigit(c))) { MessageBox.Show("Пароль не содержит цифр"); return false; }
            else if (!password.Any(c => c == '-' || c == '_')) { MessageBox.Show("Пароль не содержит символов '-' или '_'"); return false; }
            else return true;
        }
    }
}
