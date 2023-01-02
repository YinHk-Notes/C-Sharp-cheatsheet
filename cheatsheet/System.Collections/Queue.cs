//Represents a first-in, first-out collection of objects.
//Inheritance: Object -> Queue
//Implements: ICollection, IEnumerable, ICloneable

using System.Collections;

public class Queue : ICloneable, System.Collections.ICollection

//Declare Queue
Queue q = new Queue();                                    //empty and has the default initial capacity.
Queue q = new Queue(System.Collections.ICollection c);    //copied from the specified collection.
Queue q = new Queue(int capacity);                                    //empty and has the specific capacity.







