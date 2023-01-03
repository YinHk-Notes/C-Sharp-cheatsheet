## System.Collections.Generic
Contains interfaces and classes that define generic collections, which allow users to create strongly typed collections that provide better type safety and performance than non-generic strongly typed collections.


### Useful generic collection
| Generic Collections | Description |
| --- | --- |
| `List<T>` | Generic `List<T>` contains elements of specified type. It grows automatically as you add elements in it. |
| `Dictionary<TKey,TValue>` | `Dictionary<TKey,TValue>` contains key-value pairs. |
| `SortedList<TKey,TValue>` | SortedList stores key and value pairs. It automatically adds the elements in ascending order of key by default. |
| `Queue<T>` | `Queue<T>` stores the values in FIFO style (First In First Out). It keeps the order in which the values were added. It provides an Enqueue() method to add values and a Dequeue() method to retrieve values from the collection. |
| `Stack<T>` | `Stack<T>` stores the values as LIFO (Last In First Out). It provides a Push() method to add a value and Pop() & Peek() methods to retrieve values. |
| `Hashset<T>` | `Hashset<T>` contains non-duplicate elements. It eliminates duplicate elements. |
