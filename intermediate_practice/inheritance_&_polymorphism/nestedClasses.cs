//C# supports nested classes: a class that is a member of another class.

//For example:

class Car {
  string name;
  public Car(string nm) {
    name = nm;
    Motor m = new Motor();
  }
  public class Motor {
    // some code
  }
}


/*
The Motor class is nested in the Car class and can be used similar to other members of the class.

A nested class acts as a member of the class, so it can have the same access modifiers as other members (public, private, protected).

Just as in real life, objects can contain other objects. 
For example, a car, which has its own attributes (color, brand, etc.) contains a motor, which as a separate object, has its own attributes (volume, horsepower, etc.). Here, the Car class can have a nested Motor class as one of its members.
*/