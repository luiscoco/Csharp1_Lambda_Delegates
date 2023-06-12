using System;

class Program
{
    delegate int Operation(int a, int b);

    static void Main()
    {
        // Using a lambda expression to define a delegate function
        Operation sum = (a, b) => a + b;

        // Invoking the delegate
        int result = sum(3, 4);
        Console.WriteLine("Sum: " + result);

        // Using a lambda expression in a LINQ query
        int[] numbers = { 1, 2, 3, 4, 5 };
        var evenNumbers = numbers.Where(x => x % 2 == 0);
        Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers));
    }
}

