using TabelRpgWeb;
namespace TabelRpgWeb
{

    public  class Dices 
    {
        private  Random rand = new Random();

        public  struct LifeDice
        {
            public int D4 => rand.Next(1, 5);
            public int D6 => rand.Next(1, 7);
            public int D8 => rand.Next(1, 9);
            public int D10 => rand.Next(1, 11);
            public int D12 => rand.Next(1, 13);
            public int D20 => rand.Next(1, 21);
        }
    }
}
