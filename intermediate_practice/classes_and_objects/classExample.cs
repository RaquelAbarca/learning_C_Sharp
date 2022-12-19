using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        class Person {
            int age;
            string name;
            public void SayHi() {
                Console.WriteLine("Hi");
            }
        }
        static void Main(string[] args) //Person object named p1 and then calls its public SayHi() method.
        {
            Person p1 = new Person(); //The new operator instantiates an object and returns a reference to its location:
            p1.SayHi(); //the dot operator (.) that is used to access and call the method of the object
        }
    }
}

/*
The code above declares a class named Person, which has age and name fields as well as a SayHi method.

You can include an access modifier for fields and methods (also called members) of a class. Access modifiers are keywords used to specify the accessibility of a member.

A member that has been defined public can be accessed from outside the class, as long as it's anywhere within the scope of the class object. That is why our SayHi method is declared public, as we are going to call it from outside of the class.
*/
