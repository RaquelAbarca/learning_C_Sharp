//An array can have multiple dimensions. A multidimensional array is declared as follows:

// type[, , … ,] arrayName = new type[size1, size2, …, sizeN];

//For example, let's define a two-dimensional 3x4 integer array:

// int[ , ] x = new int[3,4];

/*
 

We can initialize multidimensional arrays in the same way as single-dimensional arrays.

For example:

int[ , ] someNums = { {2, 3}, {5, 6}, {4, 6} };
C#
This will create an array with three rows and two columns. Nested curly brackets are used to define values for each row.

To access an element of the array, provide both indexes. For example someNums[2, 0] will return the value 4, as it accesses the first column of the third row.

Let's create a program that will display the values of the array in the form of a table.


*/

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
            int[ , ] someNums = { {2, 3}, {5, 6}, {4, 6} }; 
            for (int k = 0; k < 3; k++) {
                for (int j = 0; j < 2; j++) {
                    Console.Write(someNums[k, j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}