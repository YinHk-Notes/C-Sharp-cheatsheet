//IEnumerable
//Exposes an enumerator, which supports a simple iteration over a non-generic collection.


using System.Collections;

public interface IEnumerable


//Methods

/// <returns> Returns an enumerator that iterates through a collection </returns>
public System.Collections.IEnumerator GetEnumerator ();     

/// <summary> Casts the elements of an IEnumerable to the specified type </summary>
/// <param name="TResult"/> The type to cast the elements of source to </param>
/// <param name="source"/> The IEnumerable that contains the elements to be cast to type TResult. </param>
public static System.Collections.Generic.IEnumerable<TResult> Cast<TResult> (this System.Collections.IEnumerable source);
  
/// <summary> Filters the elements of an IEnumerable based on a specified type </summary>
/// <param name="TResult"/> The type to filter the elements of the sequence on </param>
/// <param name="source"/> The IEnumerable whose elements to filter </param>
public static System.Collections.Generic.IEnumerable<TResult> OfType<TResult> (this System.Collections.IEnumerable source);






