using System;
using System.Data;
using System.Data.SQLite;

namespace demo
{
    class Program
    {

        private static string databaseFil = "c:\\temp\\people.db";
        private static string connectionString = "Data Source=" + databaseFil;

        static void Main(string[] args)
        {
            DataTable dt = new DataTable("data");
            using (SQLiteConnection cn = new SQLiteConnection(connectionString))
            {
                using (SQLiteCommand cm = new SQLiteCommand(cn))
                {
                    string sql = "select * from person";
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(sql, cn))
                    {
                        da.Fill(dt);
                    }
                }
            }
            Console.WriteLine($"Der er {dt.Rows.Count} {(dt.Rows.Count == 1 ? "post" : "poster")} i databasen");
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine(row["lastname"]);
            }
        }
    }
}