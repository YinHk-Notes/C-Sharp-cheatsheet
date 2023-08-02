//Stack<T>
//Represents a variable size last-in-first-out (LIFO) collection of instances of the same specified type.

using System.Collections.Generic;


public class Stack<T> : System.Collections.Generic.IEnumerable<T>, 
  System.Collections.Generic.IReadOnlyCollection<T>, 
    System.Collections.ICollection


//Constructors
public Stack ();
public Stack (System.Collections.Generic.IEnumerable<T> collection); //contains elements copied from the specified collection 
public Stack (int capacity);          //Initializes a new instance of the Stack<T> class that is empty and has the specified initial capacity


//Declare stack
Stack<T> s = new Stack<T>();
Stack<T> s = new Stack<T>(collection);
Stack<T> s = new Stack<T>(length);

//Properties
public int Count { get; } ////Gets the number of elements contained in the Stack.


//Methods

//Removes all objects
public void Clear ();

//Determines whether an element is in the Stack<T>
public bool Contains (T item);

//Copies the Stack<T> to an existing one-dimensional Array, starting at the specified array index.
public void CopyTo (T[] array, int arrayIndex);

//Ensures that the capacity of this Stack is at least the specified capacity. 
//If the current capacity is less than capacity, it is successively increased to twice the current capacity until it is at least the specified capacity.
public int EnsureCapacity (int capacity);

//Returns an enumerator for the Stack<T>.
public System.Collections.Generic.Stack<T>.Enumerator GetEnumerator ();

//Returns the object at the top of the Stack<T> without removing it.
public T Peek ();

//Removes and returns the object at the top of the Stack<T>.
public T Pop ();

//Inserts an object at the top of the Stack<T>
public void Push (T item);

//Copies the Stack<T> to a new array
public T[] ToArray ();

//Sets the capacity to the actual number of elements in the Stack<T>
//if that number is less than 90 percent of current capacity.
public void TrimExcess ();

//Returns a value that indicates whether there is an object at the top of the Stack<T>
//and if one is present, copies it to the result parameter. The object is not removed from the Stack<T>.
public bool TryPeek (out T result);

//Returns a value that indicates whether there is an object at the top of the Stack<T>
//and if one is present, copies it to the result parameter, and removes it from the Stack<T>.
public bool TryPop (out T result);





























