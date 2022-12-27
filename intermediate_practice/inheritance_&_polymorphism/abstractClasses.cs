/*
In some situations there is no meaningful need for the virtual method to have a separate definition in the base class.

These methods are defined using the abstract keyword and specify that the derived classes must define that method on their own. 

You cannot create objects of a class containing an abstract method, which is why the class itself should be abstract.

We could use an abstract method in the Shape class: 

*/

abstract class Shape {
   public abstract void Draw();
}

/*
As you can see, the Draw method is abstract and thus has no body. You do not even need the curly brackets; just end the statement with a semicolon.

The Shape class itself must be declared abstract because it contains an abstract method. Abstract method declarations are only permitted in abstract classes.

Remember, abstract method declarations are only permitted in abstract classes. Members marked as abstract, or included in an abstract class, must be implemented by classes that derive from the abstract class. An abstract class can have multiple abstract members.

 

An abstract class is intended to be a base class of other classes. It acts like a template for its derived classes.

Now, having the abstract class, we can derive the other classes and define their own Draw() methods: 
*/

abstract class Shape {
  public abstract void Draw();
}
class Circle : Shape {
  public override void Draw() {
    Console.WriteLine("Circle Draw");
  }
}
class Rectangle : Shape {
  public override void Draw() {
    Console.WriteLine("Rect Draw");
  }
}
static void Main(string[] args) {
  Shape c = new Circle();
  c.Draw();
}

/*
Abstract classes have the following features:

- An abstract class cannot be instantiated.

- An abstract class may contain abstract methods and accessors.

- A non-abstract class derived from an abstract class must include actual implementations of all inherited abstract methods and accessors.

It is not possible to modify an abstract class with the sealed modifier because the two modifiers have opposite meanings. The sealed modifier prevents a class from being inherited and the abstract modifier requires a class to be inherited.
*/