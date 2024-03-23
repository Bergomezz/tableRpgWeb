using TabelRpgWeb;

namespace TabelRpgWeb
{
    public  class Skill
    {
        Modifiers chooseModifiers = new Modifiers();
        public  int Stunt(int totalDexterity)
        {
            return chooseModifiers.CalculateModifier(totalDexterity);
        }

        public  int Archane(int totalIntelligence)
        {
            return chooseModifiers.CalculateModifier(totalIntelligence);
        }
    }
}
