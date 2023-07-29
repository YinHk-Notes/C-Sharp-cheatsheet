## Polymorphism

**Polymorphism** means **"many forms"**, and it occurs when we have many classes that are related to each other by inheritance.

Polymorphism uses those methods to perform different tasks. This allows us to perform a single action in different ways.

Polymorphism simply means occurring in more than one form.

Polymorphism is the ability of an object to take on many forms.

Polymorphism is an important concept of object-oriented programming. It simply means **more than one form.**

**Polymorphism** is an object-oriented programming concept that refers to the ability of a *variable*, *function,* or *object* to take on *multiple* forms.

**Types of polymorphism:**

- **Compile time** polymorphism
    - Example:  **Method overloading**
- **Runtime** polymorphism
    - Example:  **Method overriding**




```cs
class Animal  // Base class (parent) 
{
  public virtual void animalSound() 
  {
    Console.WriteLine("The animal makes a sound");
  }
}

class Pig : Animal  // Derived class (child) 
{
  public override void animalSound() 
  {
    Console.WriteLine("The pig says: wee wee");
  }
}

class Dog : Animal  // Derived class (child) 
{
  public override void animalSound() 
  {
    Console.WriteLine("The dog says: bow wow");
  }
}

class Program 
{
  static void Main(string[] args) 
  {
    Animal myAnimal = new Animal();  // Create a Animal object
    Animal myPig = new Pig();  // Create a Pig object
    Animal myDog = new Dog();  // Create a Dog object

    myAnimal.animalSound();
    myPig.animalSound();
    myDog.animalSound();
  }
}
```

### Why ising "Polymorphism"?

It is useful for code reusability: reuse fields and methods of an existing class when you create a new class.





### ref
https://www.w3schools.com/cs/cs_polymorphism.php

https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/polymorphism

https://www.programiz.com/csharp-programming/polymorphism


