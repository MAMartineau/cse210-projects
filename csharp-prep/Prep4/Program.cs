using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");        
        
        List<int> numbers = new List<int>();

        int userInput = -1;
        while (userInput != 0)
        {
            Console.Write("Enter number: ");
            string userNumber = Console.ReadLine();
            userInput = int.Parse(userNumber);

            if (userInput != 0)
            {
                numbers.Add(userInput);
            }
        }

        int sum = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
           sum += numbers[i];
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        
        int largest = numbers[0];
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");
    }
}