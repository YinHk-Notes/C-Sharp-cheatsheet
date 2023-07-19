## struct

**`struct`** is the value type data type that represents data structures. It can contain a parameterized constructor, static constructor, constants, fields, methods, properties, indexers, operators, events, and nested types.

Structs share most of the same syntax as classes,but more limited than classes in the following ways:

- Within a struct declaration, fields cannot be initialized unless they are declared as **`const`** or **`static`**.
- A struct **cannot declare a parameterless constructor** (a constructor without parameters) or a finalizer.
- Structs are **copied on assignment**. When a struct is assigned to a new variable, **all the data** is **copied**, and any modification to the new copy does not change the data for the original copy. This is important to remember when working with collections of value types such as Dictionary<string, myStruct>.
- Structs are **value types**, unlike classes, which are reference types.
- Unlike classes, structs can be instantiated(creating object) without using a **`new`** operator.
- Structs can declare **constructors** that **have parameters**.
- Structs **do not support inheritance**, but they can **implement interfaces**.
- A struct **cannot be null**, and a struct variable cannot be assigned null unless the variable is declared as a **nullable type**.





### Declaration

eg:
```cs
struct Coordinate
{
    public int x;
    public int y;
}
```




A **`struct`** object can be created with or without the **`new`** operator, same as primitive type variables.

```cs
struct Coordinate
{
    public int x;
    public int y;
}

Coordinate point = new Coordinate();
Console.WriteLine(point.x); //output: 0  
Console.WriteLine(point.y); //output: 0
```

If you declare a variable of **`struct`** type without using **`new`** keyword, it does not call any constructor, so all the members remain unassigned. Therefore, you must assign values to each member before accessing them, otherwise, it will give a compile-time error.

```cs
struct Coordinate
{
    public int x;
    public int y;
}

Coordinate point;
Console.Write(point.x); // Compile time error  

point.x = 10;
point.y = 20;
Console.Write(point.x); //output: 10  
Console.Write(point.y); //output: 20
```



### ref
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/struct

https://www.programiz.com/csharp-programming/struct

https://www.tutorialsteacher.com/csharp/csharp-struct
