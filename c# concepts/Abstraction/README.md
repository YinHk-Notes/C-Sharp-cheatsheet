## Abstraction
Data **abstraction** is the process of **hiding certain details and showing only essential informati**on to the user.

Abstraction can be achieved with either **abstract classes** or **interfaces**.



### Abstract Classes and Methods

The `abstract` keyword is used for classes and methods:

-   **Abstract class:** is a restricted class that **cannot be used to create object**s (to access it, it must be inherited from another class).
  
-   **Abstract method:** can **only be used in an abstract class**, and it **does not have a body**. The body is provided by the **derived class** (inherited from).

> **Note**: An **abstract class** can have **both abstract** and **regular methods**.


```cs
abstract class Animal 
{
  public abstract void animalSound();
  public void sleep() 
  {
    Console.WriteLine("Zzz");
  }
}

Animal myObj = new Animal(); // Will generate an error (Cannot create an instance of the abstract class or interface 'Animal')
```


> **Note**: To **access** the abstract class, it **must be inherited from another class**.



### Why And When To Use Abstract Classes and Methods?
> To achieve security - hide certain details and only show the important details of an object.



### ref 
https://www.w3schools.com/cs/cs_abstract.php
