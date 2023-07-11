## virtual
C# virtual method is a method that can be **redefined in derived classes.**

a **virtual** method has an **implementation** in a base class as well as derived the class. It is used when a method's basic functionality is the same but sometimes more functionality is needed in the derived class. A virtual method is created in the base class that can be overriden in the derived class.

**virtual** keyword is used to modify a method, property, indexer, or event declaration and allow for it to be overridden in a derived class.


> 📌 It is an error to use the **`virtual`** modifier on a static property.



> 📌 A **virtual inherited property** can be overridden in a derived class by including a property declaration that uses the **`override`** modifier.


The **`virtual`** keyword is used to **modify a method, property, indexer, or event declaration** and allow for it to be overridden in a derived class.


> **Note**: By default, methods are **non-virtual**. You **cannot override a non-virtual method**.


> You cannot use the **`virtual`** modifier with the **`static`**, **`abstract`**, **`private`**, or **`override`** modifiers.


> A virtual inherited property can be overridden in a derived class by including a property declaration that uses the **`override`** modifier.




```cs

class MyBaseClass
{
    // virtual auto-implemented property. Overrides can only
    // provide specialized behavior if they implement get and set accessors.
    public virtual string Name { get; set; }

    // ordinary virtual property with backing field
    private int _num;
    public virtual int Number
    {
        get { return _num; }
        set { _num = value; }
    }
}

class MyDerivedClass : MyBaseClass
{
    private string _name;

    // Override auto-implemented property with ordinary property
    // to provide specialized accessor behavior.
    public override string Name
    {
        get
        {
            return _name;
        }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                _name = value;
            }
            else
            {
                _name = "Unknown";
            }
        }
    }
}
```

### ref
[https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/virtual](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/virtual)

https://www.csharptutorial.net/csharp-tutorial/csharp-virtual/



