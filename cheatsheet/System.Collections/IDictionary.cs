//IDictionary
//Represents a nongeneric collection of key/value pairs.

using System.Collections;

public interface IDictionary : System.Collections.ICollection

// iteration of IDictionary
foreach (DictionaryEntry de in myDictionary)
{
    //...
}


//Properties
public int Count { get; }          // Gets the number of elements contained in the ICollection.
public bool IsFixedSize { get; }   // Gets a value indicating whether the IList has a fixed size.
public bool IsSynchronized { get; } // Gets a value indicating whether access to the ICollection is synchronized (thread safe).
public object? this[int index] { get; set; }  // Gets or sets the element at the specified index.
public object SyncRoot { get; }               // Gets an object that can be used to synchronize access to the ICollection.
public System.Collections.ICollection Keys { get; }  // Gets an ICollection object containing the keys of the IDictionary object.
public System.Collections.ICollection Values { get; } // Gets an ICollection object containing the values in the IDictionary object.



//Methods
public void Add (object key, object? value);            // AAdds an element with the provided key and value to the IDictionary object.
public void Clear ();                                   // Removes all elements from the IDictionary object.
public bool Contains (object key);                      // Determines whether the IDictionary object contains an element with the specified key.
public void CopyTo (Array array, int index);            // Copies the elements of the ICollection to an Array, starting at a particular Array index.
public System.Collections.IEnumerator GetEnumerator (); // Returns an IDictionaryEnumerator object for the IDictionary object.
public void Remove (object key);                        // Removes the element with the specified key from the IDictionary object.


/// <summary> Casts the elements of an IEnumerable to the specified type </summary>
/// <param name="TResult"/> The type to cast the elements of source to </param>
/// <param name="source"/> The IEnumerable that contains the elements to be cast to type TResult. </param>
public static System.Collections.Generic.IEnumerable<TResult> Cast<TResult> (this System.Collections.IEnumerable source);

/// <summary> Filters the elements of an IEnumerable based on a specified type </summary>
/// <param name="TResult"/> The type to filter the elements of the sequence on </param>
/// <param name="source"/> The IEnumerable whose elements to filter </param>
public static System.Collections.Generic.IEnumerable<TResult> OfType<TResult> (this System.Collections.IEnumerable source);



