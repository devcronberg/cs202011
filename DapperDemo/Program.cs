using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;

namespace DapperDemo
{
    class Program
    {
        private static string databaseFil = "c:\\temp\\people.db";
        private static string connectionString = "Data Source=" + databaseFil;

        static void Main(string[] args)
        {
            
            using (var cnn = new SQLiteConnection(connectionString))
            {
                cnn.Open();
                List<Person> personer = 
                    cnn.Query<Person>("SELECT * from Person").ToList();
                foreach (var person in personer)
                    Console.WriteLine(person.PersonId + " " + person.LastName);

            }
        }
    }

    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsHealthy { get; set; }
        public int Gender { get; set; }
        public int Height { get; set; }

    }
}
