using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using TabelRpgWeb;

namespace TabelRpgWeb
{

    public class Dices
    {
        public int LifeDice { get; set; }

        public Dices(int lifeDice)
        {
            LifeDice = lifeDice;

        }

        public struct LifeDices
        {
            private static Random rand = new Random();

            public static int D4 => rand.Next(1, 5);
            public static int D6 => rand.Next(1, 7);
            public static int D8 => rand.Next(1, 9);
            public static int D10 => rand.Next(1, 11);
            public static int D12 => rand.Next(1, 13);
            public static int D20 => rand.Next(1, 21);
        }
    }
}
