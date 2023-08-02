## Generic Constraints
C# allows you to use constraints to restrict client code to specify certain types while instantiating generic types. 

It will give a compile-time error if you try to instantiate a generic type using a type that is not allowed by the specified constraints.

You can specify **one or more constraints on the generic type** using the **`where`** clause after the generic type name.


Syntax:
```cs
GenericTypeName<T> where T  : contraint1, constraint2
```

eg:
```cs
class DataStore<T> where T : class
{
    public T Data { get; set; }
}


/*

Above, we applied the class constraint,
which means only a reference type can be passed as an argument while creating the DataStore class object.
So, you can pass reference types such as class, interface, delegate, or array type.
Passing value types will give a compile-time error, so we cannot pass primitive data types or struct types.

DataStore<string> store = new DataStore<string>(); // valid
DataStore<MyClass> store = new DataStore<MyClass>(); // valid
DataStore<IMyInterface> store = new DataStore<IMyInterface>(); // valid
DataStore<IEnumerable> store = new DataStore<IMyInterface>(); // valid
DataStore<ArrayList> store = new DataStore<ArrayList>(); // valid
//DataStore<int> store = new DataStore<int>(); // compile-time error 


 */
```

### ref
https://www.tutorialsteacher.com/csharp/constraints-in-generic-csharp


https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/constraints-on-type-parameters

