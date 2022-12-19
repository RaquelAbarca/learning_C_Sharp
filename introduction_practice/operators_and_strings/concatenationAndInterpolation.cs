using System;

public class Program
{
public static void Main(string[] args)
    {
        string name = Console.ReadLine();

        Console.WriteLine(name + " is an awesome Sololearner!");
        Console.WriteLine(name + " learns!");
        Console.WriteLine(name + " practises!");
        Console.WriteLine("Be like " + name + "!");

        string city = "London";
        Console.WriteLine($"{city} is the capital of the United Kingdom.");

//To interpolated use the $ before the double quotes. 
//To use a variable inside the string, use curly brackets: {variable name}.
    }
}