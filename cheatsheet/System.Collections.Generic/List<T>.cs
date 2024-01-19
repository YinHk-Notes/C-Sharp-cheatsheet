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

//eg: declare from collection elements
string[] input = { "Brachiosaurus", "Amargasaurus", "Mamenchisaurus" };
List<string> dinosaurs = new List<string>(input);

var data = new List<int> { 1, -2, 3, 0, 2, -1 };


//Properties
public int Capacity { get; set; }  //Gets or sets the total number of elements. Capacity is the number of elements that the List can store. 
public int Count { get; }          //Gets the number of elements contained in the List<T>. Count is the number of elements that are actually in the List.
public T this[int index] { get; set; }  //Gets or sets the element at the specified index.


//Count vs Capacity
//Capacity is always greater than or equal to Count. 
//If Count exceeds Capacity while adding elements, 
//the capacity is increased by automatically reallocating the internal array before copying the old elements and 
//adding the new elements. Capacity is the number of elements that the List<T> can store before resizing is required, 
//while Count is the number of elements that are actually in the List<T>.


//Iteration in list
foreach (var i in list) { //... };

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
public void ForEach (Action<T> enumerate);

//Returns an enumerator that iterates through the List<T>.
public System.Collections.Generic.List<T>.Enumerator GetEnumerator ();

//Creates a shallow copy of a range of elements in the source List<T>.
public System.Collections.Generic.List<T> GetRange (int index, int count);

//Returns the zero-based index of the first occurrence of a value in the List<T>
public int IndexOf (T item, int index);

//Inserts an element into the List<T> at the specified index.
public void Insert (int index, T item);

//Inserts the elements of a collection into the List<T> at the specified index.
public void InsertRange (int index, System.Collections.Generic.IEnumerable<T> collection);

//Searches for the specified object and returns the zero-based index of the last occurrence
public int LastIndexOf (T item);

//emoves the first occurrence of a specific object
public bool Remove (T item);

//Removes all the elements that match the conditions defined by the specified predicate. 
//Return the number of elements removed from the List<T>
public int RemoveAll (Predicate<T> match);

//Removes the element at the specified index of the List<T>. 
public void RemoveAt (int index);

//Removes a range of elements from the List<T>
public void RemoveRange (int index, int count);

//Reverses the order of the elements in the List<T> or a portion of it.
public void Reverse ();
public void Reverse (int index, int count);  //Reverses the order of the elements in the specified range.

//orts the elements in the entire List<T> using the specified Comparison<T>.
public void Sort (Comparison<T> comparison);

//Copies the elements of the List<T> to a new array.
public T[] ToArray ();

//Sets the capacity to the actual number of elements in the List<T>, if that number is less than a threshold value.
public void TrimExcess ();

//Determines whether every element in the List<T> matches the conditions defined by the specified predicate.
public bool TrueForAll (Predicate<T> match);



























