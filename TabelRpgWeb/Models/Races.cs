namespace TabelRpgWeb;

public  class Races
{
    public  int _Id { get; };
    public  string _Name { get; set; }
    public  string Descriptions { get; set; }
    public  int BaseStrength { get; set; }
    public  int BaseDexterity { get; set; }
    public  int BaseConstituition { get; set; }
    public  int BaseInteligence { get; set; }
    public  int BaseWisdom { get; set; }
    public  int BaseCarisma { get; set; }

    public  int LifeDice { get; set; }

    public  struct SubRaces
    {
        public string Name { get; set; }
        public string Descriptions { get; set; }
        public int BaseStrength { get; set; }
        public int BaseDexterity { get; set; }
        public int BaseConstituition { get; set; }
        public int BaseInteligence { get; set; }
        public int BaseWisdom { get; set; }
        public int BaseCarisma { get; set; }
    }
 }