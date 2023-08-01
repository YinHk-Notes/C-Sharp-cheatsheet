## `record`

A **`record`** type in C# is a class or struct that provides special syntax and behavior for working with **data models**. The `record` modifier instructs the compiler to synthesize members that are useful for types whose primary role is storing data.

You can take advantage of `record` types to build immutable value types. A record type is defined using the record keyword. The `record` keyword defines `record` types. A `record` type is a **value type** and an **immutable type** that **can not be changed once created**.

### When to use records

Consider using a `record` in place of a class or struct in the following scenarios:
- You want to define a data model that depends on value equality.
- You want to define a type for which objects are immutable.

Records in C# 9 provide a way to create immutable value types. The **record** keyword defines a record type like enums, structs, and classes. However, unlike these other types of constructs, record types are designed to be immutable by default. When you define a record type with properties and methods, the compiler will ensure those properties can never change after they are created.


#### Value equality
For records, value equality means that two variables of a record type are equal if the types match and all property and field values match. For other reference types such as classes, equality means reference equality. That is, two variables of a class type are equal if they refer to the same object. Methods and operators that determine equality of two record instances use value equality.

#### Immutability
An immutable type is one that prevents you from changing any property or field values of an object after it's instantiated.






### ref
https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/records

https://www.codeguru.com/csharp/record-types-c-sharp
