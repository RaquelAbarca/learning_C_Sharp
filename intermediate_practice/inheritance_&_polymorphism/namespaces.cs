// When you create a blank project, it has the following structure: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn {
  class Program {
    static void Main(string[] args) {
    }
  }
}

/*
Note, that our whole program is inside a namespace. So, what are namespaces?

Namespaces declare a scope that contains a set of related objects. You can use a namespace to organize code elements. 
You can define your own namespaces and use them in your program.

The using keyword states that the program is using a given namespace.

For example, we are using the System namespace in our programs, which is where the class Console is defined:
*/

using System;
...
Console.WriteLine("Hi");

//Without the using statement, we would have to specify the namespace wherever it is used:

System.Console.WriteLine("Hi");

//The .NET Framework uses namespaces to organize its many classes. System is one example of a .NET Framework namespace.

//Declaring your own namespaces can help you group your class and method names in larger programming projects.
