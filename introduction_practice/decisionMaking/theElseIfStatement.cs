using System;

public class Program
{
    static void Main(string[] args)
    {
        int time = 15;
        
        if(time<10)
        {
            Console.WriteLine("Good morning!");
        } 
        else if(time<20)
        {
            Console.WriteLine("Good day!");
        }
        else
        {
            Console.WriteLine("Good evening!");
        }
    }
}