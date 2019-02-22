using System;
using System.Collections.Generic;
using TripleAGame.Game;

namespace TripleAGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // define character classes in a list
            List<CharacterClassStats> ListOfCharacterClasses = CharacterBox.GetCharacters();

            // get user to choose class
            startgame:  Console.WriteLine("Choose your class");
            foreach (CharacterClassStats item in ListOfCharacterClasses)
            {
                Console.Write(item.Name + ", ");
            }

            // get player input and assign to PlayerCharacter variable
            string ClassChoice = Console.ReadLine();

            // ensure string starts with uppercase and follows with lowercase
            // for comparing

            ClassChoice = char.ToUpper(ClassChoice[0]) + ClassChoice.Substring(1).ToLower();

            // null the playercharacter to be able to get value out of foreach
            CharacterClassStats PlayerCharacter = null;

            foreach (CharacterClassStats item in ListOfCharacterClasses)
            {
                if (item.Name == ClassChoice)
                {
                    PlayerCharacter = item;
                    break;
                }
                
            }
            
            //clear the screen and start the game.
            Console.Clear();
            Console.WriteLine("--------------");
            Console.WriteLine("Tale of Legends: " + PlayerCharacter.Name);
            Console.WriteLine("--------------");
            Console.WriteLine($"HP: {PlayerCharacter.StartingHealth} | Level: {PlayerCharacter.Level}");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            GameClass Continue = new GameClass();

            Continue.ContinueGame();

            Console.WriteLine("Test Attack");
            Console.WriteLine(PlayerCharacter.AttackDamage(PlayerCharacter.Attacks, PlayerCharacter.MaxDamage));




        }
    }
}
