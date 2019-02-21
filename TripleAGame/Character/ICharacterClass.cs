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
        int HealthPerLevel { get; }
        
        //methods 
        int TotalHealth(int a, int b);
    }
}
