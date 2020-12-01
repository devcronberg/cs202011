using System;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace demo
{
    class Program
    {

        static void Main(string[] args)
        {

            using PeopleContext c = new PeopleContext();
            //var res = c.People
            //    .Where(i => i.Height > 170)
            //    .OrderBy(i => i.LastName).ToList();

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item.LastName + item.Height);
            //}

            var res = c.People.Where(i => i.PersonId == 201).FirstOrDefault();
            //Console.WriteLine(res.LastName);
            //res.LastName = "Andersen";
            //c.SaveChanges();

            
            c.People.Remove(res);
            c.SaveChanges();

        }
    }

    [Table("person")]
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsHealthy { get; set; }
        public int Gender { get; set; }
        public int Height { get; set; }

        public override string ToString()
        {
            return $"I'm {FirstName} {LastName} with id {PersonId} born {DateOfBirth.ToShortDateString()}. I'm {(IsHealthy ? "healthy" : "not healthy")}, a {(Gender == 1 ? "woman" : "man")} and {Height} cm.";
        }

    }

    public class PeopleContext : DbContext
    {
        public DbSet<Person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=c:\\temp\\people.db");
            // Enable logging to console
            optionsBuilder.UseLoggerFactory(GetLoggerFactory());

        }

        // For logging...
        private ILoggerFactory GetLoggerFactory()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddLogging(builder =>
                   builder.AddConsole()
                          .AddFilter(DbLoggerCategory.Database.Command.Name,
                                     LogLevel.Information));
            return serviceCollection.BuildServiceProvider()
                    .GetService<ILoggerFactory>();
        }
    }
}