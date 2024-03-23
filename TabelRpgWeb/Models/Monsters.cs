using System;
using TabelRpgWeb;

namespace TabelRpgWeb
{
    public class Monsters : Dices
    {
        Modifiers modifier = new Modifiers();

        public int _Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Size { get; set; }
        public int Xpoint { get; set; }
        public int LifeSize { get; set; }
        public int Speed { get; set; }
        public string Abilities { get; set; }

        public Monsters(string name, string description, Sizes size, string type, int armorClass, LifeSizes lifeSize, XPoints xpPoints, int multiplier, string ability)
        {
            if (!Types.Contains(type))
            {
                throw new ArgumentException($"{type} não é um tipo permitido.");
            }

            Name = name;
            Description = description;
            Size = size.Personalize;
            ArmorClass = armorClass;
            LifeSize = Hp(multiplier, lifeSize.Tiny, modifier.CalculateModifier());
            Xpoint = xpPoints.Level0;
            Abilities = ability;
        }

        public struct Sizes
        {
            public double Tiny = 0.75;
            public double Small = 1.5;
            public double Medium = 1.5;
            public double Big = 3;
            public double Huge = 4.5;
            public double Gigantic = 6;
            public double Personalize { get; set; }
        }

        public List<string> Types = new List<string> { "Aberrações", "Bestas", "Celestiais", "Constructos", "Corruptores", "Dragões", "Elementais", "Fadas", "Gigantes", "Humanoides", "Limos", "Monstruosidades", "Mortos-vivos", "Plantas" };

        public int ArmorClass { get; set; }

        public int Hp(int multiplier, int lifeDice, int modifier)
        {
            return lifeDice + modifier;
        }

        Dices dices = new Dices();

        public struct LifeSizes
        {
            public int Tiny => Dices.LifeDice.D4;
            public int Small => Dices.LifeDice.D6;
            public int Medium => Dices.LifeDice.D8;
            public int Big => Dices.LifeDice.D10;
            public int Huge => Dices.LifeDice.D12;
            public int Gigantic => Dices.LifeDice.D20;
        }

        public  struct XPoints
        {
            public  int Level0 = 10;
            public  int Level0125 = 25;
            public  int Level025 = 50;
            public  int Level050 = 100;
            public  int Level1 = 200;
            public  int Level2 = 450;
            public  int Level3 = 700;
            public  int Level4 = 1100;
            public  int Level5 = 1800;
            public  int Level6 = 2300;
            public  int Level7 = 2900;
            public  int Level8 = 3900;
            public  int Level9 = 5000;
            public  int Level10 = 5900;
            public  int Level11 = 7200;
            public  int Level12 = 8400;
            public  int Level13 = 10000;
            public  int Level14 = 11500;
            public  int Level15 = 13000;
            public  int Level16 = 15000;
            public  int Level17 = 18000;
            public  int Level18 = 20000;
            public  int Level19 = 22000;
            public  int Level20 = 25000;
            public  int Level21 = 33000;
            public  int Level22 = 41000;
            public  int Level23 = 50000;
            public  int Level24 = 62000;
            public  int Level25 = 75000;
            public  int Level26 = 90000;
            public  int Level27 = 105000;
            public  int Level28 = 120000;
            public  int Level29 = 135000;
            public  int Level30 = 155000;
        }

        public struct Speeds
        {
            public int Walk { get; set; }
            public int Flight { get; set
                {
                    if (value < 0)
                    {
                        hrow new ArgumentException("A criatura não voa");
                    }
                    Flight = value;
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