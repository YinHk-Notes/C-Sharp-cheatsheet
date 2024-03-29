## Nullable reference types

- A variable of a reference type `T` must be initialized with non-null, and may never be assigned a value that may be `null`.
- A variable of a reference type `T?` may be initialized with `null` or assigned `null`, but is required to be checked against `null` before de-referencing.
- A variable m of type `T?` is considered to be `non-null` when you apply the null-forgiving operator, as in `m!`


```cs
public MyClass : System.Object? // not allowed
{
}

var nullEmpty = System.String?.Empty; // Not allowed
var maybeObject = new object?(); // Not allowed
try
{
    if (thing is string? nullableString) // not allowed
        Console.WriteLine(nullableString);
} catch (Exception? e) // Not Allowed
{
    Console.WriteLine("error");
}
```
