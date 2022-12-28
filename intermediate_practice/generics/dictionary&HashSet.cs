/*
Dictionary<U, V> 
 

A dictionary is a collection of unique key/value pairs where a key is used to access the corresponding value. Dictionaries are used in database indexing, cache implementations, and so on.

The C# generic collection Dictionary<K, V> class requires all key/value pairs be of the same type K, V. Duplicate keys are not permitted to ensure that every key/value pair is unique.

Dictionary<K, V> properties include:

Count - Gets the number of key/value pairs contained in the dictionary.

Item[K key] - Gets the value associated with the specified key in the dictionary. Item is the indexer and is not required when accessing an element. You only need to use the brackets [] and key value.

Keys - Gets an indexed collection containing only the keys contained in the dictionary.

Dictionary<K, V> methods include:

Add(K key, V value) - Adds the key, value pair to the dictionary.

Remove(K key) - Removes the key/value pair related to the specified key from the dictionary.

*/

using System;
using System.Collections.Generic;

namespace SoloLearn
{
	class Program
	{
		static void Main(string[] args)
		{
		    Dictionary<string, int> d = new Dictionary<string, int>();
            d.Add("Uno", 1);
            d.Add("One", 1);
            d.Add("Dos", 2);
            d.Add("Deux", 2);
            d.Remove("One");  // Remove key-value pair One, 1
            d.Remove("Dos");  // Remove key-value pair Dos, 2
            
            Console.WriteLine("Dictionary: ");
            foreach (string s in d.Keys)
                Console.WriteLine(s + ": " + d[s]);  // Uno: 1  Deux: 2
            Console.WriteLine("\nCount: {0}", d.Count); // 2 
		}
	}
}

/*
In the above example, the dictionary d uses strings as it's keys and integers as the values.

Here are the additional Dictionary<K, V> properties and methods:

Values - Gets an indexed collection containing only the values in the dictionary.

Clear() - Removes all the key/value pairs from the dictionary.

ContainsKey(K key) - Returns true if the specified key is present in the dictionary.

ContainsValue(V value) - Returns true if the specified value is present in the dictionary.





HashSet<T> 

A hash set is a set of unique values where duplicates are not allowed.

C# includes the HashSet<T> class in the generic collections namespace. All HashSet<T> elements are required to be of the same type T. 

Hash sets are different from other collections because they are simply a set of values. They do not have index positions and elements cannot be ordered.

The HashSet<T> class provides high-performance set operations. HashSets allow fast lookup, addition, and removal of items, and can be used to implement either dynamic sets of items or lookup tables that allow finding an item by its key (e.g., finding the phone number of a person by the last name).

HashSet<T> properties include:

Count Returns the number of values in the hash set.

And methods include:

Add(T t) Adds a value (t) to the hash set.

IsSubsetOf(ICollection c) Returns true if the hash set is a subset of the specified collection (c).
*/

namespace SoloLearn
{
	class Program
	{
		static void Main(string[] args)
		{
            HashSet<int> hs = new HashSet<int>();
            
            hs.Add(5);
            hs.Add(10);
            hs.Add(15);
            hs.Add(20);
            Console.Write("\nHashSet: ");
            foreach (int i in hs)
                Console.Write(i + " ");  // 5  10  15  20  *elements may be in any order
            Console.Write("\nCount: " + hs.Count);  // 4
            
            HashSet<int> hs2 = new HashSet<int>();
            hs2.Add(15);
            hs2.Add(20);
            Console.Write("\n{15, 20} is a subset of {5, 10, 15, 20}: " + hs2.IsSubsetOf(hs)); // True 
		}
	}
}

/*
Here are additional HashSet<T> methods:

Remove(T t) Removes the value (t) from the hash set.

Clear() Removes all the elements form the hash set.

Contains(T t) Returns true when a value (t) is present in the hash set.

ToString() Creates a string from the hash set.

IsSupersetOf(ICollection c) Returns true if the hash set is a superset of the specified collection.

UnionWith(ICollection c) Applies set union operation on the hash set and the specified collection (c).

IntersectWith(ICollection c) Applies set intersection operation on the hash set and the specified collection (c).

ExceptWith(ICollection c) Applies set difference operation on the hash set and the specified collection (c).
*/