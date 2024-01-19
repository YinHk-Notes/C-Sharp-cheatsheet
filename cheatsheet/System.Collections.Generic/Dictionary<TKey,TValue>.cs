//Dictionary<TKey,TValue>
//Represents a collection of keys and values.
//https://www.geeksforgeeks.org/c-sharp-dictionary-with-examples/
//https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=net-8.0

using System.Collections.Generic;

public class Dictionary<TKey,TValue> : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>, 
  System.Collections.Generic.IDictionary<TKey,TValue>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>, 
    System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>, System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>, 
      System.Collections.IDictionary, System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable


//Constructors
public Dictionary ();
public Dictionary (System.Collections.Generic.IDictionary<TKey,TValue> dictionary); // contains elements copied from the specified IDictionary<TKey,TValue>
//Initializes a new instance of the Dictionary<TKey,TValue> class that contains elements copied from the specified IEnumerable<T>.
public Dictionary (System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>> collection);
//Initializes a new instance of the Dictionary<TKey,TValue> class that is empty, has the default initial capacity, and uses the specified IEqualityComparer<T>.
public Dictionary (System.Collections.Generic.IEqualityComparer<TKey>? comparer);


//Declare dictionary
Dictionary<TKey,TValue> dictionary = new Dictionary<TKey,TValue>();
Dictionary<TKey,TValue> dictionary = new Dictionary<TKey,TValue>(collection);
Dictionary<TKey,TValue> dictionary = new Dictionary<TKey,TValue>(comparer);

//adding key/value pairs without using Add method, eg:
Dictionary<string, string> My_dict2 =  new Dictionary<string, string>(){ {"a.1", "Dog"}, {"a.2", "Cat"}, {"a.3", "Pig"} }; 


//Properties
public System.Collections.Generic.IEqualityComparer<TKey> Comparer { get; } //Gets the IEqualityComparer<T> that is used to determine equality of keys for the dictionary.
public int Count { get; }     //Gets the number of key/value pairs contained
public TValue this[TKey key] { get; set; }  //Gets or sets the value associated with the specified key
public System.Collections.Generic.Dictionary<TKey,TValue>.KeyCollection Keys { get; } //Gets a collection containing the keys
public System.Collections.Generic.Dictionary<TKey,TValue>.ValueCollection Values { get; } //Gets a collection containing the values


//Methods

//Adds the specified key and value to the dictionary.
public void Add (TKey key, TValue value);

//Removes all keys and values 
public void Clear ();

//Determines whether the Dictionary<TKey,TValue> contains the specified key.
public bool ContainsKey (TKey key);

//Determines whether the Dictionary<TKey,TValue> contains a specific value.
public bool ContainsValue (TValue value);

//Ensures that the dictionary can hold up to a specified number of entries without any further expansion
public int EnsureCapacity (int capacity);

//Returns an enumerator that iterates through the Dictionary<TKey,TValue>.
public System.Collections.Generic.Dictionary<TKey,TValue>.Enumerator GetEnumerator ();

//Implements the ISerializable interface and returns the data needed to serialize the Dictionary<TKey,TValue> instance.
public virtual void GetObjectData (System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);

//Implements the ISerializable interface and raises the deserialization event when the deserialization is complete.
public virtual void OnDeserialization (object? sender);


public bool Remove (TKey key); //Removes the value with the specified key
//Removes the value with the specified key from the Dictionary<TKey,TValue>, and copies the element to the value parameter.
public bool Remove (TKey key, out TValue value);


//Sets the capacity of this dictionary to hold up a specified number of entries
public void TrimExcess (int capacity);
//Sets the capacity of this dictionary to what it would be if it had been originally initialized with all its entries.
public void TrimExcess ();

//Attempts to add the specified key and value to the dictionary.
public bool TryAdd (TKey key, TValue value);

//Gets the value associated with the specified key.
public bool TryGetValue (TKey key, out TValue value);
































