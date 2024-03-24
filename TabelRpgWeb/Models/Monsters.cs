using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using TabelRpgWeb;

namespace TabelRpgWeb
{
    public class MonstersContext : DbContext
    {
        public DbSet<Monsters> Monsters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\\mssqllocaldb;Database=MonstersDb;Trusted_Connection=True");
        }
    }

    public class Monsters
    {
        Modifiers modifier = new Modifiers();

        public int _Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constituition { get; set; }
        public int Inteligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public double Size { get; set; }
        public int Xpoint { get; set; }
        public int LifeSize { get; set; }
        public int Speed { get; set; }
        public string Abilities { get; set; }

        public Monsters(string name, string description, int strg, int dext, int con, int intel, int wis, int chari  ,Sizes size, string type, int armorClass, LifeSizes lifeSize, XPoints xpPoints, int multiplier, string ability)
        {
            if (!Types.Contains(type))
            {
                throw new ArgumentException($"{type} não é um tipo permitido.");
            }

            Name = name;
            Description = description;
            Strength = strg;
            Dexterity = dext;
            Constituition = con;
            Inteligence = intel;
            Wisdom = wis;
            Charisma = chari;
            Size = size.Personalize;
            ArmorClass = armorClass;
            LifeSize = Hp(multiplier, lifeSize.Tiny, modifier.CalculateModifier(Constituition));
            Xpoint = xpPoints.Level0;
            Abilities = ability;
        }

        public struct Sizes
        {
            public double Tiny => 0.75;
            public double Small => 1.5;
            public double Medium => 1.5;
            public double Big => 3;
            public double Huge => 4.5;
            public double Gigantic => 6;
            public double Personalize { get; set; }
        }

        public List<string> Types = new List<string> { "Aberrações", "Bestas", "Celestiais", "Constructos", "Corruptores", "Dragões", "Elementais", "Fadas", "Gigantes", "Humanoides", "Limos", "Monstruosidades", "Mortos-vivos", "Plantas" };

        public int ArmorClass { get; set; }

        public int Hp(int multiplier, int lifeDice, int modifier)
        {
            return lifeDice + modifier;
        }


        public struct LifeSizes
        {
            public int Tiny { get; set; } = Dices.LifeDices.D4;
            public int Small { get; set; } = Dices.LifeDices.D6;
            public int Medium { get; set; } = Dices.LifeDices.D8;
            public int Big { get; set; } = Dices.LifeDices.D10;
            public int Huge { get; set; } = Dices.LifeDices.D12;
            public int Gigantic { get; set; } = Dices.LifeDices.D20;

            public LifeSizes(int tiny, int small, int medium, int big, int huge, int gigantic)
            {
                Tiny = tiny;
                Small = small;
                Medium = medium;
                Big = big;
                Huge = huge;
                Gigantic = gigantic;
            }
        }

        public struct XPoints
        {
            public  int Level0 => 10;
            public  int Level0125 => 25;
            public  int Level025 => 50;
            public  int Level050 => 100;
            public  int Level1 => 200;
            public  int Level2 => 450;
            public  int Level3 => 700;
            public  int Level4 => 1100;
            public  int Level5 => 1800;
            public  int Level6 => 2300;
            public  int Level7 => 2900;
            public  int Level8 => 3900;
            public  int Level9 => 5000;
            public  int Level10 => 5900;
            public  int Level11 => 7200;
            public  int Level12 => 8400;
            public  int Level13 => 10000;
            public  int Level14 => 11500;
            public  int Level15 => 13000;
            public  int Level16 => 15000;
            public  int Level17 => 18000;
            public  int Level18 => 20000;
            public  int Level19 => 22000;
            public  int Level20 => 25000;
            public  int Level21 => 33000;
            public  int Level22 => 41000;
            public  int Level23 => 50000;
            public  int Level24 => 62000;
            public  int Level25 => 75000;
            public  int Level26 => 90000;
            public  int Level27 => 105000;
            public  int Level28 => 120000;
            public  int Level29 => 135000;
            public  int Level30 => 155000;
        }

        public struct Speeds
        {
            public int Walk { get; set; }
            private int flight;
            public int Flight
            {
                get { return flight; }
                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentException("A criatura não voa");
                    }
                    flight = value;
                }
            }
        }

        public int SkillBonusLevelChallenge(int challengeLevel)
        {
            int skillModifier = 0;
            if (challengeLevel < 0)
            {
                throw new ArgumentException("Level need to be greater than 0!");
            }
            else
            {
                for (int i = 2; i <= challengeLevel; i++)
                {
                    if (i % 4 == 0)
                    {
                        skillModifier++;
                    }
                }
            }
            return skillModifier;
        }
    }
}