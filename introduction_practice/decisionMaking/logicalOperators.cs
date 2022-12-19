using System;

public class Program
{
    static void Main(string[] args)
    {
        string country = "US";
        int age = 42;

        if ((country == "US" || country == "GB") &&(age >0 && age <=100))
        {
            Console.WriteLine("Welcome!");
        }
    }
}