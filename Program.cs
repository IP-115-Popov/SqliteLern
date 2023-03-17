using Microsoft.Data.Sqlite;
using System;

namespace SqliteLeaen
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var connection = new SqliteConnection("Data Source=bdLern2.db"))
            {
                connection.Open();

                SqliteCommand command = new SqliteCommand();
                command.Connection = connection;
                command.CommandText = "CREATE TABLE Users(_id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, Name TEXT NOT NULL, Age INTEGER NOT NULL)";
                command.ExecuteNonQuery();

                Console.WriteLine("Таблица Users создана");
            }
            Console.Read();
        }
    }
}