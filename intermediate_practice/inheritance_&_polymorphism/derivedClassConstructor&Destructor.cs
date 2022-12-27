/*
Inheritance 
Constructors are called when objects of a class are created. With inheritance, the base class constructor and destructor are not inherited, so you should define constructors for the derived classes.

However, the base class constructor and destructor are being invoked automatically when an object of the derived class is created or deleted. 

Consider the following example:
*/

class Animal {
  public Animal() {
    Console.WriteLine("Animal created");
  }
  ~Animal() {
    Console.WriteLine("Animal deleted");
  }
}
class Dog: Animal {
  public Dog() {
    Console.WriteLine("Dog created");
  }
  ~Dog() {
    Console.WriteLine("Dog deleted");
  }
}

/*
We have defined the Animal class with a constructor and destructor and a derived Dog class with its own constructor and destructor.

level
So what will happen when we create an object of the derived class? Tap next to find out!
*/