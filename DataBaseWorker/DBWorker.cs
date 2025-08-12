using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace MonoX.DataBaseWorker
{
    internal static class DBWorker
    {
        const string DBName = "Users";
        const string DBAddress = "Users.db";
        const string NicknameField = "Nickname";
        const string EmailField = "Email";
        const string IdField = "Id";
        const string CreatedAtField = "CreatedAt";
        const string PasswordField = "Password";

        private static void OpenCreateTable(string DBName, string DBAddress = DBAddress)
        {
            var sqlExpression = $"CREATE TABLE IF NOT EXISTS {DBName}" +
                                                $"({IdField} INTEGER PRIMARY KEY AUTOINCREMENT," +
                                                 $"{NicknameField} TEXT NOT NULL," +
                                                 $"{EmailField} TEXT UNIQUE NOT NULL," +
                                                 $"{PasswordField} TEXT NOT NULL," +
                                                 $"{CreatedAtField} TEXT NOT NULL)";
            using (var connection = new SqliteConnection($"Data Source={DBAddress}"))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Таблица Users создана или открыта");
            }
        }
        public static bool FindUser(string email, string DBAddress = DBAddress)
        {
            if (email == string.Empty)
            {
                MessageBox.Show("Предоставлены пустые данные при поиске пользователя");
                return false;
            }
            //email = email.Replace('@', 'Ё');
            OpenCreateTable(DBName, DBAddress);
            var sqlExpression = $"SELECT * FROM {DBName} WHERE {EmailField}=@email";
            using (var connection = new SqliteConnection($"Data Source={DBAddress}"))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand(sqlExpression, connection);
                command.Parameters.AddWithValue("@email", email);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())   // построчно считываем данные
                        {
                            var tableEmail = reader.GetValue(2);
                            if (Convert.ToString(tableEmail) == email)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }
        public static bool AddUser(string nickname, string email, string password, string createdAt, string DBName = DBName, string DBAddress = DBAddress)
        {
            if (FindUser(email, password))
            {
                MessageBox.Show($"Пользователь с email {email} уже существует");
                return false;
            }
            if (email == string.Empty || 
                password == string.Empty || 
                nickname == string.Empty)
            {
                MessageBox.Show("Предоставлены пустые данные при добавлении пользователя");
                return false;
            }

            //email = email.Replace('@', 'Ё');
            OpenCreateTable(DBName, DBAddress);
            var sqlExpression = $"INSERT INTO {DBName} ({NicknameField}, {EmailField}, {PasswordField}, {CreatedAtField}) " +
                                              $"VALUES ({nickname}, {email}, {password}, {createdAt})";
            using (var connection = new SqliteConnection($"Data Source={DBAddress}"))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand(sqlExpression, connection);
            }
            MessageBox.Show("Новый пользователь добавлен в базу данных");
            return true;
        }
    }
}
