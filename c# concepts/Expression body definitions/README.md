### Expression body definitions
You can use an expression body definition whenever the logic for any supported member, such as a method or property, consists of a single expression. Expression-bodied members provide a minimal and concise syntax to define properties and methods. It helps to eliminate boilerplate code and helps writing code that is more readable.

syntax:
```
member => expression;
```
Expression body definitions can be used with the following type members:

- Method
- Read-only property
- Property
- Constructor
- Finalizer
- Indexer


An expression-bodied method consists of a single expression that returns a value whose type matches the method's return type, or, for methods that return void, that performs some operation.
```cs
int GetRectangleArea(int length, int breadth) 
{
    return length * breadth;
} 

// can be written as 
int GetRectangleArea(int length, int breadth) => length * breadth;
```
For Read-only properties, you can use expression body definition to implement a read-only property. 
```cs
PropertyType PropertyName => expression;
```

```cs
public class Location
{
   private string locationName;

   public Location(string name)
   {
      locationName = name;
   }

   public string Name => locationName;
}
```

You can use expression body definitions to implement property `get` and `set` accessors.
```cs
public class Location
{
   private string locationName;

   public Location(string name) => Name = name;

   public string Name
   {
      get => locationName;
      set => locationName = value;
   }
}
```
An expression body definition for a constructor typically consists of a single assignment expression or a method call that handles the constructor's arguments or initializes instance state.
```cs
public class Location
{
   private string locationName;
   public Location(string name) => Name = name;
}
```
An expression body definition for a finalizer typically contains cleanup statements, such as statements that release unmanaged resources.
```cs
public class Destroyer
{
   public override string ToString() => GetType().Name;

   ~Destroyer() => Console.WriteLine($"The {ToString()} finalizer is executing.");
}
```

https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/expression-bodied-members
