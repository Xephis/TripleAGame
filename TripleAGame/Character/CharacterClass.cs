using System;
using System.Collections.Generic;
using System.Text;

namespace TripleAGame
{
    public class PeasantClass : ICharacterClass
    {
        public string Name { get; }
        public int Level { get; set; }
        public int HealthPerLevel { get; }


        public PeasantClass()
        {
            Name = "Peasant";
            HealthPerLevel = 1;
            Level = 1;
        }

        int ICharacterClass.TotalHealth(int a, int b)
        {
            return a * b;
        }

    }
    public class WarriorClass : ICharacterClass
    {
        public string Name { get; }
        public int Level { get; set; }
        public int HealthPerLevel { get;}
        

        public WarriorClass()
        {
            Name = "Warrior";
            HealthPerLevel = 10;
            Level = 1;
        }

        int ICharacterClass.TotalHealth(int a, int b)
        {
            return a * b;
        }

    }
    public class ThiefClass : ICharacterClass
    {
        public string Name { get; }
        public int Level { get; set; }
        public int HealthPerLevel { get; }

        public ThiefClass()
        {
            Name = "Thief";
            HealthPerLevel = 8;
            Level = 1;
        }

        int ICharacterClass.TotalHealth(int a, int b)
        {
            return a * b;
        }

    }
    public class MageClass : ICharacterClass
    {
        public string Name { get; }
        public int Level { get; set; }
        public int HealthPerLevel { get; }

        public MageClass()
        {
            Name = "Mage";
            HealthPerLevel = 6;
            Level = 1;
        }

        int ICharacterClass.TotalHealth(int a, int b)
        {
            return a * b;
        }

    }

    public class CharacterBox
    {
        public static List<ICharacterClass> GetCharacters()
        {
            List<ICharacterClass> CharacterList = new List<ICharacterClass>();
            CharacterList.Add(new WarriorClass());
            CharacterList.Add(new ThiefClass());
            CharacterList.Add(new MageClass());
            CharacterList.Add(new PeasantClass());

            return CharacterList;
        }
        
    }
}
