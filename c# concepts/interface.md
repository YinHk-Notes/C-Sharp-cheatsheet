## interface
- An interface **defines a contract**. Any **class** or **struct** that implements that contract **must** provide an implementation of the members defined in the interface. An interface **may define a default implementation for members**. It **may also define static members** in order to provide a single implementation for common functionality.

- An interface is a **completely "abstract class",** which can **only contain abstract methods** and **properties** (with empty bodies)

- An interface can contain **declarations of methods, properties, indexers, and events**. However, it **cannot contain fields, auto-implemented properties**.

- Like abstract classes, interfaces cannot be used to create objects.
- Interface methods do not have a body - the body is provided by the "implement" class
- On implementation of an interface, you must override all of its methods
- Interfaces can contain properties and methods, but not fields/variables
- Interface members are by default `abstract` and `public`
- An interface cannot contain a constructor (as it cannot be used to create objects)

**Why and when to use interfaces?**
- To achieve security - hide certain details and only show the important details of an object (interface).
- C# does not support "multiple inheritance" (a class can only inherit from one base class). However, it can be achieved with interfaces, because the class can implement multiple interfaces.

```cs
// Interface
interface IAnimal 
{
  void animalSound(); // interface method (does not have a body)
}

// Pig "implements" the IAnimal interface
class Pig : IAnimal 
{
  public void animalSound() 
  {
    // The body of animalSound() is provided here
    Console.WriteLine("The pig says: wee wee");
  }
}

class Program 
{
  static void Main(string[] args) 
  {
    Pig myPig = new Pig();  // Create a Pig object
    myPig.animalSound();
  }
}
```

```cs
interface ISampleInterface
{
    void SampleMethod();
}

class ImplementationClass : ISampleInterface
{
    // Explicit interface member implementation:
    void ISampleInterface.SampleMethod()
    {
        // Method implementation.
    }
    static void Main()
    {
        // Declare an interface instance.
        ISampleInterface obj = new ImplementationClass();

        // Call the member.
        obj.SampleMethod();
    }
}
```

### Implementing an Interface
A `class` or a `Struct` can implement one or more interfaces using colon `:`
```cs
class ClassName : InterfaceName
{

}
```


*1.**介面只能宣告，不能實作，且只能為公開(public)***。 *預設就是公開所以不用特別加上public*

*2.**介面可以繼承介面***

***3.介面不可以繼承類別***

***4.可以同時繼承多個介面***

***5.繼承介面的類別必須實作所有的屬性與方法***
