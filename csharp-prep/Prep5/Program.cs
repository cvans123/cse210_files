using System;
class Program
{
    static void Main(string[] args)
    {
        //Prompt for user input
        DisplayMessage();

        string userName = PromptForName();
        int userNumber = PromptForNumber();

        int squaredNumber = SquaredTotal(userNumber);
        //Total of squared
        OutputDisplay(userName, squaredNumber);
    }
    static void DisplayMessage()
    {
        //Program greeting
        Console.WriteLine("Welcome to the prompt program!");
    }
    static string PromptForName()
    {
        //User input name
        Console.Write("Please enter your first name: ");
        string name = Console.ReadLine();

        return name;
    }
    static int PromptForNumber()
    {
        //Promt user to input numeric number
        Console.Write("Please enter lucky number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    static int SquaredTotal(int number)
    {
        //Squared total calculation
        int square = number * number;
        return square;
    }
        //Display calculation output
    static void OutputDisplay(string name, int square)
    {
        Console.WriteLine($"{name}, the square total is {square}");
    }
}