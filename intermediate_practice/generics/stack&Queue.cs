/*
Stack<T> 
 
A stack is a Last In, First Out (LIFO) collection of elements where the last element that goes into the stack will be the first element that comes out.

Inserting an element onto a stack is called pushing. Deleting an element from a stack is called popping. Pushing and popping can be performed only at the top of the stack.

Stacks can be used to create undo-redo functionalities, parsing expressions (infix to postfix/prefix conversion), and much more.

The C# generic collection Stack<T> class requires all elements to be of the same type T.

Stack<T> properties include:

Count - Returns the number of elements in the stack.

Stack<T> methods include:

Peek() - Returns the element at the top of the stack without removing it.

Pop() - Returns the element at the top of the stack and removes it from the stack.

Push(T t) - Inserts an element t at the top of the stack.
*/

using System;
using System.Collections.Generic;

namespace SoloLearn
{
	class Program
	{
		static void Main(string[] args)
		{
		    Stack<int> s = new Stack<int>();
            
		    s.Push(59);
		    s.Push(72);
		    s.Push(65);

		    Console.Write("Stack: ");
		    foreach (int i in s)
		        Console.Write(i + " ");  // 65  72  59
		    Console.Write("\nCount: " + s.Count);  // 3
            
		    Console.Write("\nTop: " + s.Peek());  // 65
		    Console.Write("\nPop: " + s.Pop());  // 65
            
		    Console.Write("\nStack: ");
		    foreach (int i in s)
		        Console.Write(i + " ");  // 72  59
		    Console.Write("\nCount: " + s.Count);  // 2
		}
	}
}

/*
Here are additional Stack<T> methods:

Clear() - Removes all the elements from the stack.

Contains(T t) - Returns true when the element t is present in the stack.

ToArray() - Copies the stack into a new array.





Queue<T> 

A queue is a First In, First Out (FIFO) collection of elements where the first element that goes into a queue is also the first element that comes out.

Inserting an element into a queue is referred to as Enqueue. Deleting an element from a queue is referred to as Dequeue.

Queues are used whenever we need to manage objects in order starting with the first one in.

Scenarios include printing documents on a printer, call center systems answering people on hold people, and so on.

The C# generic collection Queue<T> class requires that all elements be of the same type T.

Queue<T> properties include:

Count - Gets the number of elements in the queue.

And methods include:

Dequeue() - Returns the object at the beginning of the queue and also removes it.

Enqueue(T t) - Adds the object t to the end of the queue.
*/

namespace SoloLearn
{
	class Program
	{
		static void Main(string[] args)
		{
            Queue<int> q = new Queue<int>();
            
            q.Enqueue(5);
            q.Enqueue(10);
            q.Enqueue(15);
            Console.Write("Queue: ");
            foreach (int i in q)
                Console.Write(i + " ");  // 5  10  15
            Console.Write("\nCount: " + q.Count);  // 3
            
            Console.Write("\nDequeue: " + q.Dequeue()); // 5
            
            Console.Write("\nQueue: ");
            foreach (int i in q)
                Console.Write(i + " ");  // 10  15
            Console.Write("\nCount: " + q.Count);  // 2
		}
	}
}
