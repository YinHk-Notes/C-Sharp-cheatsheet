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

//Removes the element with the specified key from a SortedList object.
public virtual void Remove (object key);

//Removes all elements from a SortedList object.
public virtual void Clear ();

//Creates a shallow copy of a SortedList object.
public virtual object Clone ();

//Determines whether a SortedList object contains a specific key.
public virtual bool Contains (object key);

//Determines whether a SortedList object contains a specific key.
public virtual bool ContainsKey (object key);

//Determines whether a SortedList object contains a specific value.
public virtual bool ContainsValue (object? value);

//Copies SortedList elements to a one-dimensional Array object, starting at the specified index in the array.
public virtual void CopyTo (Array array, int arrayIndex);

//Gets the value at the specified index of a SortedList object.
public virtual object? GetByIndex (int index);

//Returns an IDictionaryEnumerator object that iterates through a SortedList object.
public virtual System.Collections.IDictionaryEnumerator GetEnumerator ();

//Gets the key at the specified index of a SortedList object.
public virtual object GetKey (int index);

//Gets the keys in a SortedList object.
public virtual System.Collections.IList GetKeyList ();

//Gets the values in a SortedList object.
public virtual System.Collections.IList GetValueList ();

//Returns the zero-based index of the specified key in a SortedList object.
public virtual int IndexOfKey (object key);

//Returns the zero-based index of the first occurrence of the specified value in a SortedList object.
public virtual int IndexOfValue (object? value);
























