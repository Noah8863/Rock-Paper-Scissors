using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main()
        {
            //Default behavior is to keep playing
            bool playAgain = true;

            //While true, play the game and show a question afterwards
            while(playAgain)
            {
                //Setting a value to the 'state' of the function is an easy way to re-run the program based on a Y/N boolean question. 
                playAgain = PlayGame();
            }
            Console.WriteLine("Thanks for playing!");
        }
        //Made the function a boolean value to initate the program to run the game again
        static bool PlayGame()
        {
            Console.WriteLine("Welcome to the Game!");
            Console.Write("Plese select either Rock, Paper or Scissors: ");
            //Grab the users choice
            string userChoice = Console.ReadLine();
            Console.WriteLine("Your choice was: " + userChoice);

            //Create a random number generator to decide the computers choice
            Random randomChoice = new Random();
            int computersChoice = randomChoice.Next(1, 4);

            //Easy way to check if the user won. This is extremely inefficient due to all the if/else statements needed
            if (computersChoice == 1 && userChoice == "Paper" || computersChoice == 2 && userChoice == "Scissors" || computersChoice == 3 && userChoice == "Rock")
            {
                Console.WriteLine("You Won!");
            }
            else if (computersChoice == 1 && userChoice == "Scissors" || computersChoice == 2 && userChoice == "Rock" || computersChoice == 3 && userChoice == "Paper")
            {
                Console.WriteLine("The Computer Won");
            }
            else
            {
                Console.WriteLine("Tie Game!");
            }
            Console.WriteLine("Want to play again? Y/N");
            string userInput = Console.ReadLine();
            return userInput.ToLower() == "y";
            //Returning "y" will set the PlayGame() function to true, thus making the game run again
        }
    }
}