## `record`

A **`record`** type in C# is a **class or struct** that provides special syntax and behavior for working with **data models**. The `record` modifier **instructs the compiler to synthesize member**s that are useful for types whose primary role is storing data.

You can take advantage of `record` types to build immutable value types. A `record` type is defined using the `record` keyword. The `record` keyword defines `record` types. A `record` type is a **value type** and an **immutable type** that **can not be changed once created**.

Eg:
```cs
public record Person(string FirstName, string LastName);

public static void Main()
{
    Person person = new("Nancy", "Davolio");
    Console.WriteLine(person);
    // output: Person { FirstName = Nancy, LastName = Davolio }
}
```

### When to use records

Consider using a `record` in place of a class or struct in the following scenarios:
- You want to define a data model that depends on value equality.
- You want to define a type for which objects are immutable.

Records in C# 9 provide a way to create immutable value types. The **record** keyword defines a record type like enums, structs, and classes. However, unlike these other types of constructs, record types are designed to be immutable by default. When you define a record type with properties and methods, the compiler will ensure **those properties can never change after they are created**.


#### Value equality
For records, value equality means that two variables of a record type are equal if the types match and all property and field values match. For other reference types such as classes, equality means reference equality. That is, two variables of a class type are equal if they refer to the same object. Methods and operators that determine equality of two record instances use value equality.

#### Immutability
An immutable type is one that prevents you from changing any property or field values of an object after it's instantiated.


### `With` expression
You can use a `with` expression to copy an immutable class/struct and change one of the properties.

Eg:
```cs
public record Person(string FirstName, string LastName)
{
    public string[] PhoneNumbers { get; init; }
}

public static void Main()
{
    Person person1 = new("Nancy", "Davolio") { PhoneNumbers = new string[1] };
    Console.WriteLine(person1);
    // output: Person { FirstName = Nancy, LastName = Davolio, PhoneNumbers = System.String[] }

    Person person2 = person1 with { FirstName = "John" };
    Console.WriteLine(person2);
    // output: Person { FirstName = John, LastName = Davolio, PhoneNumbers = System.String[] }
    Console.WriteLine(person1 == person2); // output: False

    person2 = person1 with { PhoneNumbers = new string[1] };
    Console.WriteLine(person2);
    // output: Person { FirstName = Nancy, LastName = Davolio, PhoneNumbers = System.String[] }
    Console.WriteLine(person1 == person2); // output: False

    person2 = person1 with { };
    Console.WriteLine(person1 == person2); // output: True
}
```



### ref
https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/records

https://www.codeguru.com/csharp/record-types-c-sharp

https://www.c-sharpcorner.com/article/c-sharp-9-0-introduction-to-record-types/
