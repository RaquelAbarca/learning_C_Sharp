/*
The word polymorphism means "having many forms". 

Typically, polymorphism occurs when there is a hierarchy of classes and they are related through inheritance from a common base class.

Polymorphism means that a call to a member method will cause a different implementation to be executed depending on the type of object that invokes the method. 

Simply, polymorphism means that a single method can have a number of different implementations.

Consider having a program that allows users to draw different shapes. Each shape is drawn differently, and you do not know which shape the user will choose. 

Here, polymorphism can be leveraged to invoke the appropriate Draw method of any derived class by overriding the same method in the base class. Such methods must be declared using the virtual keyword in the base class.

For example:
*/
class Shape {
  public virtual void Draw() {
    Console.Write("Base Draw");
  }
}

/*
The virtual keyword allows methods to be overridden in derived classes.

Virtual methods enable you to work with groups of related objects in a uniform way.

Now, we can derive different shape classes that define their own Draw methods using the override keyword: 
*/
class Circle : Shape {
  public override void Draw() {
    // draw a circle...
    Console.WriteLine("Circle Draw");
  }
}
class Rectangle : Shape {
  public override void Draw() {
    // draw a rectangle...
    Console.WriteLine("Rect Draw");
  }
}

//The virtual Draw method in the Shape base class can be overridden in the derived classes. In this case, Circle and Rectangle have their own Draw methods.

//Now, we can create separate Shape objects for each derived type and then call their Draw methods:

namespace SoloLearn
{
    class Program
    {
        class Shape {
            public virtual void Draw() {
                Console.Write("Base Draw");
            }
        }
        class Circle : Shape {
            public override void Draw() {
                // draw a circle...
                Console.WriteLine("Circle Draw");
            }
        }
        class Rectangle : Shape {
            public override void Draw() {
                // draw a rectangle...
                Console.WriteLine("Rect Draw");
            }
        }
        static void Main(string[] args)
        {
            Shape c = new Circle();
            c.Draw();

            Shape r = new Rectangle();
            r.Draw();
        }
    }
}


// As you can see, each object invoked its own Draw method, thanks to polymorphism.
