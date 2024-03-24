using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using TabelRpgWeb;

namespace TabelRpgWeb
{
    public class AntecedentsContext : DbContext
    {
        public DbSet<Antecedents> Antecedents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\\mssqllocaldb;Database=MonstersDb;Trusted_Connection=True");
        }
    }

    public  class Antecedents
    {
        public string Name { get; set; }
        public string Descriptions { get; set; }

        public Antecedents(string name, string description) 
        {
            Name = name;
            Descriptions = description;
        }


    }


}
