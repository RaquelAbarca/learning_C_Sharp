/*

Inheritance allows us to define a class based on another class. This makes creating and maintaining an application easy.

The class whose properties are inherited by another class is called the Base class. The class which inherits the properties is called the Derived class.

For example, base class Animal can be used to derive Cat and Dog classes.

The derived class inherits all the features from the base class, and can have its own additional features. 


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
        class Animal { //base class Animal
            public int Legs {get; set;}
            public int Age {get; set;}
        }
        class Dog : Animal { //derive class Dog
            public Dog() {
                Legs = 4;
            }
            public void Bark() {
                Console.Write("Woof");
            }
        }
        static void Main(string[] args)
        {
            Dog d = new Dog();
            Console.WriteLine(d.Legs);
            
            d.Bark();
        }
    }
}

/*
Note the syntax for a derived class. A colon and the name of the base class follow the name of the derived class.

All public members of Animal become public members of Dog. That is why we can access the Legs member in the Dog constructor.

Now we can instantiate an object of type Dog and access the inherited members as well as call its own Bark method.

A base class can have multiple derived classes. For example, a Cat class can inherit from Animal.

Inheritance allows the derived class to reuse the code in the base class without having to rewrite it. And the derived class can be customized by adding more members. In this manner, the derived class extends the functionality of the base class.
*/

// A derived class inherits all the members of the base class, including its methods. 
// For example:

class Person {
  public void Speak() {
    Console.WriteLine("Hi there");
  }
}
class Student : Person {
  int number;
}
static void Main(string[] args) {
  Student s = new Student();
  s.Speak();
}

// We created a Student object and called the Speak method, which was declared in the base class Person.

// C# does not support multiple inheritance, so you cannot inherit from multiple classes.

// However, you can use interfaces to implement multiple inheritance. You will learn more about interfaces in the coming lessons.