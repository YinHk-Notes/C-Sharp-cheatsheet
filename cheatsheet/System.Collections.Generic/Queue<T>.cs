//Queue<T>
//Represents a first-in, first-out collection of objects.

using System.Collections.Generic;

public class Queue<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IReadOnlyCollection<T>, System.Collections.ICollection

//Constructors
public Queue ();
public Queue (System.Collections.Generic.IEnumerable<T> collection);  //ontains elements copied from the specified collection and has sufficient capacity to accommodate the number of elements copied.
public Queue (int capacity);   //Initializes a new instance of the Queue<T> class that is empty and has the specified initial capacity.


//Declare queue
Queue<T> q = new Queue<T>();
Queue<T> q = new Queue<T>(collection);
Queue<T> q = new Queue<T>(length);

//Properties
public int Count { get; }     //Gets the number of elements contained in the Queue<T>.

//Methods

//Removes all objects from the Queue<T>.
public void Clear ();

//Determines whether an element is in the Queue<T>.
public bool Contains (T item);

//Copies the Queue<T> elements to an existing one-dimensional Array, starting at the specified array index.
public void CopyTo (T[] array, int arrayIndex);

//Removes and returns the object at the beginning of the Queue<T>.
public T Dequeue ();

//Adds an object to the end of the Queue<T>.
public void Enqueue (T item);

//Ensures that the capacity of this queue is at least the specified capacity.
//If the current capacity is less than capacity, it is successively increased to twice the current capacity until it is at least the specified capacity.
public int EnsureCapacity (int capacity);

//Returns an enumerator that iterates through the Queue<T>.
public System.Collections.Generic.Queue<T>.Enumerator GetEnumerator ();

//Returns the object at the beginning of the Queue<T> without removing it.
public T Peek ();

//Copies the Queue<T> elements to a new array.
public T[] ToArray ();

//Sets the capacity to the actual number of elements in the Queue<T>
//if that number is less than 90 percent of current capacity.
public void TrimExcess ();

//Removes the object at the beginning of the Queue<T>, and copies it to the result parameter.
public bool TryDequeue (out T result);

//Returns a value that indicates whether there is an object at the beginning of the Queue<T>
//and if one is present, copies it to the result parameter. The object is not removed from the Queue<T>.
public bool TryPeek (out T result);


























