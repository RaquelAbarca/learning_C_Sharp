//Writing to Files 
 
//The System.IO namespace has various classes that are used for performing numerous operations with files, such as creating and deleting files, reading from or writing to a file, closing a file, and more.

//The File class is one of them. 

//For example:

string str = "Some text";
File.WriteAllText("test.txt", str);

//The WriteAllText() method creates a file with the specified path and writes the content to it. If the file already exists, it is overwritten.
//The code above creates a file test.txt and writes the contents of the str string into it.
//To use the File class you need to use the System.IO namespace: using System.IO;

//Reading from Files 
 //You can read the content of a file using the ReadAllText method of the File class: 

string txt = File.ReadAllText("test.txt");
Console.WriteLine(txt); 

/*
This will output the content of the test.txt file.

The following methods are available in the File class:

AppendAllText() - appends text to the end of the file.

Create() - creates a file in the specified location.

Delete() - deletes the specified file.

Exists() - determines whether the specified file exists.

Copy() - copies a file to a new location.

Move() - moves a specified file to a new location

level
All methods automatically close the file after performing the operation.
*/
