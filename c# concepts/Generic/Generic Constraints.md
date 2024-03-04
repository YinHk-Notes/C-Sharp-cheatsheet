## Generic Constraints
C# allows you to use constraints to restrict client code to specify certain types while instantiating generic types. 

It will give a compile-time error if you try to instantiate a generic type using a type that is not allowed by the specified constraints.

> Apply constraints to generics using **`where`** keyword.

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


### Multiple Generic Constraints

You can apply **multiple generic constraints**


**Multiple constraints can be applied to the same type parameter**, and the constraints themselves can be **generic types**, as follows:

```cs
class EmployeeList<T> where T : Employee, IEmployee, System.IComparable<T>, new()
{
    // ...
}
```

**Constraining multiple parameters**.  You can apply constraints to multiple parameters, and multiple constraints 

eg:
```cs
class Base { }
class Test<T, U>
    where U : struct
    where T : Base, new()
{ }

```

eg:
```cs
//Declaring multiple generic with single class names
public static void MultipleGenericExample2<T1, T2>() where T1 : ModelExample3, new() where T2 : ModelExample2, new()
{
    T1 t1 = new T1();
    T2 t2 = new T2();
}
```





| Constraint | Description |
| --- | --- |
| `where T : struct` | The type argument must be a non-nullable value type. For information about nullable value types, see Nullable value types. Because all value types have an accessible parameterless constructor, the struct constraint implies the new() constraint and can't be combined with the new() constraint. You can't combine the struct constraint with the unmanaged constraint. |
| `where T : class` | The type argument must be a reference type. This constraint applies also to any class, interface, delegate, or array type. In a nullable context, T must be a non-nullable reference type. |
| `where T : class?` | The type argument must be a reference type, either nullable or non-nullable. This constraint applies also to any class, interface, delegate, or array type. |
| `where T : notnull` | The type argument must be a non-nullable type. The argument can be a non-nullable reference type or a non-nullable value type. |
| `where T : default` | This constraint resolves the ambiguity when you need to specify an unconstrained type parameter when you override a method or provide an explicit interface implementation. The default constraint implies the base method without either the class or struct constraint. For more information, see the default constraint spec proposal. |
| `where T : unmanaged` | The type argument must be a non-nullable unmanaged type. The unmanaged constraint implies the struct constraint and can't be combined with either the struct or new() constraints. |
| `where T : new()` | The type argument must have a public parameterless constructor. When used together with other constraints, the new() constraint must be specified last. The new() constraint can't be combined with the struct and unmanaged constraints. |
| `where T : <base class name>` | The type argument must be or derive from the specified base class. In a nullable context, T must be a non-nullable reference type derived from the specified base class. |
| `where T : <base class name>?` | The type argument must be or derive from the specified base class. In a nullable context, T may be either a nullable or non-nullable type derived from the specified base class. |
| `where T : <interface name>` | The type argument must be or implement the specified interface. Multiple interface constraints can be specified. The constraining interface can also be generic. In a nullable context, T must be a non-nullable type that implements the specified interface. |
| `where T : <interface name>?` | The type argument must be or implement the specified interface. Multiple interface constraints can be specified. The constraining interface can also be generic. In a nullable context, T may be a nullable reference type, a non-nullable reference type, or a value type. T may not be a nullable value type. |
| `where T : U` | The type argument supplied for T must be or derive from the argument supplied for U. In a nullable context, if U is a non-nullable reference type, T must be non-nullable reference type. If U is a nullable reference type, T may be either nullable or non-nullable. |



### ref
https://www.tutorialsteacher.com/csharp/constraints-in-generic-csharp


https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/constraints-on-type-parameters

https://medium.com/swlh/multiple-generic-constraints-net-1973fbaaf8de

