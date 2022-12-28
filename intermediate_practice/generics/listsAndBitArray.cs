/*
List<T> 

A list is similar to an array, but the elements in a list can be inserted and removed dynamically.

The C# generic collection List<T> class requires all elements be of the same type T.

List<T> properties and methods include:

Count A property that gets the number of elements contained in the list.

Item[int i] Gets or sets the element in the list at the index i. Item is the indexer and is not required when accessing an element. You only need to use the brackets [] and the index value inside the brackets.

Add(T t) Adds an element t to the end of the list.

RemoveAt(int index) Removes the element at the specified position (index) from the list.

Sort() Sorts elements in the list.

Now let's try List<T>:
*/

using System;
using System.Collections.Generic;

namespace SoloLearn
{
	class Program
	{
		static void Main(string[] args)
		{
		    List<int> li = new List<int>();
            li.Add(59);
            li.Add(72);
            li.Add(95);
            li.Add(5);
            li.Add(9);
            li.RemoveAt(1); // remove 72
            
            Console.Write("\nList: ");
            for (int x = 0; x < li.Count; x++)
                Console.Write(li[x] + " "); // 59  95  5  9
            li.Sort();
            Console.Write("\nSorted: ");
            for (int x = 0; x < li.Count; x++)
                Console.Write(li[x] + " "); // 5  9  59  95
		}
	}
}

/*
Additional List<T> properties and methods are listed below. Try them out by adding them to the List<T> example code above.

Capacity - A property that gets the number of elements the list can hold before needing to be resized.

Clear() - Removes all the elements from the list.

TrimExcess() - Sets the capacity to the actual number of elements in the list. This is useful when trying to reduce memory overhead.

AddRange(IEnumerable coll) - Adds the elements of collection coll with elements of the same type as List<T> to the end of the list. IEnumerable is the collections interface that supports simple iteration over the collection.

Insert(int i, T t) - Inserts an element t at a specific index i in the list.

InsertRange(int i, IEnumerable coll) - Inserts the elements of a collection coll at a specified index i in the list. IEnumerable is the collections interface that supports simple iteration over the collection.

Remove(T t) - Removes the first occurrence of the object t from the list.

RemoveRange(int i, int count) - Removes a specified number of elements count from the list starting at a specified index i.

Contains(T t) - Returns true if the specified element t is present in the list.

IndexOf(T t) - Returns the index of the first occurrence of the element t in the list.

Reverse() - Reverses the order of the elements in the list.

ToArray() - Copies the elements of the list into a new array.


Remember, you need to include the statement: using Systems.Collections.Generic; to use List<T>.



---------------------------------------------------------------------------------------------------------------------


SortedList<K, V> 
 

A sorted list is a collection of key/value pairs that are sorted by key. A key can be used to access its corresponding value in the sorted list.

The C# generic collection SortedList<K, V> class requires all element key/value pairs to be of the same type K, V. Duplicate keys are not permitted, which ensures that every key/value pair is unique.

SortedList<K, V> properties include:

Count - Gets the number of key/value pairs contained in the sorted list.

Item[K key] - Gets or sets the value associated the specified key contained in the sorted list. Item is the indexer and is not required when accessing an element. You only need to use the brackets [] and the key, value.

Keys - Gets a sorted and indexed collection containing only the keys in the sorted list.

SortedList<K, V> methods include:

Add(K key, V value) - Adds an element with a specific key, value pair into the sorted list.

Remove(K key) - Removes the element with the specific key, value pair associated with the specified key from the sorted list.

*/

namespace SoloLearn
{
	class Program
	{
		static void Main(string[] args)
		{
		    SortedList<string, int> sl = new SortedList<string, int>();

		    sl.Add("Solo", 59);
		    sl.Add("A", 95);
		    sl.Add("Learn", 72);
		    sl.Remove("A");
            
		    Console.WriteLine("Sorted List: ");
		    foreach (string s in sl.Keys)
		        Console.WriteLine(s + ": " + sl[s]);  // Learn: 72  Solo: 59
		    Console.WriteLine("\nCount: " + sl.Count);  // 2
		}
	}
}

/*
Here are additional SortedList<K, V> properties and methods:

Values - Gets a sorted and indexed collection of the values in the sorted list.

Clear() - Removes all the elements from the sorted list.

ContainsKey(K key) - Returns true when the specified key is present in the sorted list.

ContainsValue(V value) - Returns true when a specified value is present in the sorted list.

IndexOfKey(K key) - Returns the index of the specified key within the sorted list.

IndexOfValue(V value) - Returns the index of the specified value within the sorted list.



---------------------------------------------------------------------------------------------------------------------



BitArray 
A bit array is a collection of bits. The value of a bit can be either 0 (off/false) or 1 (on/true).

Bit arrays compactly store bits. Most commonly, they are used to represent a simple group of boolean flags or an ordered sequence of boolean values. 

BitArray properties include:

Count -  Gets the number of bits in the bit array.

IsReadOnly - Gets a value indicating if the bit array is read only or not.

BitArray methods include:

Get(int i) - Gets the value of the bit at a specified position i in the bit array.

Set(int i, bool value) - Sets the bit at a specified position i to a specified value in the bit array.

SetAll(bool value) - Sets all the bits to a specified value in the bit array.

And(BitArray ba) - Performs the bitwise AND operation on the elements of the bit array object with a specified bit array ba.

Or(BitArray ba) - Performs the bitwise OR operation on the elements of the bit array and the specified bit array ba.

Not() - Inverts the bit values of the bit array.

Xor(BitArray ba) - Performs the bitwise XOR operation on the elements of the current bit array object and the elements in the specified bit array ba.

This example demonstrates some properties and methods of the BitArray class:
*/

namespace SoloLearn
 {
    class Program
    {
        // Printing BitArray
        public static void PrintBarr(string name, BitArray ba)
        {
            Console.Write(name + " : ");
            for (int x = 0; x < ba.Length; x++)
                Console.Write(ba.Get(x) + " ");
            Console.WriteLine();
        }
        
        public static void Main(string[] args)
        {
            BitArray ba1 = new BitArray(4);
            BitArray ba2 = new BitArray(4);
            
            ba1.SetAll(true);
            ba2.SetAll(false);
            
            ba1.Set(2, false);
            ba2.Set(3, true);
            
            PrintBarr("ba1", ba1);
            PrintBarr("ba2", ba2);
            Console.WriteLine();
            
            PrintBarr("ba1 AND ba2", ba1.And(ba2));
            PrintBarr("    NOT ba2", ba2.Not());
        }
    }
}