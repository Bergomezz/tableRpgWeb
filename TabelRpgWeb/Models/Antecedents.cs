using System;
namespace TabelRpgWeb
{

    public  class Antecedents
    {
        public string Name { get; set; }
        public string Descriptions { get; set; }

        public Antecedents(string name, string description) 
        {
            Name = name;
            Descriptions = description;
        }


    }


}
