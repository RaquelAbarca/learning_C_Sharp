//Generic types can also be used with classes.
//The most common use for generic classes is with collections of items, where operations such as adding and removing items from the collection are performed in basically the same way regardless of the type of data being stored. One type of collection is called a stack. Items are "pushed", or added to the collection, and "popped", or removed from the collection. A stack is sometimes called a Last In First Out (LIFO) data structure.
//For example: 

class Stack<T> {
  int index=0;
  T[] innerArray = new T[100];
  public void Push(T item) {
    innerArray[index++] = item; 
  }
  public T Pop() {
    return innerArray[--index]; 
  }
  public T Get(int k) { return innerArray[k]; }
}

//The generic class stores elements in an array. As you can see, the generic type T is used as the type of the array, the parameter type for the Push method, and the return type for the Pop and Get methods.
//Now we can create objects of our generic class:

Stack<int> intStack = new Stack<int>();
Stack<string> strStack = new Stack<string>();
Stack<Person> PersonStack = new Stack<Person>();

//We can also use the generic class with custom types, such as the custom defined Person type.

//In a generic class we do not need to define the generic type for its methods, because the generic type is already defined on the class level.

//Generic class methods are called the same as for any other object:

Stack<int> intStack = new Stack<int>();
intStack.Push(3);
intStack.Push(6);
intStack.Push(7);
            
Console.WriteLine(intStack.Get(1));