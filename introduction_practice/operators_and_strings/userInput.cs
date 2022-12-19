using System;

public class Program
{
public static void Main(string[] args)
    {
        string nickname;

        nickname = Console.ReadLine();

        Console.Write("Welcome, ");
        Console.WriteLine(nickname);

// The Console.ReadLine method returns only string values.
// For another type of value (such as int or double), the entered data must be converted to that type.

        string text = "5";

        int number = Convert.ToInt32(text);

// There are Convert.ToInt16 and Convert.ToInt64. The default int type in C# is 32-bit.
    
        int number = 5;

        string text = Convert.ToString(number);

        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
    }
}

/*
ToBoolean : converts a type to a Boolean value
ToChar :  converts a type to a char type
ToDouble :  converts a type to a double type
ToInt16, ToInt32, ToInt64 : converts a type to a 16-bit, 32-bit and 64-bit int type accordingly
ToString() : converts a type to a string
*/

