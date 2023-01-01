// Implements the IList interface using an array whose size is dynamically increased as required.
// Inheritance: Object -> ArrayList
// Derived: System.Windows.Forms.DomainUpDown.DomainUpDownItemCollection
// Implements: ICollection, IEnumerable, IList, ICloneable

using System.Collections;

// Declare an ArrayList
ArrayList list = new ArrayList();   
ArrayList list = new ArrayList(ICollection);  //contains elements copied from the specified collection and that has the same initial capacity as the number of elements copied.


//Add an object o to the end of of the ArrayList
list.Add(Object o);

//Add the elements of an ICollection c to the end of the ArrayList.
list.AddRange(ICollection c);



