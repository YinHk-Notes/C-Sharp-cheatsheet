//Provides methods for creating, manipulating, searching, and sorting arrays
//Inheritance: Object -> Array
//Implements: ICollection, IEnumerable, IList, IStructuralComparable, IStructuralEquatable, ICloneable

using System;

public abstract class Array : ICloneable, System.Collections.IList, System.Collections.IStructuralComparable, System.Collections.IStructuralEquatable


//Properties
public bool IsFixedSize { get; }     //Gets a value indicating whether the Array has a fixed size.
public bool IsReadOnly { get; }      //Gets a value indicating whether the Array is read-only.
public bool IsSynchronized { get; }  //Gets a value indicating whether access to the Array is synchronized.
public int Length { get; }           //Gets the total number of elements in all the dimensions of the Array.
public long LongLength { get; }      //Gets a 64-bit integer that represents the total number of elements in all the dimensions of the Array.
public static int MaxLength { get; } //Gets the maximum number of elements that may be contained in an array.
public int Rank { get; }             //Gets the rank (number of dimensions) of the Array.


//Returns a read-only wrapper for the specified array.
public static System.Collections.ObjectModel.ReadOnlyCollection<T> AsReadOnly<T> (T[] array);

//Searches a one-dimensional sorted Array for a value, using a binary search algorithm.
public static int BinarySearch (Array array, object? value);
public static int BinarySearch (Array array, object? value, System.Collections.IComparer? comparer); //using the specified IComparer interface
public static int BinarySearch (Array array, int index, int length, object? value); //index: starting, length: The length of the range to search.
public static int BinarySearch (Array array, int index, int length, object? value, System.Collections.IComparer? comparer);
public static int BinarySearch (Array array, int index, int length, object? value, System.Collections.IComparer? comparer);
public static int BinarySearch<T> (T[] array, T value, System.Collections.Generic.IComparer<T>? comparer);
public static int BinarySearch<T> (T[] array, int index, int length, T value);
public static int BinarySearch<T> (T[] array, int index, int length, T value, System.Collections.Generic.IComparer<T>? comparer);

//Clears the contents of an array.
public static void Clear (Array array);

//Creates a shallow copy of the Array.
public object Clone ();

//opies a range of elements from an Array starting at the specified source index and pastes them to another Array starting at the specified destination index. Guarantees that all changes are undone if the copy does not succeed completely.
public static void ConstrainedCopy (Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length);

//Converts an array of one type to an array of another type.
public static TOutput[] ConvertAll<TInput,TOutput> (TInput[] array, Converter<TInput,TOutput> converter);

//Converts an array of one type to an array of another type.
public static TOutput[] ConvertAll<TInput,TOutput> (TInput[] array, Converter<TInput,TOutput> converter);

//Copies a range of elements in one Array to another Array and performs type casting and boxing as required.
public static void Copy (Array sourceArray, Array destinationArray, int length);

//Copies all the elements of the current one-dimensional array to the specified one-dimensional array.
public void CopyTo (Array array, int index);
public void CopyTo (Array array, long index);

//Returns an empty array.
public static T[] Empty<T> ();

//Determines whether the specified array contains elements that match the conditions defined by the specified predicate
public static bool Exists<T> (T[] array, Predicate<T> match);    //The Predicate<T> that defines the conditions of the elements to search for.

//Assigns the given value of type to the elements of the specified array which are within the range of startIndex (inclusive) and the next count number of indices.
public static void Fill<T> (T[] array, T value, int startIndex, int count);

//Assigns the given value of type T to each element of the specified array.
public static void Fill<T> (T[] array, T value);

//Searches for an element and returns the first occurrence.
public static T? Find<T> (T[] array, Predicate<T> match);      //The Predicate<T> that defines the conditions of the elements to search for.

//Retrieves all the elements that match the conditions defined by the specified predicate.
public static T[] FindAll<T> (T[] array, Predicate<T> match);

//Searches for an element that matches the conditions defined by a specified predicate, and returns the index of the first occurrence.
public static int FindIndex<T> (T[] array, Predicate<T> match);
public static int FindIndex<T> (T[] array, int startIndex, Predicate<T> match);  
public static int FindIndex<T> (T[] array, int startIndex, int count, Predicate<T> match);

//Searches for an element that matches the conditions defined by the specified predicate, and returns the last occurrence.
public static T? FindLast<T> (T[] array, Predicate<T> match);

//Searches for an element that matches the conditions defined by a specified predicate, and returns the index of the last occurrence.
public static int FindLastIndex<T> (T[] array, Predicate<T> match);
public static int FindLastIndex<T> (T[] array, int startIndex, Predicate<T> match);
public static int FindLastIndex<T> (T[] array, int startIndex, int count, Predicate<T> match);

//Performs the specified action on each element of the specified array.
public static void ForEach<T> (T[] array, Action<T> action);

//Returns an IEnumerator for the Array.
public System.Collections.IEnumerator GetEnumerator ();

//Gets a 32-bit integer that represents the number of elements in the specified dimension of the Array.
public int GetLength (int dimension);

//Gets a 64-bit integer that represents the number of elements in the specified dimension of the Array.
public long GetLongLength (int dimension);
  
//Gets the index of the first element of the specified dimension in the array.
public int GetLowerBound (int dimension);

//Gets the index of the last element of the specified dimension in the array.
public int GetUpperBound (int dimension);

//Gets the value of the specified element in the current Array.
public object? GetValue (int index);

//Sets the specified element in the current Array to the specified value.
public void SetValue (object? value, int index);

//Searches for the specified object and returns the index of its first occurrence
public static int IndexOf (Array array, object? value);
public static int IndexOf<T> (T[] array, T value);

//Returns the index of the last occurrence of a value
public static int LastIndexOf (Array array, object? value);
public static int LastIndexOf<T> (T[] array, T value);

//Changes the number of elements of an array to the specified new size.
public static void Resize<T> (ref T[]? array, int newSize);

//Reverses the order of the elements in a one-dimensional Array or in a portion of the Array.
public static void Reverse (Array array);
public static void Reverse (Array array, int index, int length);  ////Reverses the sequence of a subset of the elements in the array.
public static void Reverse<T> (T[] array);
public static void Reverse<T> (T[] array, int index, int length);

//Sorts the elements in an array.
public static void Sort (Array array);   //using the IComparable implementation.
public static void Sort (Array array, System.Collections.IComparer? comparer);  //using the specified IComparer.
public static void Sort (Array keys, Array? items, int index, int length);  //using the IComparable implementation of each key.
public static void Sort (Array keys, Array? items, int index, int length, System.Collections.IComparer? comparer); //using the specified IComparer.
public static void Sort<T> (T[] array);
public static void Sort<T> (T[] array, System.Collections.Generic.IComparer<T>? comparer);
public static void Sort<T> (T[] array, Comparison<T> comparison);


















