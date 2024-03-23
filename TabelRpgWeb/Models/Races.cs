using System;

namespace TabelRpgWeb;

public class Races
{
    public int _Id { get; set; }
    public string _Name { get; set; }
    public string Descriptions { get; set; }
    public int BaseStrength { get; set; }
    public int BaseDexterity { get; set; }
    public int BaseConstituition { get; set; }
    public int BaseInteligence { get; set; }
    public int BaseWisdom { get; set; }
    public int BaseCarisma { get; set; }

    public int LifeDice { get; set; }

    public Races
        (
        int id, string name, string descriptions, int baseStrength, int baseDexterity, int baseConstituition, int baseInteligence, int baseWisdom, int baseCarisma, int lifeDice
        )
    {
        _Id = id;
        _Name = name;
        Descriptions = descriptions;
        BaseStrength = baseStrength;
        BaseDexterity = baseDexterity;
        BaseConstituition = baseConstituition;
        BaseInteligence = baseInteligence;
        BaseWisdom = baseWisdom;
        BaseCarisma = baseCarisma;
        LifeDice = lifeDice;
    }

    public struct SubRaces
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