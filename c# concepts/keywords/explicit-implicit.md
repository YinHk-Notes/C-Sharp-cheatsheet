## `explicit` and `implicit
A user-defined type can define a custom implicit or explicit conversion from or to another type.

Implicit conversions don't require special syntax to be invoked and can occur in various situations

If a custom conversion can throw an exception or lose information, define it as an explicit conversion.

Use the `operator` and `implicit` or `explicit` keywords to define an implicit or explicit conversion, respectively. The type that defines a conversion must be either a source type or a target type of that conversion. A conversion between two user-defined types can be defined in either of the two types.




### ref
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/user-defined-conversion-operators


