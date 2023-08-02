## Generic Classes

Generic classes are defined using a type parameter in an angle brackets after the class name. The following defines a generic class.

Eg:
```cs
class DataStore<T>
{
    public T Data { get; set; }
}

```

You can also define multiple type parameters separated by a comma.
eg:
```cs
class KeyValuePair<TKey, TValue>
{
    public TKey Key { get; set; }
    public TValue Value { get; set; }
}
```

### Instantiating Generic Class
You can create an instance of generic classes by specifying an actual type in **angle brackets**.

eg:
```cs
DataStore<string> store = new DataStore<string>();
```


```cs
class BaseNode { }
class BaseNodeGeneric<T> { }

// concrete type
class NodeConcrete<T> : BaseNode { }

//closed constructed type
class NodeClosed<T> : BaseNodeGeneric<int> { }

//open constructed type
class NodeOpen<T> : BaseNodeGeneric<T> { }
```

```cs
//No error
class Node1 : BaseNodeGeneric<int> { }

//Generates an error
//class Node2 : BaseNodeGeneric<T> {}

//Generates an error
//class Node3 : T {}
```

```cs

class BaseNodeMultiple<T, U> { }

//No error
class Node4<T> : BaseNodeMultiple<T, int> { }

//No error
class Node5<T, U> : BaseNodeMultiple<T, U> { }

//Generates an error
//class Node6<T> : BaseNodeMultiple<T, U> {}
```



- A generic class increases the reusability. The more type parameters mean more reusable it becomes. However, too much generalization makes code difficult to understand and maintain.
- A generic class can be a base class to other generic or non-generic classes or abstract classes.
- A generic class can be derived from other generic or non-generic interfaces, classes, or abstract classes.


### ref
https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/generic-classes

https://www.tutorialsteacher.com/csharp/csharp-generics
