//Enum
//Provides the base class for enumerations.

using System.Collections;

public abstract class Enum : ValueType, IComparable, IConvertible, IFormattable

//Enum Constructor
protected Enum ();



//Methods

//Compares this instance to a specified object and returns an indication of their relative values.
//Less than zero	The value of this instance is less than the value of target.
//Zero	The value of this instance is equal to the value of target.
//Greater than zero	The value of this instance is greater than the value of target, or target is null.
public int CompareTo (object? target);  

//Returns a value indicating whether this instance is equal to a specified object.
public override bool Equals (object? obj);


//Retrieves an array of the values of the constants in a specified enumeration.
public static Array GetValues (Type enumType);

//Retrieves an array of the values of the constants in a specified enumeration type.
public static TEnum[] GetValues<TEnum> () where TEnum : struct;


