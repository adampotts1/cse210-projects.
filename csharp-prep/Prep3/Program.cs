using System;

class Program
{
    static void Main(string[] args)
    {
        //ls
        Console.Write("What is the magic number? ");
        //int magicNumber = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 25);

        int guess = -1;

        {
            Console.Write("What number do you guess between 1-25? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess )
            
            {
                Console.WriteLine("To low, guess again.");
            }

            else if (magicNumber < guess)
            {
                Console.WriteLine("Guess was to high, guess again");
            }

            else
            {
                Console.WriteLine("You have guessed correctly!");
            }
        }

        
    }
}