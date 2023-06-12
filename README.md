# Csharp1_Lambda_Delegates

Lambda expressions were introduced in many programming languages, including C#, Java, and Python, to provide a more concise and expressive way to define inline delegate functions. They allow you to create anonymous functions without the need to explicitly define a named method. Here's an explanation and sample code in C#:

In C#, lambda expressions are used with delegates or functional interfaces to represent a block of code that can be executed later. They are commonly used in LINQ queries, event handling, and asynchronous programming.

Lambda expressions have the following syntax:

(input parameters) => expression or statement block

Here's an example that demonstrates the use of a lambda expression in C#:

```csharp
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
```

In the example above, a delegate type named Operation is defined, which takes two integer parameters and returns an integer. The lambda expression (a, b) => a + b is used to create a delegate instance named sum that represents a function to add two numbers.

The sum delegate is then invoked with arguments 3 and 4, resulting in the sum of 7. Additionally, a lambda expression is used in a LINQ query to filter even numbers from an array.

Lambda expressions allow you to write concise and readable code by eliminating the need for explicitly defined methods or anonymous classes. They provide a powerful tool for expressing inline delegate functions.
