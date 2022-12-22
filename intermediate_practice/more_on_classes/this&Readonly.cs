/*
The this keyword is used inside the class and refers to the current instance of the class, meaning it refers to the current object.
One of the common uses of this is to distinguish class members from other data, such as local or formal parameters of a method, as shown in the following example: 
*/
class Person {
  private string name;
  public Person(string name) {
    this.name = name;
  }
}

/*
The readonly Modifier 
Prevents a member of a class from being modified after construction. 
It means that the field declared as readonly can be modified only when you declare it or from within a constructor
*/

class Person {
  private readonly string name = "John"; 
  public Person(string name) {
    this.name = name; 
  }
}

/*
If we try to modify the name field anywhere else, we will get an error.

There are three major differences between readonly and const fields.

First, a constant field must be initialized when it is declared, whereas a readonly field can be declared without initialization, as in:
*/

readonly string name; // OK
const double PI; // Error

//Second, a readonly field value can be changed in a constructor, but a constant value cannot.

//Third, the readonly field can be assigned a value that is a result of a calculation, but constants cannot, as in:

readonly double a = Math.Sin(60); // OK
const double b = Math.Sin(60); // Error! 

// The readonly modifier prevents a member of a class from being modified after construction.