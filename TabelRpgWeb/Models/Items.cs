using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using TabelRpgWeb;

namespace TabelRpgWeb
{

    public class ItemsContext : DbContext
    {
        public DbSet<Items> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\\mssqllocaldb;Database=MonstersDb;Trusted_Connection=True");
        }
    }

    public class Items
    {


        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Rarity { get; set; }
        public int Price { get; set; }
        public double Weight { get; set; }

        public Items(string name, string description, string type, string rarity, int price)
        {
            Name = name;
            Description = description;
            Type = type;
            Rarity = rarity;
            Price = price;
        }
    }
}