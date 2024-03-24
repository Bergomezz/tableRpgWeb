using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using TabelRpgWeb;

namespace TabelRpgWeb 
{

    public class CharactersContext : DbContext
    {
        public DbSet<Characters> Characters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\\mssqllocaldb;Database=MonstersDb;Trusted_Connection=True");
        }
    }

    public  class Characters
    {

        public int _Id { get; set; }
        public Races Race { get; set; }
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constituition { get; set; }
        public int Inteligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public Antecedents BackHistory { get; set; }

        public Characters(Races race, string name, int strength, int dexterity, int constituition, int inteligence, int wisdom, int charisma, Antecedents backHistory)
        {
            Race = race;
            Name = name;
            Strength = strength;
            Dexterity = dexterity;
            Constituition = constituition;
            Inteligence = inteligence;
            Wisdom = wisdom;
            Charisma = charisma;
            BackHistory = backHistory;
        }

        public int TotalStrength => Race.BaseStrength + Strength;
        public int TotalDexterity => Race.BaseDexterity + Dexterity;
        public int TotalConstituition => Race.BaseConstituition + Constituition;
        public int TotalIntelligence => Race.BaseInteligence + Inteligence;
        public int TotalWisdom => Race.BaseWisdom + Wisdom;
        public int TotalCharisma => Race.BaseCharisma + Charisma;

        Skill skill = new Skill();
        Modifiers chooseModifiers = new Modifiers();

        public int Hp(int lifeDice, int totalConstituition)
        {
            return chooseModifiers.CalculateModifier(totalConstituition) + lifeDice;
        }

        public void SkillDexterity()
        {
            skill.Stunt(TotalDexterity);


        }

        public void SkillIntelligence()
        {

            skill.Archane(TotalIntelligence);
            
        }



    }
}
