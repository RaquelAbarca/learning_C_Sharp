/*
An interface is a completely abstract class, which contains only abstract members.

It is declared using the interface keyword: 
*/
public interface IShape
{
  void Draw();
}

/*
All members of the interface are by default abstract, so no need to use the abstract keyword.

Interfaces can have public (by default), private and protected members.

It is common to use the capital letter I as the starting letter for an interface name.

Interfaces can contain properties, methods, etc. but cannot contain fields (variables).
*/


namespace SoloLearn
{
    class Program
    {
        public interface IShape {
            void Draw();
        }
        class Circle : IShape {
            public void Draw() {
                Console.WriteLine("Circle Draw");
            }
        }
        static void Main(string[] args)
        {
            IShape c = new Circle();
            c.Draw();
        }
    }
}

/*
Default implementation in interfaces allows to write an implementation of any method. This is useful when there is a need to provide a single implementation for common functionality.

Let's suppose we need to add new common functionality to our already existing interface, which is implemented by many classes. Without default implementation (before C# 8), this operation would create errors, because the method we have added isn't implemented in the classes, and we would need to implement the same operation one by one in each class. Default implementation in interface solves this problem.

For example:
*/

namespace SoloLearn
{
    class Program
    {
        public interface IShape {
            void Draw();
            void Finish(){
                Console.WriteLine("Done!");
            }
        }
        class Circle : IShape {
            public void Draw() {
                Console.WriteLine("Circle Draw");
            }
        }
        static void Main(string[] args)
        {
            IShape c = new Circle();
            c.Draw();
            c.Finish();
        }
    }
}

//We added the Finish() method with default implementation to our IShape interface and called it without implementing it inside the Circle class.

// Methods with default implementation can be freely overridden inside the class which implements that interface.