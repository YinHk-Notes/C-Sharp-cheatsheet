## Properties

Properties **enable a class to expose a public way of getting and setting values**,  while hiding implementation or verification code.  Properties combine aspects of both **fields** and **methods**.


> 💬 Similar to `Field`, but `public`let us to `get` and `set` the value.

- Properties **enable a class to expose a public way of getting and setting values**, while hiding implementation or verification code.
- A [get](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/get) property accessor is used to **return the property value**, and a [set](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/set) property accessor is used to **assign a new value**. These accessors can have different access levels. For more information, see [Restricting Accessor Accessibility](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/restricting-accessor-accessibility).**
- The [value](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/value) keyword is used to define the value being assigned by the set accessor.

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
```

> 💬 Propety’s name is **same** to the field’s name, but need to **capitalize first word**.



**The get accessor:** 

> 📌 The body of the get accessor resembles that of a method. It must **return a value of the property type**.

**The set accessor:** 

> 📌 a method whose return type is [void](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/void). It uses an implicit parameter called **value**, whose type is the type of the property.



https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties
