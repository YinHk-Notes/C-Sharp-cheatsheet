//Implements the IList interface using an array whose size is dynamically increased as required.
//Inheritance: Object -> ArrayList
//Derived: System.Windows.Forms.DomainUpDown.DomainUpDownItemCollection
//Implements: ICollection, IEnumerable, IList, ICloneable

using System.Collections;

public class ArrayList : ICloneable, System.Collections.IList

//Declare an ArrayList
ArrayList list = new ArrayList();               //empty and has the default capacity.
ArrayList list = new ArrayList(ICollection c);  //contains elements copied from the specified collection and that has the same initial capacity as the number of elements copied.
ArrayList list = new ArrayList(int capacity);   //empty and has the specified initial capacity.

//Properties
public virtual int Capacity { get; set; }       //Gets or sets the number of elements that the ArrayLis can contain.
public virtual int Count { get; }               //Gets the number of elements in the ArrayList.
public virtual bool IsFixedSize { get; }        //Gets a value indicating whether the ArrayList has a fixed size.
public virtual bool IsReadOnly { get; }         //Gets a value indicating whether the ArrayList is read-only.
public virtual bool IsSynchronized { get; }     //Gets a value indicating whether access to the ArrayList is synchronized.
public virtual object? this[int index] { get; set; }    //Gets or sets the element at the specified index.


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

//Returns a list wrapper with a fixed size, where elements are allowed to be modified, but not added or removed.
public static System.Collections.ArrayList FixedSize (System.Collections.ArrayList list);
ArrayList.FixedSize(list);

public static System.Collections.IList FixedSize (System.Collections.IList list);
ArrayList.FixedSiz(list);

//Returns an enumerator that iterates through the ArrayList.
public virtual System.Collections.IEnumerator GetEnumerator ();
IEnumerator e = list.GetEnumerator();

//Returns an ArrayList which represents a subset of the elements in the source ArrayList
public virtual System.Collections.ArrayList GetRange (int index, int count);
ArrayList subList = list.GetRange(index, count);      //index: starting, count: number of elements in the range.

//Returns index of the first occurrence of a element in the ArrayList.
public virtual int IndexOf (object? value);
int i = list.IndexOf(value);

public virtual int IndexOf (object? value, int startIndex);
int i = list.IndexOf(value, start);   //start: starting index of the search

public virtual int IndexOf (object? value, int startIndex, int count);
int i = list.IndexOf(value, start, count);   //count: the number of elements in the section to search.

//Inserts an element into the ArrayList at the specified index
public virtual void Insert (int index, object? value);
list.Insert(index, value);

//Inserts the elements of a collection into the ArrayList at the specified index.
public virtual void InsertRange (int index, System.Collections.ICollection c);
list.InsertRange(index, c);

//Returns the zero-based index of the last occurrence of a value in the ArrayList or in a portion of it.
public virtual int LastIndexOf (object? value);
int i = list.LastIndexOf(value);

public virtual int LastIndexOf (object? value, int startIndex);
int i = list.LastIndexOf(value, start);    //start: starting index of the search

public virtual int LastIndexOf (object? value, int startIndex, int count);
int i = list.LastIndexOf(value, start, count);   //count: the number of elements in the section to search.

//Returns a list wrapper that is "read-only".
public static System.Collections.ArrayList ReadOnly (System.Collections.ArrayList list);
ArrayList listWrapper = ArrayList.ReadOnly(list);   //Returns a read-only ArrayList wrapper.

public static System.Collections.IList ReadOnly (System.Collections.IList list);
IList listWrapper = ArrayList.ReadOnly(list);

//Removes the first occurrence of a specific object from the ArrayList.
public virtual void Remove (object? obj);
list.Remove(value);

//Removes the element at the specified index of the ArrayList.
public virtual void RemoveAt (int index);
list.RemoveAt(index);

//Removes a range of elements from the ArrayList.
public virtual void RemoveRange (int index, int count);
list.RemoveRange(index, count);

//Returns an ArrayList whose elements are copies of the specified value.
public static System.Collections.ArrayList Repeat (object? value, int count);
ArrayList list = ArrayList.Repeat(value, count);

//Reverses the order of the elements in the ArrayList or a portion of it.
public virtual void Reverse ();
list.Reverse();

public virtual void Reverse (int index, int count);
list.Reverse(index, count);       //Reverses the order of the elements in the specified range 

//Copies the elements of a collection over a range of elements in the ArrayList.
public virtual void SetRange (int index, System.Collections.ICollection c);
list.SetRange(index, c);         

//Sorts the elements in the ArrayList or a portion of it.
public virtual void Sort ();
list.sort();

public virtual void Sort (System.Collections.IComparer? comparer);
list.sort(comparer);      //Sorts the elements in the entire ArrayList using the specified comparer.

public virtual void Sort (int index, int count, System.Collections.IComparer? comparer);
list.sort(index, count, comparer);      //Sorts the elements in a range of elements in ArrayList using the specified comparer.

//Returns a list wrapper that is synchronized (thread safe).
public static System.Collections.ArrayList Synchronized (System.Collections.ArrayList list);
ArrayList.Synchronized(list);

//Copies the elements of the ArrayList to a new array
public virtual object?[] ToArray ();
object?[] array = list.ToArray();

public virtual Array ToArray (Type type);          //The element Type of the destination array to create and copy elements to.
int[] array = (int[]) list.ToArray( typeof( integer ) );
String array = (String[]) list.ToArray( typeof( string ) );

//Sets the capacity to the actual number of elements in the ArrayList.
public virtual void TrimToSize ();
list.TrimToSize();

