using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int[ ] arr = {2, 4, 7};
            
            Console.WriteLine(arr.Length); // The Length property can be useful in for loops where you need to specify the number of times the loop should run.
            
            Console.WriteLine(arr.Rank); // number of dimentions
        }
    }
}

/*
Array Methods 
There are a number of methods available for arrays.
    ~ Max returns the largest value.
    ~ Min returns the smallest value.
    ~ Sum returns the sum of all elements.
*/

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int[ ] arr = { 2, 4, 7, 1};
            Console.WriteLine(arr.Max());
            Console.WriteLine(arr.Min());
            Console.WriteLine(arr.Sum());
        }
    }
}