### Inheritance

- Derived Class (child) - the class that inherits from another class
- Base Class (parent) - the class being inherited from
- Inheritance applies only to **classes** and **interfaces**. Other type categories (structs, delegates, and enums) do not support inheritance. 

To inherit from a class, use the `:` symbol.
```cs
public class A
{
    public void Method1()
    {
        // Method implementation.
    }
}

public class B : A
{ }

public class Example
{
    public static void Main()
    {
        B b = new ();
        b.Method1();
    }
}
```
```cs
class Vehicle  // base class (parent) 
{
  public string brand = "Ford";  // Vehicle field
  public void honk()             // Vehicle method 
  {                    
    Console.WriteLine("Tuut, tuut!");
  }
}

class Car : Vehicle  // derived class (child)
{
  public string modelName = "Mustang";  // Car field
}

class Program
{
  static void Main(string[] args)
  {
    // Create a myCar object
    Car myCar = new Car();

    // Call the honk() method (From the Vehicle class) on the myCar object
    myCar.honk();

    // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
    Console.WriteLine(myCar.brand + " " + myCar.modelName);
  }
}
```

If you try to **access a sealed class**, C# will generate an **error**:
```cs
sealed class Vehicle 
{
  ...
}

//error
class Car : Vehicle 
{
  ...
}
```

> **Note**: C# does not support **"multiple inheritance"** (a class can only inherit from **one base class**). 
