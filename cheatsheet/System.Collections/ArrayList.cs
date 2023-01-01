// Implements the IList interface using an array whose size is dynamically increased as required.
// Inheritance: Object -> ArrayList
// Derived: System.Windows.Forms.DomainUpDown.DomainUpDownItemCollection
// Implements: ICollection, IEnumerable, IList, ICloneable

using System.Collections;

// Declare an ArrayList
ArrayList list = new ArrayList();               //empty and has the default capacity.
ArrayList list = new ArrayList(ICollection c);  //contains elements copied from the specified collection and that has the same initial capacity as the number of elements copied.
ArrayList list = new ArrayList(int capacity);   //empty and has the specified initial capacity.


//Add an object o to the end of of the ArrayList, return the index of the value to be added.
public virtual int Add (object? value);
list.Add(object value);

//Add the elements of an ICollection c to the end of the ArrayList.
list.AddRange(ICollection c);

//Search a specific element in the sorted ArrayList or a portion of it, and returns the zero-based index of the element.
public virtual int BinarySearch (object? value);
list.BinarySearch()
  


