using System;
using System.Collections.Generic;
using System.Text;

namespace TripleAGame
{
    public class PeasantClass : ICharacterClass
    {
        public string Name { get; }
        public int Level { get; set; }
        public int StartingHealth { get; }
        public int HealthPerLevel { get; }
        public int MaxDamage { get; }
        public int Attacks { get; }


        public PeasantClass()
        {
            Name = "Peasant";
            StartingHealth = 10;
            HealthPerLevel = 1;
            Level = 1;
            MaxDamage = 1;
            Attacks = 1;
        }

        int ICharacterClass.TotalHealth(int a, int b, int c)
        {
            return a + (b * c);
        }

    }
    public class WarriorClass : ICharacterClass
    {
        public string Name { get; }
        public int Level { get; set; }
        public int StartingHealth { get; }
        public int HealthPerLevel { get;}
        public int MaxDamage { get; }
        public int Attacks { get; }
        

        public WarriorClass()
        {
            Name = "Warrior";
            StartingHealth = 100;
            HealthPerLevel = 10;
            Level = 1;
            MaxDamage = 8;
            Attacks = 2;

        }

        int ICharacterClass.TotalHealth(int a, int b, int c)
        {
            return a + (b * c);
        }

    }
    public class ThiefClass : ICharacterClass
    {
        public string Name { get; }
        public int Level { get; set; }
        public int StartingHealth { get; }
        public int HealthPerLevel { get; }
        public int MaxDamage { get; }
        public int Attacks { get; }

        public ThiefClass()
        {
            Name = "Thief";
            StartingHealth = 80;
            HealthPerLevel = 8;
            Level = 1;
            MaxDamage = 6;
            Attacks = 3;
        }

        int ICharacterClass.TotalHealth(int a, int b, int c)
        {
            return a + (b * c);
        }

    }
    public class MageClass : ICharacterClass
    {
        public string Name { get; }
        public int Level { get; set; }
        public int StartingHealth { get; }
        public int HealthPerLevel { get; }
        public int MaxDamage { get; }
        public int Attacks { get; }

        public MageClass()
        {
            Name = "Mage";
            StartingHealth = 70;
            HealthPerLevel = 6;
            Level = 1;
            MaxDamage = 14;
            Attacks = 1;
        }

        int ICharacterClass.TotalHealth(int a, int b, int c)
        {
            return a + (b * c);
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
