using System;
namespace NumberGuesser
{
    class Program
    {

        static void GetAppInfo()
        {
            //Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Mario Syti";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info
            Console.WriteLine($"{appName} : Version {appVersion} by {appAuthor}"); //.NET 5 concat

            //Reset
            Console.ResetColor();
        }
        static void GreetUser()
        {
            //Get user name
            Console.WriteLine("Whats your name?");
            string username = Console.ReadLine();

            //Invite to game
            Console.WriteLine($"Hello {username}, lets play a game");
        }
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //Change text color
            Console.ForegroundColor = color;

            //Tell user its not a number
            Console.WriteLine(message);

            //Reset color
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            GetAppInfo(); //Static method to be the start of the program
            GreetUser();


            while (true)
            {

                //Create a random number from 1-10
                Random random = new Random();
                int correctNumber = random.Next(1, 11);
                int guess = 0;
                Console.WriteLine("Guess a number between 1-10");

                //If guess is not correct
                while (guess != correctNumber)
                {
                    string userguess = Console.ReadLine();

                    //Make sure its a number
                    if (!int.TryParse(userguess, out guess))
                    {
                        //print Error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");
                        continue;
                    }

                    //Cast to int and put in guess
                    guess = Convert.ToInt32(userguess);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }
                PrintColorMessage(ConsoleColor.Yellow, "You are correct!");

                //Play again?
                Console.WriteLine("Play again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }
    }
}
