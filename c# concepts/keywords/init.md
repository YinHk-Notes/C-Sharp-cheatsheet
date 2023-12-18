## `init`

Use the `init` keyword to define an **accessor method** in a **property or indexer** of the object.

An **init-only** setter **assigns a value** to the property or the indexer element **only** during object construction. This enforces **immutability**, so that once the object is **initialized**, it **can't be changed** again.

Once the property initialized set once, its value can't be change because it is immutable.

### Init-Only Setters

```cs
class Person_InitExample
{
     private int _yearOfBirth;

     public int YearOfBirth
     {
         get { return _yearOfBirth; }
         init { _yearOfBirth = value; }
     }
}

var john = new Person_InitExample
{
    YearOfBirth = 1984
};

john.YearOfBirth = 1926; //Not allowed, as its value can only be set once in the constructor

```

The `init` accessor can also be used in **auto-implemented properties**:
```cs
class Person_InitExampleAutoProperty
{
    public int YearOfBirth { get; init; }
}
```
The `init` accessor can be used as an **expression-bodied** member: 
```CS

class Person_InitExampleExpressionBodied
{
    private int _yearOfBirth;

    public int YearOfBirth
    {
        get => _yearOfBirth;
        init => _yearOfBirth = value;
    }
}

```

### ref
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/init

https://www.csharptutorial.net/csharp-tutorial/csharp-init/

https://www.c-sharpcorner.com/article/c-9-0-introductions-to-init-only-properties/

