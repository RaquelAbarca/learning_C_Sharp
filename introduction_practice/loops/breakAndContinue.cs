using System;

public class Program
{
    static void Main(string[] args)
    {
        int num = 1;
        while(num<=10)
        {
            if(num == 3)
            {
                break;
            }
        Console.WriteLine(num);
        num++;
        }
    }
}

//The continue statement is used to skip an iteration of the loop and continue from the next one.

public class Program
{
    static void Main(string[] args)
    {
        for(int i = 0; i<=10; i++)
        {
            if(i==5)
            {
                continue;
            }
            Console.WriteLine(i);
        }
    }
}