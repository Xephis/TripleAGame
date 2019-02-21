using System;
using System.Collections.Generic;
using System.Text;

namespace TripleAGame.Monster
{
    class OgreClass : IMonster
    {
        public string Name { get; }
        public int Level { get; set; }
        public int StartingHealth { get; }
        public int HealthPerLevel { get; }
        public int MaxDamage { get; }
        public int Attacks { get; }

        public OgreClass()
        {
            Name = "Ogre";
            StartingHealth = 100;
            HealthPerLevel = 15;
            Level = 1;
            MaxDamage = 12;
            Attacks = 1;
        }

        int IMonster.TotalHealth(int a, int b, int c)
        {
            return a + (b * c);
        }
        
    }
}
