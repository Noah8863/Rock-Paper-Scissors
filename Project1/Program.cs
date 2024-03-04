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
                PlayGame();

                //Ask the user if they want to play again
                Console.WriteLine("Want to play again? Y/N");
                string userInput = Console.ReadLine();

                //Making sure there isn't an error based on case sensitive input
                playAgain = userInput.ToLower() == "y";
                //If the user enters "y", it comes back as a 'true' value, thus playing the game again
                //If the user enters anything but "y", the value turns 'false' and doesn't fire the play game function
            }
            Console.WriteLine("Thanks for playing!");
        }
        static void PlayGame()
        {
            Console.WriteLine("Welcome to my little game!");
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
            Console.ReadLine();
        }
    }
}