using System;

public class Program
{
public static void Main(string[] args)
    {
        int score = 100;
        score+=10;
        Console.WriteLine(score);

        int x = 15;
        x+=5; // x = x+5;
        x-=5; // x = x-5;
        x*=5; // x = x*5;
        x/=5; // x = x/5;
        x%=5; // x = x%5;

        double price = 50;
        double rate = 1.2;
        price*=rate;

        int balance = 416500;
        int withdraw = 160000;

        //your code goes here
        
        Console.WriteLine(balance-=withdraw);
    }
}