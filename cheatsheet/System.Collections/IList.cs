//IList
//Represents a non-generic collection of objects that can be individually accessed by index.

using System.Collections;

public interface IList : System.Collections.ICollection

//Properties
public int Count { get; }          // Gets the number of elements contained in the ICollection.
public bool IsFixedSize { get; }   // Gets a value indicating whether the IList has a fixed size.
public bool IsSynchronized { get; } // Gets a value indicating whether access to the ICollection is synchronized (thread safe).
public object? this[int index] { get; set; }  // Gets or sets the element at the specified index.
public object SyncRoot { get; }               // Gets an object that can be used to synchronize access to the ICollection.


//Methods
public int Add (object? value);                         // Adds an item to the IList.
public void Clear ();                                   // Removes all items from the IList.
public bool Contains (object? value);                   // Determines whether the IList contains a specific value.
public void CopyTo (Array array, int index);            // Copies the elements of the ICollection to an Array, starting at a particular Array index.
public System.Collections.IEnumerator GetEnumerator (); // Returns an enumerator that iterates through a collection.
public int IndexOf (object? value);                     // Determines the index of a specific item in the IList.
public void Insert (int index, object? value);          // Inserts an item to the IList at the specified index.
public void Remove (object? value);                     // Removes the first occurrence of a specific object from the IList.
public void RemoveAt (int index);                       // Removes the IList item at the specified index.

/// <summary> Casts the elements of an IEnumerable to the specified type </summary>
/// <param name="TResult"/> The type to cast the elements of source to </param>
/// <param name="source"/> The IEnumerable that contains the elements to be cast to type TResult. </param>
public static System.Collections.Generic.IEnumerable<TResult> Cast<TResult> (this System.Collections.IEnumerable source);

/// <summary> Filters the elements of an IEnumerable based on a specified type </summary>
/// <param name="TResult"/> The type to filter the elements of the sequence on </param>
/// <param name="source"/> The IEnumerable whose elements to filter </param>
public static System.Collections.Generic.IEnumerable<TResult> OfType<TResult> (this System.Collections.IEnumerable source);












