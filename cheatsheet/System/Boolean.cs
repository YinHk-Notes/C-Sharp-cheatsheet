//Boolean

//Field
public static readonly string FalseString; //Represents the Boolean value false as a string.
public static readonly string TrueString; //Represents the Boolean value true as a string.

//Methods

// < 0 : This instance is false and value is true
// = 0 : This instance and value are equal (either both are true or both are false).
// > 0 : This instance is true and value is false.
public int CompareTo (bool value); 

//Returns a value indicating whether this instance is equal to a specified Boolean object.
public bool Equals (bool obj);

//Returns the hash code for this instance.
public override int GetHashCode ();

//Returns the type code for the Boolean value type.
public TypeCode GetTypeCode ();

//Converts the specified span representation of a logical value to its Boolean equivalent.
public static bool Parse (ReadOnlySpan<char> value);

//Converts the value of this instance to its equivalent string representation (either "True" or "False").
public string ToString (IFormatProvider? provider);




