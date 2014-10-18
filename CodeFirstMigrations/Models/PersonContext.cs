using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstMigrations.Models
{
    /// <summary>
    /// Mijn DbContext waar ik specifiek een connection string heb aangegeven
    /// </summary>
    public class PersonContext : DbContext
    {
        public PersonContext() //De constructor van PersonContext
            : base("MyConnectionString") //De constructor van DbContext
        {
            //Ik geef aan de constructor van DbContext specifiek de naam mee van mijn connection string
        }

        /// <summary>
        /// Mijn tabel van personen
        /// </summary>
        public DbSet<Person> People { get; set; }
        
    }
}