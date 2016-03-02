using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using angulardemomvc2.Models;

namespace angulardemomvc2.DAL
{
    public class PersonContext : DbContext
    {
        public PersonContext(): base() 
        {
        }
        public DbSet<Person> Persons { get; set; }
    }
}