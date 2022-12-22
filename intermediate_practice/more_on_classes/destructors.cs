/*
Destructors 
As constructors are used when a class is instantiated, destructors are automatically invoked when an object is destroyed or deleted. 

Destructors have the following attributes:

- A class can only have one destructor.

- Destructors cannot be called. They are invoked automatically.

- A destructor does not take modifiers or have parameters. 

- The name of a destructor is exactly the same as the class prefixed with a tilde (~).

For Example: 

*/
class Dog
{
  ~Dog() 
  {
    // code statements
  }
}

// Destructors can be very useful for releasing resources before coming out of the program. This can include closing files, releasing memory, and so on.
