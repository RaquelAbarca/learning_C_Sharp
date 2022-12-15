/*
for (initializer; condition; iterator)
{
   //code block 
}

- The initializer runs once when we enter the loop, and initializes the variable.
- The condition specifies when to stop the loop.
- The iterator, runs every time the loop runs. It is usually used to increment the variable used in the condition.
*/

using System;

public class Program
{
    static void Main(string[] args)
    {
        for(int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Value of i: {i}");
        }

        int num = Convert.ToInt32(Console.ReadLine());
        int total = 1;

        //your code goes here
        for(int i=1; i<= num; i++){
            total *= i;
        }

        Console.WriteLine(total);

    }
}