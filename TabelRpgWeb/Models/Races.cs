using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using TabelRpgWeb;

namespace TabelRpgWeb
{

    public class RacesContext : DbContext
    {
        public DbSet<Races> Races { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\\mssqllocaldb;Database=MonstersDb;Trusted_Connection=True");
        }
    }

    public class Races : DbContext
    {
        public int _Id { get; set; }
        public string _Name { get; set; }
        public string Descriptions { get; set; }
        public int BaseStrength { get; set; }
        public int BaseDexterity { get; set; }
        public int BaseConstituition { get; set; }
        public int BaseInteligence { get; set; }
        public int BaseWisdom { get; set; }
        public int BaseCharisma { get; set; }


        public int LifeDice { get; set; } = Dices.LifeDices.D4;

        public Races
            (
            int id, string name, string descriptions, int baseStrength, int baseDexterity, int baseConstituition, int baseInteligence, int baseWisdom, int baseCharisma, int lifeDice
            )
        {
            _Id = id;
            _Name = name;
            Descriptions = descriptions;
            BaseStrength = baseStrength;
            BaseDexterity = baseDexterity;
            BaseConstituition = baseConstituition;
            BaseInteligence = baseInteligence;
            BaseWisdom = baseWisdom;
            BaseCharisma = baseCharisma;
            LifeDice = lifeDice;
        }

        public struct SubRaces
        {
            public string Name { get; set; }
            public string Descriptions { get; set; }
            public int BaseStrength { get; set; }
            public int BaseDexterity { get; set; }
            public int BaseConstituition { get; set; }
            public int BaseInteligence { get; set; }
            public int BaseWisdom { get; set; }
            public int BaseCharisma { get; set; }
        }
    }
}