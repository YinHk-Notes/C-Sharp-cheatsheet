## Properties

A property is a member that provides a flexible mechanism to **read, write, or compute the value of a `private` field**.

Properties **enable a class to expose a public way of getting and setting values**,  while hiding implementation or verification code.  Properties combine aspects of both **fields** and **methods**.

> 💬 Similar to `Field`, but `public`let us to `get` and `set` the value.

Properties can be used as if they're public data members, but they're special methods called **accessors**. This feature enables data to be accessed easily and still helps **promote the safety and flexibility of methods**.

- Properties **enable a class to expose a public way of getting and setting values**, while hiding implementation or verification code.
- A **`get`** property accessor is used to **return the property value**, and a **`set`** property accessor is used to **assign a new value**. These accessors can have different access levels. 
- The **`value`** keyword is used to define the value being **assigned by the `set` accessor**.

**syntax:**

```csharp
<Access Specifier> <Return Type> <property Name>
{
	get{ return the field’s value; }
	set{ the field’s variable  = value; }
}
```

Eg:

```csharp

class Person{
  
  private string name; // field
  public string Name   // property
  {
    get { return name; }
    set { name = value; }
  }
}
class Program
{
  static void Main(string[] args)
  {

    Person myObj = new Person();
    myObj.Name = "Liam";

    Console.WriteLine(myObj.Name);
  }
}
```

**OR**

```csharp
class Person
{
  //property
  public string Name  { get; set; }
}
class Program
{
  static void Main(string[] args)
  {

    Person myObj = new Person();
    myObj.Name = "Liam";
    Console.WriteLine(myObj.Name);
  }
}
```
When a property implementation is a single expression, you can use **expression-bodied members** for the `getter` or `setter`:

Eg:
```cs
public class SaleItem
{
    string _name;
    decimal _cost;

    public SaleItem(string name, decimal cost)
    {
        _name = name;
        _cost = cost;
    }

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public decimal Price
    {
        get => _cost;
        set => _cost = value;
    }
}
```

**Validation** \
You can write code in the set accessor to ensure that the values represented by a property are always valid.
```cs
public class Person
{
    public string FirstName
    {
        get => _firstName;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("First name must not be blank");
            _firstName = value;
        }
    }
    private string _firstName;

    // Omitted for brevity.
}

//or 

public class Person
{
    public string FirstName
    {
        get => _firstName;
        set => _firstName = (!string.IsNullOrWhiteSpace(value)) ? value : throw new ArgumentException("First name must not be blank");
    }
    private string _firstName;

    // Omitted for brevity.
}
```

**Access control** \
You can create read-only properties, or give different accessibility to the `set` and `get` accessors
```cs
//Suppose that your Person class should only enable changing the value of the FirstName property from other methods 
//in that class. You could give the set accessor private accessibility instead of public
public class Person
{
    public string FirstName { get; private set; }

    // Omitted for brevity.
}
```

**Read-only** \
You can also restrict modifications to a property so that it can only be set in a constructor.
```cs
public class Person
{
    public Person(string firstName) => FirstName = firstName;

    public string FirstName { get; }

    // Omitted for brevity.
}
```

**Init-only** \
Callers can't use object initializers to assign a value to the property. To support initializers, you can make the set accessor an init accessor.
```cs
public class Person
{
    public Person() { }
    public Person(string firstName) => FirstName = firstName;

    public string FirstName { get; init; }

    // Omitted for brevity.
}
```
The preceding example allows a caller to create a Person using the default constructor, even when that code doesn't set the FirstName property. Beginning in C# 11, you can require callers to set that property:
```cs
public class Person
{
    public Person() { }

    [SetsRequiredMembers]
    public Person(string firstName) => FirstName = firstName;

    public required string FirstName { get; init; }

    // Omitted for brevity.
}
```

**Computed properties** 
```cs
public class Person
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string FullName { get { return $"{FirstName} {LastName}"; } }
}

//or
public class Person
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string FullName => $"{FirstName} {LastName}";
}
```

**Cached evaluated properties** 
```cs
public class Person
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    private string _fullName;
    public string FullName
    {
        get
        {
            if (_fullName is null)
                _fullName = $"{FirstName} {LastName}";
            return _fullName;
        }
    }
}


public class Person
{
    private string _firstName;
    public string FirstName
    {
        get => _firstName;
        set
        {
            _firstName = value;
            _fullName = null;
        }
    }

    private string _lastName;
    public string LastName
    {
        get => _lastName;
        set
        {
            _lastName = value;
            _fullName = null;
        }
    }

    private string _fullName;
    public string FullName
    {
        get
        {
            if (_fullName is null)
                _fullName = $"{FirstName} {LastName}";
            return _fullName;
        }
    }
}
```

