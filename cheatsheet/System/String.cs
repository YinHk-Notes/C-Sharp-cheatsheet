//String
//Represents text as a sequence of UTF-16 code units.
//https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-7.0

using System.Collections;

public sealed class String : ICloneable, IComparable, IComparable<string>, IConvertible, IEquatable<string>, System.Collections.Generic.IEnumerable<char>

//Constructors
public String (char[]? value);
public String (char c, int count); //Initializes a new instance of the String class to the value indicated by a specified Unicode character repeated a specified number of times.
public String (char[] value, int startIndex, int length); 


//Field
public static readonly string Empty; //Represents the empty string. This field is read-only.

//Properties
public char this[int index] { get; }  //Gets the Char object at a specified position in the current String object.
public int Length { get; }            //Gets the number of characters in the current String object.



//Methods

//Returns a reference to this instance of String.
public object Clone ();      

//Compares this instance with a specified String object and indicates whether this instance precedes, follows, or appears in the same position in the sort order as the specified string.
public int CompareTo (string? strB);

//Compares this instance with a specified Object and indicates whether this instance precedes, follows, or appears in the same position in the sort order as the specified Object.
public int CompareTo (object? value);


//concat
public static string Concat (string? str0, string? str1, string? str2, string? str3);
public static string Concat (string? str0, string? str1, string? str2);
public static string Concat (string? str0, string? str1);
public static string Concat (object? arg0, object? arg1);
public static string Concat (object? arg0, object? arg1, object? arg2);
public static string Concat (object? arg0); //Creates the string representation of a specified object.

//contains
public bool Contains (char value); //Returns a value indicating whether a specified character 
public bool Contains (string value);
public bool Contains (char value, StringComparison comparisonType);
public bool Contains (string value, StringComparison comparisonType);


//Creates a new instance of String with the same value as a specified String.
[System.Obsolete("This API should not be used to create mutable strings. See https://go.microsoft.com/fwlink/?linkid=2084035 for alternatives.")]
public static string Copy (string str);









