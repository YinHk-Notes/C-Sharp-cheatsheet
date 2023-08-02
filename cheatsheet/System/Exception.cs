//Exception
//Represents errors that occur during application execution.
//https://learn.microsoft.com/en-us/dotnet/api/system.exception?view=net-7.0

using System

public class Exception : System.Runtime.Serialization.ISerializable


//Constructors
public Exception ();    //Initializes a new instance of the Exception class
public Exception (string? message);   //initializes a new instance of the Exception class with a specified error message.


//Properties
public virtual string Message { get; }  // Gets a message that describes the current exception.
public virtual string? Source { get; set; } // Gets or sets the name of the application or the object that causes the error.
public virtual System.Collections.IDictionary Data { get; } //Gets a collection of key/value pairs that provide additional user-defined information about the exception.




