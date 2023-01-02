//Represents a simple last-in-first-out (LIFO) non-generic collection of objects.
//Implements ICollection, IEnumerable, ICloneable
//Inheritance: Object -> Stack

using System.Collections;

public class Stack : ICloneable, System.Collections.ICollection

//Declare Stack
Stack s = new Stack();   //empty and has the default initial capacity.
Stack s = new Stack(System.Collections.ICollection col); //contains elements copied from the specified collection with the same initial capacity
Stack s = new Stack(int initialCapacity);  //empty and has the specific capacity.


//Properties
public virtual int Count { get; }             //Gets the number of elements contained in the Stack.
public virtual bool IsSynchronized { get; }   //Gets a value indicating whether access to the Stack is synchronized.


//Removes all objects from the Stack.
public virtual void Clear ();

//Creates a shallow copy of the Stack.
public virtual object Clone ();

//Check whether an element is in the Stack.
public virtual bool Contains (object? obj);

//Copies the Stack to an existing one-dimensional Array, starting at the specified array index.
public virtual void CopyTo (Array array, int index);

//Returns an IEnumerator for the Stack.
public virtual System.Collections.IEnumerator GetEnumerator ();















