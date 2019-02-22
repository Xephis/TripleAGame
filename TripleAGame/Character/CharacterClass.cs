using System;
using System.Collections.Generic;
using System.Text;

namespace TripleAGame
{
    public class PeasantClass : CharacterClassStats
    {

        public PeasantClass()
        {
            Name = "Peasant";
            StartingHealth = 10;
            HealthPerLevel = 1;
            Level = 1;
            MaxDamage = 1;
            Attacks = 1;
        }
    }

    public class WarriorClass : CharacterClassStats
    {
        public WarriorClass()
        {
            Name = "Warrior";
            StartingHealth = 100;
            HealthPerLevel = 10;
            Level = 1;
            MaxDamage = 8;
            Attacks = 2;
        }
    }
    public class ThiefClass : CharacterClassStats
    {

        public ThiefClass()
        {
            Name = "Thief";
            StartingHealth = 80;
            HealthPerLevel = 8;
            Level = 1;
            MaxDamage = 6;
            Attacks = 3;
        }
    }
    public class MageClass : CharacterClassStats
    {
        public MageClass()
        {
            Name = "Mage";
            StartingHealth = 70;
            HealthPerLevel = 6;
            Level = 1;
            MaxDamage = 18;
            Attacks = 1;
        }
    }

    public class CharacterBox
    {
        public static List<CharacterClassStats> GetCharacters()
        {
            List<CharacterClassStats> CharacterList = new List<CharacterClassStats>();
            CharacterList.Add(new WarriorClass());
            CharacterList.Add(new ThiefClass());
            CharacterList.Add(new MageClass());
            CharacterList.Add(new PeasantClass());
            return CharacterList;
        }
        
    }
}
