using System;


namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;
            var random = new Random();
            var favNum = random.Next(1, 1000);

            while (playAgain)
            {
                Console.WriteLine("Guess My Favorite Number!\nWhat do you think it is??"); ;
                int userGuess = Convert.ToInt32(Console.ReadLine());
                
                while (userGuess != favNum)
                { 
                    if (userGuess > favNum)
                    {
                        Console.WriteLine("Thats a little high!");
                        break;
                    }
                    else if (userGuess < favNum)
                    {
                        Console.WriteLine("Thats too low!");
                        break;
                    }
                } 
                if(userGuess == favNum)
                {
                    Console.WriteLine("That's right you got it!");
                    Console.WriteLine("Would you like to play again? (y/n)");
                    if (Console.ReadLine() == "y")
                    {
                        playAgain = true;
                    }
                    else
                    {
                        playAgain = false;
                    }
                }
            }
        }
    }
}
