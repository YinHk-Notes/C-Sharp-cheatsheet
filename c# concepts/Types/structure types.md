## Structure types
A structure type (or struct type) is a value type that can encapsulate data and related functionality. It can contain a parameterized constructor, static constructor, constants, fields, methods, properties, indexers, operators, events, and nested types.

```cs
struct Coordinate
{
    public int x;
    public int y;
}

Coordinate point = new Coordinate();
```

- struct can include constructors, constants, fields, methods, properties, indexers, operators, events & nested types.
- struct cannot include a parameterless constructor or a destructor.
- struct can implement interfaces, same as class.
- struct cannot inherit another structure or class, and it cannot be the base of a class.
- struct members cannot be specified as abstract, sealed, virtual, or protected.
