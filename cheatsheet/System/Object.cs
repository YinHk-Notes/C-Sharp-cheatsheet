//Object
//Object class is the base class of every type in .NET.

using System;

public class Object

//Declare an object
Object o = new Object();  // Initializes a new instance of the Object class.


//Methods
public virtual bool Equals (object? obj);                // Determines whether the specified object is equal to the current object.
public static bool Equals (object? objA, object? objB);  // Determines whether the specified object instances are considered equal.
public virtual int GetHashCode ();                       // Serves as the default hash function and return a hash code for the current object. 
public Type GetType ();                                  // Gets the Type of the current instance.
protected object MemberwiseClone ();                     // Creates a shallow copy of the current Object. Return a shallow copy of the current Object.
public static bool ReferenceEquals (object? objA, object? objB);  // Determines whether the specified Object instances are the same instance.
public virtual string? ToString ();                               // Returns a string that represents the current object.






