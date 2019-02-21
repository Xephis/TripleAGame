using System;
using System.Collections.Generic;
using System.Text;

namespace TripleAGame
{
    public interface ICharacterClass
    {
        // properties
        string Name { get; }
        int Level { get; set; }
        int StartingHealth { get; }
        int HealthPerLevel { get; }
        int MaxDamage { get; }
        int Attacks { get; }

        //methods 
        int TotalHealth(int a, int b, int c);
    }
}
