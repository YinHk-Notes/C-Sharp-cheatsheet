## interface
An **interface** is a completely **"abstract class"**, which can only contain **abstract method**s and **properties** (with **empty bodies**).

- An interface **defines a contract**. Any **class** or **struct** that implements that contract **must** provide an implementation of the members defined in the interface. An interface **may define a default implementation for members**. It **may also define static members** in order to provide a single implementation for common functionality.
  
- An interface is a **completely "abstract class",** which can **only contain abstract methods** and **properties** (with empty bodies)

- An interface can contain **declarations of methods, properties, indexers, and events**. However, it **cannot contain fields, auto-implemented properties**.

- Like abstract classes, interfaces **cannot be used to create objects**.
- Interface methods do not have a body - the **body is provided by the "implement" class**
- On implementation of an interface, you **must override** all of its methods, but you do not have to use the **override** keyword when implementing an interface.
- Interfaces can contain **properties** and **methods**, but **not** **fields/variables**.
- Interface members are by default **`abstract`** and **`public`**
- An interface **cannot contain a constructor** (as it **cannot be used to create objects**)
- A class or struct can **implement multiple interfaces**.
- Interface **cannot inherit class**, but it can **inherit multiple other Interfaces**.
- Interface **cannot implement abstract methods** inherit from other interfaces.
  


An interface can be **a member of a namespace or a class**. An interface declaration can contain declarations (signatures without any implementation) of the following members:
    
- Methods
- Properties
- Indexers
- Events



**Why and when to use interfaces?**
- To achieve security - hide certain details and only show the important details of an object (interface).
- C# does not support **"multiple inheritance"** (a class can **only inherit from one base class**). However, it can be achieved with **interfaces**, because the class can **implement multiple interfaces**.

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

### Implementing an Interface
A `class` or a `Struct` can implement one or more interfaces using colon `:`
```cs
class ClassName : InterfaceName
{

}
```

```cs
interface IFile
{
    void ReadFile();
    void WriteFile(string text);
}

class FileInfo : IFile
{
    public void ReadFile()
    {
        Console.WriteLine("Reading File");
    }

    public void WriteFile(string text)
    {
        Console.WriteLine("Writing to file");
    }
}
```
> **Note**: Interface members **must be implemented with the public modifier**; otherwise, the compiler will give compile-time errors. If explicitly implement **interface members**, **public modifier is not needed**.

```cs
interface IFile
{
    void ReadFile();
    void WriteFile(string text);
}

class FileInfo : IFile
{
    // Explicit interface member implementation:
    void IFile.ReadFile()
    {
        Console.WriteLine("Reading File");
    }

    void IFile.WriteFile(string text)
    {
        Console.WriteLine("Writing to file");
    }
}

```

### Implementing Multiple Interfaces
seperate by `,`
```cs
interface IFile
{
    void ReadFile();
}

interface IBinaryFile
{
    void OpenBinaryFile();
    void ReadFile();
}

class FileInfo : IFile, IBinaryFile
{
    void IFile.ReadFile()
    {
        Console.WriteLine("Reading Text File");
    }

    void IBinaryFile.OpenBinaryFile()
    {
        Console.WriteLine("Opening Binary File");
    }

    void IBinaryFile.ReadFile()
    {
        Console.WriteLine("Reading Binary File");
    }

    public void Search(string text)
    {
        Console.WriteLine("Searching in File");
    }
}
```

### Default Interface Methods

C# 8.0 added support for virtual extension methods in interface with concrete implementations.
default interface methods that **does not need to be implemented in a class or struct**.
```cs
interface IFile
{
    void ReadFile();
    void WriteFile(string text);

    void DisplayName()
    {
        Console.WriteLine("IFile");
    }
}
```
Note that a class **does not inherit default methods** from its interfaces; so, you cannot access it using the class instance.
```cs
class FileInfo : IFile
{
    public void ReadFile()
    {
        Console.WriteLine("Reading File");
    }

    public void WriteFile(string text)
    {
        Console.WriteLine("Writing to file");
    }
}

public class Program
{
    public static void Main()
    {
        IFile file1 = new FileInfo(); //using interface as a reference type
        file1.ReadFile(); 
        file1.WriteFile("content"); 
        file1.DisplayName();

        FileInfo file2 = new FileInfo(); //using class as a reference type
        //file2.DisplayName(); //compile-time error 
    }
}
```

### Modifiers in Interfaces

C# 8.0 allows `private`, `protected`, `internal`, `public`, `virtual`, `abstract`, `sealed`, `static`, `extern`, and `partial` modifiers in an interface.
- he default access level for all interface members is **`public`**.
- An interface member whose declaration includes a body is a **`virtual`** member unless the **`sealed`** or **`private`** modifier is used.
- A **`private`** or **`sealed`** function member of an interface **must have implementation body**.
- Interfaces may declare **`static`** members which can be accessed by interface name.


*1.**介面只能宣告，不能實作，且只能為公開(public)***。 *預設就是公開所以不用特別加上public*

*2.**介面可以繼承介面***

***3.介面不可以繼承類別***

***4.可以同時繼承多個介面***

***5.繼承介面的類別必須實作所有的屬性與方法***



### ref 

https://www.w3schools.com/cs/cs_interface.php

interface \
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/interface

interfaces \
https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/interfaces

Update interfaces with default interface methods \
https://learn.microsoft.com/en-us/dotnet/csharp/advanced-topics/interface-implementation/default-interface-methods-versions

Mix functionality in when creating classes using interfaces with default interface methods \
https://learn.microsoft.com/en-us/dotnet/csharp/advanced-topics/interface-implementation/mixins-with-default-interface-methods

Explicit Interface Implementation \
https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/interfaces/explicit-interface-implementation

How to explicitly implement interface members \
https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/interfaces/how-to-explicitly-implement-interface-members

How to explicitly implement members of two interfaces \
https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/interfaces/how-to-explicitly-implement-members-of-two-interfaces
