//Represents a simple last-in-first-out (LIFO) non-generic collection of objects.
//Implements ICollection, IEnumerable, ICloneable
//Inheritance: Object -> Stack

using System.Collections;

public class Stack : ICloneable, System.Collections.ICollection

//Declare Stack
Stack s = new Stack();   //empty and has the default initial capacity.
Stack s = new Stack(System.Collections.ICollection col); //contains elements copied from the specified collection with the same initial capacity
Stack s = new Stack(int initialCapacity);  //empty and has the specific capacity.






