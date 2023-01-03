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


//Properties
public virtual int Capacity { get; set; }   //Gets or sets the capacity of a SortedList object.
public virtual int Count { get; }           //Gets the number of elements contained in a SortedList object.
public virtual bool IsFixedSize { get; }    //Gets a value indicating whether a SortedList object has a fixed size.
public virtual bool IsReadOnly { get; }
public virtual bool IsSynchronized { get; }
public virtual object? this[object key] { get; set; }         //Gets or sets the value associated with a specific key in a SortedList object.
public virtual System.Collections.ICollection Keys { get; }   //Gets the keys in a SortedList object.
public virtual System.Collections.ICollection Values { get; } //Gets the values in a SortedList object.


//Adds an element with the specified key and value to a SortedList object.
public virtual void Add (object key, object? value);

//Removes all elements from a SortedList object.
public virtual void Clear ();








