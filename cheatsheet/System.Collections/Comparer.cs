//Compares two objects for equivalence, where string comparisons are case-sensitive.
//Inheritance: Object -> Comparer
//Implements: IComparer -> ISerializable


using System.Collections;

public sealed class Comparer : System.Collections.IComparer, System.Runtime.Serialization.ISerializable


//Declare compare
Comparer myComp = new Comparer( System.Globalization.CultureInfo culture );  //Initializes a new instance of the Comparer class using the specified CultureInfo.


//Field
public static readonly System.Collections.Comparer Default; //Represents an instance of Comparer that is associated with the CurrentCulture of the current thread. This field is read-only.
public static readonly System.Collections.Comparer DefaultInvariant;


//Methods
public int Compare (object? a, object? b); //Performs a case-sensitive comparison of two objects of the same type and returns a value indicating whether one is less than, equal to, or greater than the other.
// < 0 : a is less than b.
// = 0 : a equals b.
// > 0: a is greater than b.


