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




A **`struct`** object can be created with or without the new operator, same as primitive type variables.

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




### ref
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/struct

https://www.programiz.com/csharp-programming/struct

https://www.tutorialsteacher.com/csharp/csharp-struct
