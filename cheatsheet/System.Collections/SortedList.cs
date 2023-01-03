//Represents a collection of key/value pairs that are sorted by the keys and are accessible by key and by index
//Inheritance:  Object -> SortedList
//Implements:  ICollection, IDictionary, IEnumerable, ICloneable

using System.Collections;

public class SortedList : ICloneable, System.Collections.IDictionary

//Declare SortedList
SortedList list = new SortedList();    //Create a SortedList using the default comparer, which is sorted according to the IComparable interface.
SortedList list = new SortedList(System.Collections.IComparer comparer);    //is sorted according to the specified IComparer interface.
SortedList list = new SortedList(System.Collections.IDictionary d);
SortedList list = new SortedList(int initialCapacity);    
SortedList list = new SortedList(System.Collections.IComparer comparer, int initialCapacity);
SortedList list = new SortedList(System.Collections.IDictionary d, System.Collections.IComparer comparer);


