using System;
using TabelRpgWeb;

namespace TabelRpgWeb {


    public  class Character : Races
    {

        public int _Id { get; set; }
        public Races Race { get; set; }
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constituition { get; set; }
        public int Inteligence { get; set; }
        public int Wisdom { get; set; }
        public int Carisma { get; set; }
        public Antecedents BackHistory { get; set; }

        public int TotalStrength => Race.BaseStrength + Strength;
        public int TotalDexterity => Race.BaseDexterity + Dexterity;
        public int TotalConstituition => Race.BaseConstituition + Constituition;
        public int TotalIntelligence => Race.BaseInteligence + Inteligence;
        public int TotalWisdom => Race.BaseWisdom + Wisdom;
        public int TotalCarisma => Race.BaseCarisma + Carisma;

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
