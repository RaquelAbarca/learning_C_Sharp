/*
Indexers 
An indexer allows objects to be indexed like an array. 

As discussed earlier, a string variable is actually an object of the String class. Further, the String class is actually an array of Char objects. In this way, the string class implements an indexer so we can access any character (Char object) by its index: 
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
            string str = "Hello World";
            char x = str[4];
            Console.WriteLine(x);
        }
    }
}

/*
Indexers 
Declaration of an indexer is to some extent similar to a property. The difference is that indexer accessors require an index. 

Like a property, you use get and set accessors for defining an indexer. However, where properties return or set a specific data member, indexers return or set a particular value from the object instance. 

Indexers are defined with the this keyword.
*/
class Clients {
  private string[] names = new string[10];

  public string this[int index] {
    get {
      return names[index];
    }
    set {
      names[index] = value;
    }
  }
}