using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished: ");
        int number = 1;
        List<int> numbers = new List<int>();
        while (number != 0){
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }

        int sum = 0;
        int largest = 0;
        foreach (int item in numbers)
        {
            sum = sum + item;
            if (item > largest){
                largest = item;
            }
        }

        Console.WriteLine(numbers.Count);
        float average = ((float)sum) / (numbers.Count-1);
        Console.WriteLine($"The sum is: {sum}.");
        Console.WriteLine($"The average is: {average}.");
        Console.WriteLine($"The largest number is {largest}.");
    }
}