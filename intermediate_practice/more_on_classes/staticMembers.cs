/*
Static 

noticed it in the Main method's declaration: 

static void Main(string[] args)

Class members (variables, properties, methods) can also be declared as static. This makes those members belong to the class itself, instead of belonging to individual objects. No matter how many objects of the class are created, there is only one copy of the static member.

For example:

class Cat {
  public static int count=0;
  public Cat() {
    count++;
  }
}

In this case, we declared a public member variable count, which is static. The constructor of the class increments the count variable by one.

No matter how many Cat objects are instantiated, there is always only one count variable that belongs to the Cat class because it was declared static.

Constant members are static by definition.

For example:

class MathClass {
  public const int ONE = 1;
}
static void Main(string[] args) {
  Console.Write(MathClass.ONE);
}

As you can see, we access the property ONE using the name of the class, just like a static member. This is because all const members are static by default.

-------------------------------------------------------------------------------------

Constant members are static by definition.

class MathClass {
  public const int ONE = 1;
}
static void Main(string[] args) {
  Console.Write(MathClass.ONE);
}

As you can see, we access the property ONE using the name of the class, just like a static member. This is because all const members are static by default.
*/