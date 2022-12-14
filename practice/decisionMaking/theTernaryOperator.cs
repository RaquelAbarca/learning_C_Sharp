/*
a condition followed by a question mark ?
an expression1 to execute if the condition is true followed by a colon :
an expression2 to execute if the condition is false
*/

int age = 42;
string isAdult = age<18 ? "Too young": "Old enough";

int hour = 9;

string time = (hour>0 && hour<=12) ? "AM" : "PM";

Console.WriteLine(isAdult);
Console.WriteLine(time);