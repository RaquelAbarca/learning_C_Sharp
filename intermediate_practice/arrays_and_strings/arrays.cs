// An array is a data structure that is used to store a collection of data. Like a collection of variables of the same type.

int[ ] myArray = new int[5]; // This instantiates an array named myArray that holds 5 integers. The square brackets used to define the number of elements the array should hold.
myArray[0] = 23; // This will assign the value 23 to the first element of the array.


//We can provide initial values to the array when it is declared by using curly brackets:

string[ ] names = new string[3] {"John", "Mary", "Jessica"};
double[ ] prices = new double[4] {3.6, 9.8, 6.4, 5.9};

//We can omit the size declaration when the number of elements are provided in the curly braces:

string[ ] names = new string[ ] {"John", "Mary", "Jessica"};
double[ ] prices = new double[ ] {3.6, 9.8, 6.4, 5.9};

//We can even omit the new operator. The following statements are identical to the ones above:

string[ ] names = {"John", "Mary", "Jessica"};
double[ ] prices = {3.6, 9.8, 6.4, 5.9};

//Array values should be provided in a comma separated list enclosed in {curly braces}.


int[ ] b = {11, 45, 62, 70, 88};
Console.WriteLine(b[2]); //To access individual array elements, place the element's index number in square brackets following the array name.
Console.WriteLine(b[3]);