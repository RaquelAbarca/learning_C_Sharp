using System;

public class Program
{
public static void Main(string[] args)
    {

        int points = 10;
        Console.Write("Your score: ");
        Console.WriteLine(points);
        
        //good shot!
        points++;

        points --;

        // The prefix form increments/decrements the value, and only then returns it.
        // The postfix form returns the original value of the variable, and only then increments/decrements it.

        Console.Write("Your score: ");
        Console.WriteLine(points);
    }
}