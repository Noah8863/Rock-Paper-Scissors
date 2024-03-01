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


            Console.ReadLine();
        }
    }
}