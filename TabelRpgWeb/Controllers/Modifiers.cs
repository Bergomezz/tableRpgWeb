using System;

namespace TabelRpgWeb
{
    public  class Modifiers
    {
        public int modifier = -5;

        public  int CalculateModifier(int attribute)
        {
            int chosenAttribute = modifier;
            if (attribute == 0)
            {
                return chosenAttribute;
            }
            else
            {
                for (int i = 1; i <= attribute; i++)
                {
                    if (i % 2 == 0)
                    {
                        chosenAttribute = modifier += 1;
                    }
                }
                return chosenAttribute;
            }
        }
    }
}
