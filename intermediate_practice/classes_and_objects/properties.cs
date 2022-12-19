/*
As we have seen in the previous lessons, it is a good practice to encapsulate members of a class and provide access to them only through public methods.

A property is a member that provides a flexible mechanism to read, write, or compute the value of a private field. Properties can be used as if they are public data members, but they actually include special methods called accessors.

The accessor of a property contains the executable statements that help in getting (reading or computing) or setting (writing) a corresponding field. Accessor declarations can include a get accessor, a set accessor, or both. 

For example:
*/

class Person
{
  private string name; //field

  public string Name //property
  {
    get { return name; }
    set { name = value; }
  }
}

/*
The Person class has a Name property that has both the set and the get accessors.

The set accessor is used to assign a value to the name variable; get is used to return its value.

value is a special keyword, which represents the value we assign to a property using the set accessor.

The name of the property can be anything you want, but coding conventions dictate properties have the same name as the private field with a capital letter.
*/