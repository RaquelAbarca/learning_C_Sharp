/* An exception is a problem that occurs during program execution. Exceptions cause abnormal termination of the program. 

An exception can occur for many different reasons. Some examples:

- A user has entered invalid data.

- A file that needs to be opened cannot be found.

- A network connection has been lost in the middle of communications.

- Insufficient memory and other issues related to physical resources.

For example, the following code will produce an exception when run because we request an index which does not exist: 
*/

int[] arr = new int[] { 4, 5, 8 };
Console.Write(arr[8]);

//C# provides a flexible mechanism called the try-catch statement to handle exceptions so that a program won't crash when an error occurs.
//The try and catch blocks are used similar to: 

try {
  int[] arr = new int[] { 4, 5, 8 };
  Console.Write(arr[8]);
}
catch(Exception e) {
  Console.WriteLine("An error occurred");
}

//The code that might generate an exception is placed in the try block. If an exception occurs, the catch blocks is executed without stopping the program.

//The type of exception you want to catch appears in parentheses following the keyword catch.

//We use the general Exception type to handle all kinds of exceptions. We can also use the exception object e to access the exception details, such as the original error message (e.Message):

try {
  int[] arr = new int[] { 4, 5, 8 };
  Console.Write(arr[8]);
}
catch(Exception e) {
  Console.WriteLine(e.Message);
}
// Index was outside the bounds of the array.