using System;
using System.Linq;

namespace DndCharacterGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get the name of the player
            Console.WriteLine("Hello player, What is your name?");
            var playerName = Console.ReadLine();
            if (playerName is null || playerName == "")
            {
                Console.WriteLine("You have to write something.");
                Console.WriteLine("Hello player, What is your name?");
                playerName = Console.ReadLine();
            }
            //get the name of the familiar
            Console.WriteLine($"Hello, {playerName}. What is the name of your Familiar?");
            var familiarName = Console.ReadLine();
            if (familiarName is null || familiarName == "")
            {
                Console.WriteLine("You have to write something.");
                Console.WriteLine("What is your Familiar's name?");
                familiarName = Console.ReadLine();
            }
            Console.WriteLine($"Greetings, {familiarName}.");

            //create an empty array
            int[] abilityRolls = new int[4];
            int[] allAbilityScores = new int[6];

            //initialize random class
            var randScore = new Random();

            for (int j = 0; j < 6; j++)
            {

                // Get four random numbers 1-6
                for (int i = 0; i < 4; i++)
                {
                    var dieRoll = randScore.Next(1, 6);
                    abilityRolls[i] = dieRoll;
                }
                /*foreach (var item in abilityRolls)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("********");*/

                Array.Sort(abilityRolls);
                abilityRolls[0] = 0;
                /*foreach (var item in abilityRolls)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("*********");*/

                var abilityScore = abilityRolls.Sum();
                //Console.WriteLine(abilityScore);
                //Console.WriteLine("*******");



                allAbilityScores[j] = abilityScore;
            }

            /*Console.WriteLine("*****");
            Console.WriteLine($"{familiarName}'s ability scores are as follows: ");
            foreach (var item in allAbilityScores)
            {
                Console.WriteLine(item);
            }*/

            Console.WriteLine($"What species is {familiarName}");
            var characterSpecies = Console.ReadLine();
            Console.WriteLine($"What is {familiarName}'s Character Class?");
            var characterClass = Console.ReadLine();

            Console.WriteLine($"Okay {playerName}, your Familiar is {familiarName} and he is a {characterSpecies}, {characterClass}.");
            Console.WriteLine("Your familiars' ability scores are as follows: ");
            foreach (var item in allAbilityScores)
            {
                Console.WriteLine(item);
            }


        }
    }
}
