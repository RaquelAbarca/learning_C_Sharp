/*
Jagged Arrays

It is  an array of arrays.

The following is a declaration of a single-dimensional array that has three elements, each of which is a single-dimensional array of integers:

int[ ][ ] jaggedArr = new int[3][ ];

Each dimension is an array, so you can also initialize the array upon declaration like this:

int[ ][ ] jaggedArr = new int[ ][ ] 
{
  new int[ ] {1,8,2,7,9},
  new int[ ] {2,4,6},
  new int[ ] {33,42}
};

You can access individual array elements as shown in the example below:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
*/

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int[ ][ ] jaggedArr = new int[ ][ ] 
            {
                new int[ ] {1,8,2,7,9},
                new int[ ] {2,4,6},
                new int[ ] {33,42}
            };
            int x = jaggedArr[2][1];
            Console.WriteLine(x); //42
        }
    }
}

//This accesses the second element of the third array.
