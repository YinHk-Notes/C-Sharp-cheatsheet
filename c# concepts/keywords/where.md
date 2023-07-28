## `where`


### generic type constraint
The `where` clause in a generic definition specifies constraints on the types that are used as arguments for type parameters in a generic type, method, delegate, or local function. Constraints can specify interfaces, base classes, or require a generic type to be a reference, value, or unmanaged type. They declare capabilities that the type argument must have, and must be placed after any declared base class or implemented interfaces.


```cs
public class AGenericClass<T> where T : IComparable<T> { }

```

```cs
public class UsingEnum<T> where T : System.Enum { }

public class UsingDelegate<T> where T : System.Delegate { }

public class Multicaster<T> where T : System.MulticastDelegate { }
```

### ref
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/where-generic-type-constraint


