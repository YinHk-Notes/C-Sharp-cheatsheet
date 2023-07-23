## Abstraction
Data **abstraction** is the process of **hiding certain details and showing only essential informati**on to the user.

Abstraction can be achieved with either **abstract classes** or **interfaces**.

> **Note**: Abstraction can also be achieved with **Interfaces**

The abstract classes are used to achieve abstraction in C#.

Abstraction is one of the important concepts of object-oriented programming. It allows us to hide unnecessary details and only show the needed information.

This helps us to manage complexity by hiding details with a simpler, higher-level idea.

A practical example of abstraction can be motorbike brakes. We know what a brake does. When we apply the brake, the motorbike will stop. However, the working of the brake is kept hidden from us.

The major advantage of hiding the working of the brake is that now the manufacturer can implement brakes differently for different motorbikes. However, what brake does will be the same.


### Abstract Classes and Methods

The `abstract` keyword is used for classes and methods:

-   **Abstract class:** is a restricted class that **cannot be used to create object**s (to access it, it **must be inherited** from another class).
  
-   **Abstract method:** can **only be used in an abstract class**, and it **does not have a body**. The body is provided by the **derived class** (inherited from).

> **Note**: An **abstract class** can have **both abstract** and **regular methods**.

Eg:
```cs
abstract class Animal 
{
  // abstract method
  public abstract void animalSound();
  // regular method
  public void sleep() 
  {
    Console.WriteLine("Zzz");
  }
}

Animal myObj = new Animal(); // Will generate an error (Cannot create an instance of the abstract class or interface 'Animal')
```


> **Note**: To **access** the abstract class, it **must be inherited from another class**.

Eg:
```cs
// Abstract class
abstract class Animal
{
  // Abstract method (does not have a body)
  public abstract void animalSound();
  // Regular method
  public void sleep()
  {
    Console.WriteLine("Zzz");
  }
}

// Derived class (inherit from Animal)
class Pig : Animal
{
  public override void animalSound()
  {
    // The body of animalSound() is provided here
    Console.WriteLine("The pig says: wee wee");
  }
}

class Program
{
  static void Main(string[] args)
  {
    Pig myPig = new Pig(); // Create a Pig object
    myPig.animalSound();  // Call the abstract method
    myPig.sleep();  // Call the regular method
  }
}

```

```cs
using System;
namespace AbstractClass {
  abstract class MotorBike {
    
    public abstract void brake();
  }

  class SportsBike : MotorBike {

    // provide implementation of abstract method
    public override void brake() {
      Console.WriteLine("Sports Bike Brake");
    }
   
  }

  class MountainBike : MotorBike {

    // provide implementation of abstract method
    public override void brake() {      
      Console.WriteLine("Mountain Bike Brake");
    }
   
  }
  class Program  {
    static void Main (string [] args) {
      // create an object of SportsBike class
      SportsBike s1 = new SportsBike();  
      s1.brake();

      // create an object of MountainBike class
      MountainBike m1 = new MountainBike();
      m1.brake();

      Console.ReadLine();
    }
  }
}
```

### Why And When To Use Abstract Classes and Methods?
> To achieve **security** - **hide certain details** and **only show the important details** of an object.

### Abstract properties
Like an abstract method, an abstract property consists of the abstract keyword and provides no implementation for the `get` or `set` access modifier. We can mark `get` and `set` accessors as **abstract**. 
Eg:
```cs
abstract class MyClass
{
    public abstract string AbstractProperty { get; set; }
    public abstract string AbstractMethod();    
}
```

```cs
using System;
namespace AbstractClass {
  abstract class Animal {
    
    protected string name;
    // abstract method
    public abstract string Name { get; set; }
  }

  // inheriting from abstract class
  class Dog : Animal {

    // provide implementation of abstract method
    public override string Name {
      get {
        return name;
      }
      set {
        name = value; 
      }
    }
   
  }
  class Program  {
    static void Main (string [] args) {
      // create an object of Dog class
      Dog obj = new Dog();  
      obj.Name = "Tom";
      Console.WriteLine("Name: " + obj.Name); 

      Console.ReadLine();
    }
  }
}

```



### ref 
https://www.w3schools.com/cs/cs_abstract.php

https://www.programiz.com/csharp-programming/abstract-class

https://www.csharptutorial.net/csharp-tutorial/csharp-abstract-class/
