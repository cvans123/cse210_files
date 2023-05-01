using System;

class Program

{

    static void Main(string[] args)
    //Random number generator
    {
            Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(2, 1008);

        int guess = -3;

        while (guess != magicNumber)
        {
            Console.Write("Please input number ? ");

            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Please enter higher number");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Please enter lower number");
            }
            else
            {
                Console.WriteLine("Congratulations for guessing the right number!");
            }

        }                    
    }
}