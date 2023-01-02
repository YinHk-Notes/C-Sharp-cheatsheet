//Represents a collection of key/value pairs that are organized based on the hash code of the key.
//Inheritance: Object => Hashtable
//Derived: System.Configuration.SettingsAttributeDictionary, System.Configuration.SettingsContext, System.Data.PropertyCollection, System.Printing.IndexedProperties.PrintPropertyDictionary
//Implements: ICollection, IDictionary, IEnumerable, ICloneable, IDeserializationCallback, ISerializable

using System.Collections;

public class Hashtable : ICloneable, System.Collections.IDictionary, System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable

//Declare Hashtable
Hashtable ht = new Hashtable();
Hashtable ht = new Hashtable(int capacity, float loadFactor, System.Collections.IEqualityComparer? equalityComparer);
Hashtable ht = new Hashtable(int capacity, float loadFactor);


//Properties
public virtual int Count { get; }                               //Gets the number of key/value pairs contained in the Hashtable.
protected System.Collections.IEqualityComparer? EqualityComparer { get; }  //Gets the IEqualityComparer to use for the Hashtable.
public virtual bool IsFixedSize { get; }            //Gets a value indicating whether the Hashtable has a fixed size.
public virtual bool IsReadOnly { get; }             //Gets a value indicating whether the Hashtable is read-only.
public virtual bool IsSynchronized { get; }         //Gets a value indicating whether access to the Hashtable is synchronized.
public virtual System.Collections.ICollection Keys { get; }   //Gets an ICollection containing the keys in the Hashtable.
public virtual System.Collections.ICollection Values { get; } //Gets an ICollection containing the values in the Hashtable.
public virtual object? this[object key] { get; set; }         //Gets or sets the value associated with the specified key.



//Adds an element with the specified key and value into the Hashtable.
public virtual void Add (object key, object? value);

//Removes the element with the specified key from the Hashtable.
public virtual void Remove (object key);

//Removes all elements from the Hashtable.
public virtual void Clear ();

//Creates a shallow copy of the Hashtable.
public virtual object Clone ();

//Determines whether the Hashtable contains a specific key.
public virtual bool Contains (object key);
public virtual bool ContainsKey (object key);

//Determines whether the Hashtable contains a specific value.
public virtual bool ContainsValue (object? value);

//Determines whether the Hashtable contains a specific value.
public virtual bool ContainsValue (object? value);

//Copies the Hashtable elements to a one-dimensional Array instance at the specified index.
public virtual void CopyTo (Array array, int arrayIndex);

//Returns an IDictionaryEnumerator that iterates through the Hashtable.
public virtual System.Collections.IDictionaryEnumerator GetEnumerator ();

//Returns the hash code for the specified key.
protected virtual int GetHash (object key);

//Implements the ISerializable interface and returns the data needed to serialize the Hashtable.
public virtual void GetObjectData (System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);

//Compares a specific Object with a specific key in the Hashtable.
protected virtual bool KeyEquals (object? item, object key);

//Returns a synchronized (thread-safe) wrapper for the Hashtable.
public static System.Collections.Hashtable Synchronized (System.Collections.Hashtable table);

