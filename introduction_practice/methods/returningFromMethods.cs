//Here is ta function definition, specifying the return type to be a double:

using System;

public class Program
{
    static void Main(string[] args)
    {
        double result = Perc(640,24);

        Console.WriteLine($"Result is: {result}");
    }
    static double Perc(double num, int percentage)
    {
        double res = num*percentage/100;
        return res;
    }
}

//This means that our Perc method will return a value of type double.
//The return keyword stops the method from executing. If there are any statements after, they won't run