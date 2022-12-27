/*
The protected access modifier is very similar to private with one difference; it can be accessed in the derived classes. So, a protected member is accessible only from derived classes.

For example:
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
        class Person {
            protected int Age {get; set;}
            protected string Name {get; set;}
        }
        class Student : Person {
            public Student(string nm) {
                Name = nm;
            }
            public void Speak() {
                Console.Write("Name: "+Name);
            }
        }
        static void Main(string[] args)
        {
            Student s = new Student("David");
            s.Name = "Bob"; 
        }
    }
}

//A class can prevent other classes from inheriting it, or any of its members, by using the sealed modifier.
//For example: 

sealed class Animal {
  //some code
}
class Dog : Animal { } //Error

/*
In this case, we cannot derive the Dog class from the Animal class because Animal is sealed.

The sealed keyword provides a level of protection to your class so that other classes cannot inherit from it.
*/