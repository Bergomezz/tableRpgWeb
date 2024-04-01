using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using TabelRpgWeb;

namespace TabelRpgWeb
{
    public class Modifiers
    {

        public int CalculateModifier(int attribute)
        {
            int modifier = -5;

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
