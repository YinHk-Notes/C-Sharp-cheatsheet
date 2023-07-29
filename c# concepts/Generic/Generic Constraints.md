## Generic Constraints
C# allows you to use constraints to restrict client code to specify certain types while instantiating generic types. 

It will give a compile-time error if you try to instantiate a generic type using a type that is not allowed by the specified constraints.

You can specify **one or more constraints on the generic type** using the **`where`** clause after the generic type name.


Syntax:
```cs
GenericTypeName<T> where T  : contraint1, constraint2
```



### ref
https://www.tutorialsteacher.com/csharp/constraints-in-generic-csharp


