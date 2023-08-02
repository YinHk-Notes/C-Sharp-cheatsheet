//List<T>
//Represents a strongly typed list of objects that can be accessed by index. Provides methods to search, sort, and manipulate lists.

using System.Collections.Generic;

public class List<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IList<T>, System.Collections.Generic.IReadOnlyCollection<T>, System.Collections.Generic.IReadOnlyList<T>, System.Collections.IList


//Constructors
public List ();
public List (System.Collections.Generic.IEnumerable<T> collection);  // contains elements copied from the specified collection and has sufficient capacity to accommodate the number of elements copied.
public List (int capacity);                    // Initializes a new instance of the List<T> class that is empty and has the specified initial capacity.


//Declare list
List<T> list = new List<T>();
List<T> list = new List<T>(collection);
List<T> list = new List<T>(length);


//Properties
public int Capacity { get; set; }  //Gets or sets the total number of elements 
public int Count { get; }          //Gets the number of elements contained in the List<T>.
public T this[int index] { get; set; }  //Gets or sets the element at the specified index.

//Methods

//Adds an object to the end of the List<T>.
public void Add (T item);

//Adds the elements of the specified collection to the end of the List<T>.
public void AddRange (System.Collections.Generic.IEnumerable<T> collection);

//Returns a read-only ReadOnlyCollection<T> wrapper for the current collection.
public System.Collections.ObjectModel.ReadOnlyCollection<T> AsReadOnly ();

//Searches the entire sorted List<T> for an element using the default comparer and returns the zero-based index of the element.
public int BinarySearch (T item);

//Removes all elements from the List<T>.
public void Clear ();

//Determines whether an element is in the List<T>.
public bool Contains (T item);

//Converts the elements in the current List<T> to another type, and returns a list containing the converted elements.
public System.Collections.Generic.List<TOutput> ConvertAll<TOutput> (Converter<T,TOutput> converter);

//Copies the List<T> or a portion of it to an array.
public void CopyTo (T[] array, int arrayIndex); //starting at the specified index of the target array.

//Ensures that the capacity of this list is at least the specified capacity.
//f the current capacity is less than capacity, it is successively increased to twice the current capacity 
//until it is at least the specified capacity.
public int EnsureCapacity (int capacity);

//Determines whether the List<T> contains elements that match the conditions defined by the specified predicate.
public bool Exists (Predicate<T> match);

//Searches for an element that matches the conditions defined by the specified predicate, and returns the first occurrence within the entire List<T>.
public T? Find (Predicate<T> match);

//Retrieves all the elements that match the conditions defined by the specified predicate.
public System.Collections.Generic.List<T> FindAll (Predicate<T> match);

//Searches for an element that matches the conditions defined by the specified predicate
public int FindIndex (int startIndex, int count, Predicate<T> match);

//Searches for an element that matches the conditions defined by the specified predicate, and returns the last occurrence within the entire List<T>.
public T? FindLast (Predicate<T> match);

//Searches for an element that matches the conditions defined by the specified predicate, and returns the zero-based index of the last occurrence within the entire List<T>.
public int FindLastIndex (Predicate<T> match);

//Performs the specified action on each element of the List<T>
public void ForEach (Action<T> action);









































