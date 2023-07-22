## Abstraction
Data **abstraction** is the process of **hiding certain details and showing only essential informati**on to the user.

Abstraction can be achieved with either **abstract classes** or **interfaces**.

> **Note**: Abstraction can also be achieved with **Interfaces**

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


### Why And When To Use Abstract Classes and Methods?
> To achieve **security** - **hide certain details** and **only show the important details** of an object.



### ref 
https://www.w3schools.com/cs/cs_abstract.php
