using System;
using System.Collections.Generic;
using System.Text;

namespace TripleAGame.Monster
{
    class OgreClass : MonsterClassStats
    {
        public OgreClass()
        {
            Name = "Ogre";
            StartingHealth = 100;
            HealthPerLevel = 15;
            Level = 1;
            MaxDamage = 12;
            Attacks = 1;
        }        
    }
}
