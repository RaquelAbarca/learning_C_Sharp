using System;

public class Program
{
    static void Main(string[] args)
    {
        int purchase = 1700;
        if (purchase>=1500)
        {
            Console.WriteLine("Discount!");
        }

        int num = 12;
        if(num > 5)
        {
            Console.WriteLine("Bigger than 5");
            if(num<47)
            {
            Console.WriteLine("Between 5 and 47");
            }
        }
    }
}