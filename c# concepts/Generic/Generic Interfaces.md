## Generic Interfaces
It's often useful to define interfaces either for generic collection classes, or for the generic classes that represent items in the collection.


> When an interface is specified as a constraint on a type parameter, only types that implement the interface can be used.

```cs
interface myInterface<T>
{
  ...
}
```
An interface can define more than one type parameter
```cs
interface IDictionary<K, V>
{
}
```
The rules of inheritance that apply to classes also apply to interfaces:
```cs
interface IMonth<T> { }

interface IJanuary : IMonth<int> { }  //No error
interface IFebruary<T> : IMonth<int> { }  //No error
interface IMarch<T> : IMonth<T> { }    //No error
                                       //interface IApril<T>  : IMonth<T, U> {}  //Error
```

Generic classes can implement generic interfaces or closed constructed interfaces as long as the class parameter list supplies all arguments required by the interface
```cs
interface IBaseInterface1<T> { }
interface IBaseInterface2<T, U> { }

class SampleClass1<T> : IBaseInterface1<T> { }          //No error
class SampleClass2<T> : IBaseInterface2<T, string> { }  //No error
```

Multiple interfaces can be specified as constraints on a single type, as follows:
```cs
class Stack<T> where T : System.IComparable<T>, IEnumerable<T>
{
}

```

### ref
https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/generic-interfaces
