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

Structs share most of the same syntax as classes,but more limited than classes in the following ways:

- Within a struct declaration, fields cannot be initialized unless they are declared as const or static.
A struct cannot declare a parameterless constructor (a constructor without parameters) or a finalizer.
- struct are copied on assignment. When a struct is assigned to a new variable, all the data is copied, and any modification to the new copy does not change the data for the original copy. This is important to remember when working with collections of value types such as Dictionary<string, myStruct>.
- struct are value types, unlike classes, which are reference types.
Unlike classes, structs can be instantiated(creating object) without using a new operator.
- struct can declare constructors that have parameters.
- struct do not support inheritance, but they can implement interfaces.
- struct can include constructors, constants, fields, methods, properties, indexers, operators, events & nested types.
- struct cannot include a parameterless constructor or a destructor.
- struct can implement interfaces, same as class.
- struct cannot inherit another structure or class, and it cannot be the base of a class.
- struct members cannot be specified as abstract, sealed, virtual, or protected.
