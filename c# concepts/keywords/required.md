## `required`
The required modifier indicates that the **field** or **property** it's applied to must be initialized by an **object initializer**.




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
