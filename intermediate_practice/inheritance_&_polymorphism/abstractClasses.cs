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

level
Remember, abstract method declarations are only permitted in abstract classes. Members marked as abstract, or included in an abstract class, must be implemented by classes that derive from the abstract class. An abstract class can have multiple abstract members.
*/