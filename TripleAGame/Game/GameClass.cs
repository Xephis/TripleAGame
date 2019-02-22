using System;
using System.Collections.Generic;
using System.Text;

namespace TripleAGame.Game
{
    public class GameClass
    {
        public bool ContinueGame()
        {
            bool Choice = false;

            while (Choice == false)
            {
                Console.WriteLine("Would you like to go on an adventure");
                Console.WriteLine("Yes / No");
                string AdventureChoice = Console.ReadLine();
                AdventureChoice = char.ToUpper(AdventureChoice[0]) + AdventureChoice.Substring(1).ToLower();

                if (AdventureChoice == "Yes")
                {
                    Choice = true;
                }
                else if (AdventureChoice == "No")
                {
                    Choice = false;
                    
                }
                else
                {
                    Console.WriteLine("Sorry I didn't understand that.");
                    Choice = false;
                }
            }
            return Choice;
        }

    }
}
