using System;
using System.Collections.Generic;
using System.Text;

namespace TripleAGame
{
    public class CharacterClassStats
    {
        // properties
        public string Name { get; set; }
        public int Level { get; set; }
        public int StartingHealth { get; set; }
        public int HealthPerLevel { get; set; }
        public int MaxDamage { get; set;  }
        public int Attacks { get; set; }

        //methods 
        public int TotalHealth(int a, int b, int c)
        {
            return a + (b * c);
        }

        // (If level % 5 = 0), attacks + 1(per division) (attacks * rand.MaxDamage)
        public int AttackDamage(int a, int b)
        {
            Attacks = a;
            MaxDamage = b;

            if (Level % 5 == 0)
            {

                int NoOfAttacks = Attacks + (Level / 5);
                int damage = 0;

                Random rndDmg = new Random();
                while (NoOfAttacks > 0)
                {
                    damage += rndDmg.Next(1,MaxDamage);
                    NoOfAttacks -= 1;
                }
                return damage;
            }
            else
            {
                int NoOfAttacks = Attacks;
                int damage = 0;

                Random rndDmg = new Random();
                while (NoOfAttacks > 0)
                {
                    damage += rndDmg.Next(1,MaxDamage);
                    NoOfAttacks -= 1;
                }
                return damage;
            }
        }
    }
}
