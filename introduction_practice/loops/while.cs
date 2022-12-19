//as long as a given condition is true.

using System;

public class Program
{
    static void Main(string[] args)
    {
        int x = 5;

        while(x>0)
        {
            Console.WriteLine(x);
            x--;
        }
    }
}

//do while loop This loop will execute the code block once, before checking if the condition is true, and then it will repeat the loop as long as the condition is true, so run at least once, even with a false condition. 

public class Program
{
    static void Main(string[] args)
    {
        int i = 5;
        
        do
        {
            Console.WriteLine(i);
            i++;
        } while (i < 5);
    }
}

/*
The for loop is usually used when the number of loop is known.

The while loop is used when the condition of the loop is more complex and the number of times it runs is based on the expression in the loop. 

Use for loops when possible.
*/