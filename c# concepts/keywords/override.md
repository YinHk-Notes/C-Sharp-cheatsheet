## `override`
The `override` modifier is required to extend or modify the abstract or virtual implementation of an inherited method, property, indexer, or event.


```cs
class Person
{
    public string Name { get; set; }

    public virtual string Introduce() => $"Hi, I'm {Name}.";
}

class Employee : Person
{
    public string JobTitle { get; set; }

    public override string Introduce() => $"Hi, I'm {Name}. I'm a {JobTitle}.";
}
```


### ref
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/override

https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/knowing-when-to-use-override-and-new-keywords

https://www.geeksforgeeks.org/c-sharp-method-overriding/
