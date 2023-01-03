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

//














