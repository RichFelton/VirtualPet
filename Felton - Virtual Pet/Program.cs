using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Felton___Virtual_Pet
{
    class Program
    {
        //public static string breed { get; private set; }

        static void Main(string[] args)
        {
            VirtualPet dog = new VirtualPet();
            Console.WriteLine("Welcome to Virtual Pet! For DOG lovers only!");
            Console.WriteLine();

            Console.Write("Enter the name of the breed of dog you wish to own: ");
            //string breed = Console.ReadLine();
            VirtualPet virtualBreed = new VirtualPet();
            virtualBreed.breed = Console.ReadLine();
            Console.WriteLine("The breed you selected is the " + virtualBreed.breed + ".");
            Console.WriteLine();

            Console.Write("Enter the name you wish to call your dog: ");
            VirtualPet virtualName = new VirtualPet(" ", " ", 5, 5, 5, true);
            virtualName.name = Console.ReadLine();
            Console.WriteLine("Your dog's name is " + virtualName.name + ".");
            //string name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Do you want to take care of your dog? Type \"yes\" or \"no\": ");

            string exitResponse = Console.ReadLine().ToLower();

            while (exitResponse.Equals("yes"))
            {
                //Random hunger = new Random();
                //int hungry = hunger.Next(0, 10);

                VirtualPet Hunger = new VirtualPet();


                dog.Tick();
                Console.WriteLine("Your dog, " + virtualName.name + ", is currently in the states: \n \n" +
                    "Hunger (From 0 [low] to 9 [high]): {0} \n", dog.Hunger);
                Console.WriteLine("Thirst (From 0 [low] to 9 [high]): {0} \n", dog.Thirst);
                Console.WriteLine("Has a need to pee or poop (From 0 [low] to 9 [high]): {0} \n", dog.Waste);
                Console.WriteLine("Has a desire to play (True or False): {0} \n \n", dog.Playfull);
                //Console.WriteLine(nextHungerState);
                Console.WriteLine("What would you like to do? Select the number of the action you want to take: \n");
                Console.WriteLine("(1) Feed " + virtualName.name + ". \n \n" +
                  "(2) Give " + virtualName.name + " some water \n \n" +
                  "(3) Take " + virtualName.name + " outside to use the bathroom. \n \n" +
                  "(4) Take " + virtualName.name + " outside to play. \n");
                int responseNumber = int.Parse(Console.ReadLine());

                switch (responseNumber)
                {
                    case 1:
                        Console.Write("You've given " + virtualName.name + " some food. \n");
                        break;

                    case 2:
                        Console.Write("You've given " + virtualName.name + " some water. \n");
                        break;

                    case 3:
                        Console.Write("You've taken " + virtualName.name + " outside to pee and/or poop. \n");
                        break;

                    case 4:
                        Console.Write("You've played with " + virtualName.name + ". \n");
                        break;

                    default:
                        Console.Write(" ");
                        break;

                }

                Console.Write("\n Would you like to continue to take care of your dog? Enter \"yes\" or \"no\": ");
                string playAgainResponse = Console.ReadLine().ToLower();
                Console.WriteLine();

                if (playAgainResponse == "no")
                {
                    break;
                }
                else
                    playAgainResponse = "yes";

            }//while
        }//Main
    }//class
}//namespace
