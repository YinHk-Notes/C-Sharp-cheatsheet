## `override`
The `override` modifier is required to extend or modify the **`abstract`** or **`virtual`** implementation of an **inherited method**, **property**, **indexer**, or **event**.


modify **`virtual`** method:
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

modify **`abstract`** method:
```cs

using System;
namespace AbstractClass {

  abstract class Animal {

    // abstract method
    public abstract void makeSound();
  }

  // inheriting from abstract class
  class Dog : Animal {

    // provide implementation of abstract method
    public override void makeSound() {

      Console.WriteLine("Bark Bark");

    }
  }
  class Program  {
    static void Main (string [] args) {
      // create an object of Dog class
      Dog obj = new Dog();
      obj.makeSound();    

      Console.ReadLine(); 
    }
  }
}



```

- A **non-virtual** or a `static` method **can’t be overridden**.
- Both the `override` method and the `virtual` method **must** have the **same access level modifier**.

### ref
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/override

https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/knowing-when-to-use-override-and-new-keywords

https://www.geeksforgeeks.org/c-sharp-method-overriding/
