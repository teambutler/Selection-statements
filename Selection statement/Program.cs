using System;

namespace Selectionstatement
{
    class Program
    {
        static void Main(string[] args)
        {

            int favoriteNumber = 15;

            Console.WriteLine("In this game you must guess what my favorite number is. See if you can correctly guess my favorite number");
            int userResponse = int.Parse(Console.ReadLine());

                if (userResponse < favoriteNumber)
            {
                Console.WriteLine("Your guess is too low, please try again");
            }


                else if (userResponse > favoriteNumber) 
            {
                Console.WriteLine("Your guess is too high, please try again");
            }

                else if (userResponse == favoriteNumber) 
            {
                Console.WriteLine("You are spot on good friend.");
            }

                else
            {
                Console.WriteLine("Nevermind");
            }
        }
        
    }
        
}
            
            







            
        
