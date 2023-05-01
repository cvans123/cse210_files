using System;

using System.Collections.Generic;

class Program


{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();

        
        int userNumberValue = -1;
        while (userNumberValue != 0)
        {

        //Input number
            Console.Write("Enter number (0 to exit): ");
            
            string userInput = Console.ReadLine();
            userNumberValue = int.Parse(userInput);
            


            if (userNumberValue != 0)
            {
                numbers.Add(userNumberValue); 
            }
        }

        // Formula
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        // Adding numbers
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Adding max number
 
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
        // New max number
                max = 100;
            }
        }
        Console.WriteLine($"The max is: {max}");
    }
}