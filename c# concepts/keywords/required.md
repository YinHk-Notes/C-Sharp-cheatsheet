## `required`
The required modifier indicates that the **field** or **property** it's applied to must be initialized by an **object initializer**.


We add **`required`** to the list of modifiers in **field modifier** and **property modifier**. The `required` member list of a type is composed of all the members that have had `required` applied to them.

```cs
public class Person
{
    // The default constructor requires that FirstName and LastName be set at construction time
    public required string FirstName { get; init; }
    public string MiddleName { get; init; } = "";
    public required string LastName { get; init; }
}
```


Eg:
```CS
public class Person
{
    public Person() { }

    [SetsRequiredMembers]
    public Person(string firstName, string lastName) =>
        (FirstName, LastName) = (firstName, lastName);

    public required string FirstName { get; init; }
    public required string LastName { get; init; }

    public int? Age { get; set; }
}

public class Student : Person
{
    public Student() : base()
    {
    }

    [SetsRequiredMembers]
    public Student(string firstName, string lastName) :
        base(firstName, lastName)
    {
    }

    public double GPA { get; set; }
}
```

### ref
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/required

https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-11.0/required-members
