//Implements the IList interface using an array whose size is dynamically increased as required.
//Inheritance: Object -> ArrayList
//Derived: System.Windows.Forms.DomainUpDown.DomainUpDownItemCollection
//Implements: ICollection, IEnumerable, IList, ICloneable

using System.Collections;

//Declare an ArrayList
ArrayList list = new ArrayList();               //empty and has the default capacity.
ArrayList list = new ArrayList(ICollection c);  //contains elements copied from the specified collection and that has the same initial capacity as the number of elements copied.
ArrayList list = new ArrayList(int capacity);   //empty and has the specified initial capacity.


//Add an object o to the end of of the ArrayList, return the index of the value to be added.
public virtual int Add (object? value);
list.Add(value);

//Add the elements of an ICollection c to the end of the ArrayList.
public virtual void AddRange (System.Collections.ICollection c);
list.AddRange(c);

//Search a specific element in the sorted ArrayList or a portion of it, and returns the zero-based index of the element.
public virtual int BinarySearch (object? value);
list.BinarySearch(value);
  
public virtual int BinarySearch (object? value, System.Collections.IComparer? comparer);
list.BinarySearch(value, comparer);           //The IComparer implementation to use when comparing elements.              

public virtual int BinarySearch (int index, int count, object? value, System.Collections.IComparer? comparer);
list.BinarySearch(index, count, value, comparer);       
/*  
  index:  starting index of the range to search.
  count:  the length of the range to search.
 */

//Removes all elements from the ArrayList.
public virtual void Clear ();
list.Clear();

//Creates a shallow copy of the ArrayList, return a shallow copy of the ArrayList.
public virtual object Clone ();
list.Clone();

//Check whether an element is in the ArrayList, return true or false
public virtual bool Contains (object? item);
list.Contains(element);

//Copies the entire ArrayList to an Array
public virtual void CopyTo (Array array);
list.CopyTo(array);   //tarting at the beginning of the target array.

public virtual void CopyTo (Array array, int arrayIndex);
list.CopyTo(array, arrayIndex);  //index in array at which copying begins

public virtual void CopyTo (int index, Array array, int arrayIndex, int count);
list.CopyTo(index, array, arrayIndex, count);











