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
            Console.WriteLine("Guess My Favorite Number!\nWhat do you think it is??");
            while (playAgain)
            {
                int userGuess = Convert.ToInt32(Console.ReadLine());
                do
                {
                    if (userGuess > favNum) { Console.WriteLine("Thats a little high!"); }
                    else if (userGuess < favNum) { Console.WriteLine("Thats too low!"); }
                    { break; }
                } while (userGuess != favNum);
                if (userGuess == favNum) 
                {
                    Console.WriteLine("That's right you got it!\nWould you like to play again ? (y / n)");
                    playAgain = Console.ReadLine() == "y" ? true : false;
                }
            }
        }
    }
}