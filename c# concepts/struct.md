## struct

**`struct`** is the value type data type that represents data structures. It can contain a parameterized constructor, static constructor, constants, fields, methods, properties, indexers, operators, events, and nested types.

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
