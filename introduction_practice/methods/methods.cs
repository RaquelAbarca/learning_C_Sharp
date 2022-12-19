static void Welcome() 
{
    Console.WriteLine("Welcome");
    Console.WriteLine("I am a method");
    Console.WriteLine("End of method");
}

/*
The static is needed to be able to use the method in Main.

void means that this method does not have a return value.

Welcome is the name of the method.

To call a method, type its name followed by a set of parentheses.

Example:
*/

static void Main(string[] args)
{
    Welcome();
}