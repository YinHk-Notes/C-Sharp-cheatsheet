## Abstract Method
A method that does not have a body is known as an abstract method. We use the abstract keyword to create abstract methods. 


Eg:
```cs
abstract class MyClass
{
    public abstract string AbstractMethod();
}
```
> If a class contains at least one abstract method, it must be an abstract class.


### Implementation of the abstract method
Implement abstract method **must in subclass of abstract class**.

Eg:
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

> **Note**: Note: Unlike the C# inheritance, we cannot use `virtual` with the abstract methods of the base class. This is because an abstract class is implicitly virtual.



