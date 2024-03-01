using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my little game!");
            Console.Write("Plese select either Rock, Paper or Scissors: ");
            //Grab the users choice
            string userChoice = Console.ReadLine();
            Console.WriteLine("Your choice was: " + userChoice);

            //Create a random number generator to decide the computers choice
            Random randomChoice = new Random();
            int computersChoice = randomChoice.Next(1, 4);

            if (computersChoice == 1)
            {
                Console.WriteLine("The Computer picked Rock");
            }

            else if (computersChoice == 2)
            {
                Console.WriteLine("The Computer picked Paper");
            }

            else
            {
                Console.WriteLine("The Computer picked Scissors");
            };


            //Easy way to check if the user won. This is extremely inefficient due to all the if/else statements needed
            if (computersChoice == 1 && userChoice == "Paper")
            {
                Console.WriteLine("You Won!");
            }
            else if (computersChoice == 2 && userChoice == "Scissors")
            {
                Console.WriteLine("You Won!");
            }
            else if (computersChoice == 3 && userChoice == "Rock")
            {
                Console.WriteLine("You Won!");
            }
            else
            {
                Console.WriteLine("You lost or there was a tie");
            }
            Console.ReadLine();
        }
    }
}