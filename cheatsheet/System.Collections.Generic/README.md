## System.Collections.Generic
Contains interfaces and classes that define generic collections, which allow users to create **strongly typed** collections that provide better **type safety** and **performance** than non-generic strongly typed collections.

The `System.Collections` namespace contains the non-generic collection types and `System.Collections.Generic` namespace includes generic collection types.

> In most cases, it is recommended to **use the generic collections** because they perform faster than non-generic collections and also minimize exceptions by giving compile-time errors. For non geberic, it will do the boxing and unboxing while processing (**decrease the performance**).

> A generic collection is strongly typed (you can store one type of objects into it) so that we can eliminate runtime type mismatches, it improves the performance by avoiding boxing and unboxing.

> Using generic collections gives you the automatic benefit of type safety without having to derive from a base collection type and implement type-specific members.

> Generic collection types also generally perform better than the corresponding nongeneric collection types (and better than types that are derived from nongeneric base collection types) when the collection elements are value types, because with generics, there's no need to box the elements.



### Useful generic collection
| Generic Collections | Description |
| --- | --- |
| `List<T>` | Generic `List<T>` contains elements of specified type. It grows automatically as you add elements in it. |
| `Dictionary<TKey,TValue>` | `Dictionary<TKey,TValue>` contains key-value pairs. |
| `SortedList<TKey,TValue>` | SortedList stores key and value pairs. It automatically adds the elements in ascending order of key by default. |
| `Queue<T>` | `Queue<T>` stores the values in FIFO style (First In First Out). It keeps the order in which the values were added. It provides an Enqueue() method to add values and a Dequeue() method to retrieve values from the collection. |
| `Stack<T>` | `Stack<T>` stores the values as LIFO (Last In First Out). It provides a Push() method to add a value and Pop() & Peek() methods to retrieve values. |
| `Hashset<T>` | `Hashset<T>` contains non-duplicate elements. It eliminates duplicate elements. |


### Wgy use Generic?
- Code Re-usability with Generics
- Type Safety with Generics
- Cleaner Code with Generics
- Better Performance with Generics


### ref
https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic?view=net-7.0
