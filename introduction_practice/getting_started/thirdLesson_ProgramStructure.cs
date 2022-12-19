using System;  //Namespaces are used to organize and provide code separation. They categorize different elements by putting related members in the same namespace. Definds the System namespace with the using keyword.
// Namespaces are not mandatory in a C# program, but they do play an important role in writing cleaner code and managing larger projects.

public class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Hi there!");  // the dot . operator. It is used to access the members of namespaces or classes.
    }
}

// Also, for example, not defining the System namespace will require writing System.Console.WriteLine instead of Console.WriteLine every time. So, basically, using a namespace is shorthand and makes the code more readable.

public class Program // creating this class is mandatory for the program’s execution.
{
    public static void Main(string[] args) // In C#, each application has a starting point, which is a method called Main.
    {
        Console.WriteLine("Hi there!");
    }
}