**Auto-Implemented properties** \
Auto-implemented properties make property-declaration more concise when no additional logic is required in the property accessors. They also enable client code to create objects. When you declare a property as shown in the following example, **the compiler creates a private, anonymous backing field that can only be accessed through the property's `get` and `set` accessors.** In C# 9 and later, **`init`** accessors can also be declared as auto-implemented properties.

No need declare `private` fields. 

Eg:
```cs
// This class is mutable. Its data can be modified from
// outside the class.
public class Customer
{
    // Auto-implemented properties for trivial get and set
    public double TotalPurchases { get; set; }
    public string Name { get; set; }
    public int CustomerId { get; set; }

    // Constructor
    public Customer(double purchases, string name, int id)
    {
        TotalPurchases = purchases;
        Name = name;
        CustomerId = id;
    }

    // Methods
    public string GetContactInfo() { return "ContactInfo"; }
    public string GetTransactionHistory() { return "History"; }

    // .. Additional methods, events, etc.
}

class Program
{
    static void Main()
    {
        // Initialize a new object.
        Customer cust1 = new Customer(4987.63, "Northwind", 90108);

        // Modify a property.
        cust1.TotalPurchases += 499.99;
    }
}
```


```cs
class Skill
{
    private string name;
    private sbyte rating;

    public string Name
    {
        get { return name; }
        set { name = value; }

    }
    public sbyte Rating
    {
        get { return rating; }
        set { rating = value; }
    }

}


// By auto-implemented properties, like this:
class Skill
{
    public string Name { get; set; }
    public sbyte Rating { get; set; }
}

```

```cs
private string name;

public string Name
{
    get { return this.name; }
    set { this.name = value; }
}
```

**Auto Property Initializers** \
To initialize a property value of a class, we used to set the property value in a class constructor. In the code listed in Listing 1, the Name property of the Author class is initialized in the class’s constructor. 

Eg:
```cs
class Author
{
    public string Name { get; set; }
    public string Book { get; set; }
    public double Price { get; set; }

    public Author()
    {
        Name = "Mahesh Chand";
    }
}
```

**`static` properties** \
C# also supports `static` properties, which belong to the class rather than to the objects of the class. All the rules applicable to a `static` member also apply to `static` properties.

```cs
using System;

class MyClass
{
    private static int _x;
    public static int X
    {
        get
        {
            return _x;
        }
        set
        {
            _x = value;
        }
    }
}

class MyClient
{
    public static void Main()
    {
        MyClass.X = 10; // Setting the value of the static property
        int xVal = MyClass.X; // Retrieving the value of the static property
        Console.WriteLine(xVal); // Displays 10
    }
}
```
> **set/get** accessor of the static property can access only other static members of the class.

**Abstract properties** \
A property inside a class can be declared as abstract by using the keyword `abstract`.

abstract property in a class carries no code at all. For example, the **get/set** accessors are represented **with a semicolon**. In the derived class, we **must implement both `sets` and `get` assessors**.


```cs
//C# : Property : Abstract
//Author: rajeshvs@msn.com
using System;

abstract class Abstract
{
    public abstract int X { get; set; }
}

class Concrete : Abstract
{
    public override int X
    {
        get
        {
            Console.Write(" GET");
            return 10;
        }
        set
        {
            Console.Write(" SET");
        }
    }
}

class MyClient
{
    public static void Main()
    {
        Concrete c1 = new Concrete();
        c1.X = 10;
        Console.WriteLine(c1.X);
    }
}


```



### Summary

> 💬 Propety’s name is **same** to the field’s name, but need to **capitalize first word**.


**The get accessor:** 

> 📌 The body of the `get` accessor resembles that of a method. It must **return a value of the property type**.

**The set accessor:** 

> 📌 a method whose return type is [void](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/void). It uses an implicit parameter called **value**, whose type is the type of the property.


### ref

https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties

https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/using-properties

https://www.w3schools.com/cs/cs_properties.php

https://www.c-sharpcorner.com/article/understanding-properties-in-C-Sharp/

https://www.csharptutorial.net/csharp-tutorial/csharp-property/

