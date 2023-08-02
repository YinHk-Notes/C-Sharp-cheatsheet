## Generic Delegates

A delegate can define its own type parameters. Code that references the generic delegate can specify the type argument to create a closed constructed type, just like when instantiating a generic class or calling a generic method

Eg:
```cs
public delegate void Del<T>(T item);
public static void Notify(int i) { }

Del<int> m1 = new Del<int>(Notify);
```
```cs
Del<int> m2 = Notify;
```

```cs
class Stack<T>
{
    public delegate void StackDelegate(T[] items);
}

```

### ref 
https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/generic-delegates

