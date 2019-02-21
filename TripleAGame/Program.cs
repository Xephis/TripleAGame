using System;
using System.Collections.Generic;

namespace TripleAGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // define character classes in a list
            List<ICharacterClass> ListOfCharacterClasses = CharacterBox.GetCharacters();

            // get user to choose class
            Console.WriteLine("Choose your class");
            foreach (ICharacterClass item in ListOfCharacterClasses)
            {
                Console.Write(item.Name + ", ");
            }

            // get player input and assign to PlayerCharacter variable
            string ClassChoice = Console.ReadLine();

            // ensure string starts with uppercase and follows with lowercase
            // for comparing

            ClassChoice = char.ToUpper(ClassChoice[0]) + ClassChoice.Substring(1).ToLower();

            // null the playercharacter to be able to get value out of foreach
            ICharacterClass PlayerCharacter = null;

            foreach (ICharacterClass item in ListOfCharacterClasses)
            {
                if (item.Name == ClassChoice)
                {
                    PlayerCharacter = item;
                    break;
                }

                
            }

            // calculate max health based off character level and hp per level stat
            int MaxHealth = PlayerCharacter.TotalHealth(PlayerCharacter.Level,PlayerCharacter.HealthPerLevel);

            //clear the screen and start the game.
            Console.Clear();
            Console.WriteLine("--------------");
            Console.WriteLine("Tale of Legends: " + PlayerCharacter.Name);
            Console.WriteLine("--------------");
            Console.WriteLine($"HP: {MaxHealth} | Level: {PlayerCharacter.Level}");
            

        }
    }
}
