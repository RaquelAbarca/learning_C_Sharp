/* The enum keyword is used to declare an enumeration: a type that consists of a set of named constants called the enumerator list.

By default, the first enumerator has the value 0, and the value of each successive enumerator is increased by 1.

For example, in the following enumeration, Sun is 0, Mon is 1, Tue is 2, and so on: 
*/
enum Days {Sun, Mon, Tue, Wed, Thu, Fri, Sat}; 

// You can also assign your own enumerator values:

enum Days {Sun, Mon, Tue=4, Wed, Thu, Fri, Sat};
/*
In the example above, the enumeration will start from 0, then Mon is 1, Tue is 4, Wed is 5, and so on. The value of the next item in an Enum is one increment of the previous value.

Note that the values are comma separated.

You can refer to the values in the Enum with the dot syntax.

In order to assign Enum values to int variables, you have to specify the type in parentheses:
*/

namespace SoloLearn
{
    class Program
    {
        enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat }; 
        static void Main(string[] args)
        {
            int x = (int)Days.Tue;
            Console.WriteLine(x);
        }
    }
}

//Basically, Enums define variables that represent members of a fixed set.

//Some sample Enum uses include month names, days of the week, cards in a deck, etc.

// Enums are often used with switch statements.

// For example: 


namespace SoloLearn
{
    class Program
    {
        enum TrafficLights { Green, Red, Yellow };
        static void Main(string[] args)
        {
            TrafficLights x = TrafficLights.Red;
            switch (x) {
                case TrafficLights.Green:
                    Console.WriteLine("Go!");
                    break;
                case TrafficLights.Red:
                    Console.WriteLine("Stop!");
                    break;
                case TrafficLights.Yellow:
                    Console.WriteLine("Caution!");
                    break;
            }
        }
    }
}