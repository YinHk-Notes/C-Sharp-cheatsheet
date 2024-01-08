## Partial Classes
There are several situations when splitting a class definition is desirable:

-   When working on large projects, spreading a class over separate files enables multiple programmers to work on it at the same time.
-   When working with automatically generated source, code can be added to the class without having to recreate the source file. Visual Studio uses this approach when it creates Windows Forms, Web service wrapper code, and so on. You can create code that uses these classes without having to modify the file created by Visual Studio.
-   When using source generators to generate additional functionality in a class.


Eg:
```cs
public partial class Employee
{
    public void DoWork()
    {
    }
}

public partial class Employee
{
    public void GoToLunch()
    {
    }
}
```

The `partial` keyword indicates that other parts of the **class**, **struct**, or **interface** can be defined in the namespace. All the parts must use the `partial` keyword. 

> All the parts must be available at compile time to form the final type. All the parts must have the same accessibility, such as `public`, `private`, and so on.

> If any part is declared `abstract`, then the whole type is considered `abstract`. If any part is declared `sealed`, then the whole type is considered `sealed`. If any part declares a base type, then the whole type inherits that class.


At compile time, attributes of partial-type definitions are merged. For example, consider the following declarations:

Eg:
```cs
[SerializableAttribute]
partial class Moon { }

[ObsoleteAttribute]
partial class Moon { }

```

```cs

[SerializableAttribute]
[ObsoleteAttribute]
class Moon {}

```

```cs
partial class Earth : Planet, IRotate { }
partial class Earth : IRevolve { }

//equivalent to
class Earth : Planet, IRotate, IRevolve { }

```


### Restrictions
- All partial-type definitions meant to be parts of the same type must be modified with `partial`. 
    ```cs
    public partial class A { }
    //public class A { }  // Error, must also be marked partial
    ```
- The `partial` modifier can only appear immediately before the keywords `class`, `struct`, or `interface`.
- Nested partial types are allowed in partial-type definitions as illustrated in the following example:
  
    ```cs
    partial class ClassWithNestedClass
    {
        partial class NestedClass { }
    }

    partial class ClassWithNestedClass
    {
        partial class NestedClass { }
    }
    ```
- All partial-type definitions meant to be parts of the same type must be defined in the same assembly and the same module (.exe or .dll file). Partial definitions cannot span multiple modules.
- The class name and generic-type parameters must match on all partial-type definitions. Generic types can be partial. Each partial declaration must use the same parameter names in the same order.



### ref
https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/partial-classes-and-methods

https://www.programiz.com/csharp-programming/partial-class-and-methods




