using System;
using System.Collections.Generic;
using System.Text;

namespace TripleAGame.Monster
{
    interface IMonster
    {
        string Name { get; }
        int Level { get; }
        int HealthPerLevel { get; }

        // commit
    }
}
