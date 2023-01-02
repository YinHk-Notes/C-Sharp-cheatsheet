//Represents a first-in, first-out collection of objects.
//Inheritance: Object -> Queue
//Implements: ICollection, IEnumerable, ICloneable

using System.Collections;

public class Queue : ICloneable, System.Collections.ICollection

//Declare Queue
Queue q = new Queue();                                    //empty and has the default initial capacity.
Queue q = new Queue(System.Collections.ICollection c);    //copied from the specified collection.
Queue q = new Queue(int capacity);                        //empty and has the specific capacity.


//Properties
public virtual int Count { get; }                       //Gets the number of elements contained in the Queue.
public virtual bool IsSynchronized { get; }             //Gets a value indicating whether access to the Queue is synchronized.

//Removes all objects from the Queue.
public virtual void Clear ();

//Creates a shallow copy of the Queue.
public virtual object Clone ();

//Check whether an element is in the Queue.
public virtual bool Contains (object? obj);

//Copies the Queue elements to an existing one-dimensional Array, starting at the specified array index.
public virtual void CopyTo (Array array, int index);

//Removes and returns the object at the beginning of the Queue.
public virtual object? Dequeue ();

//Adds an object to the end of the Queue.
public virtual void Enqueue (object? obj);









