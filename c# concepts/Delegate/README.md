## Delegate

if we want to **pass a function as a parameter**? How does C# handles the callback functions or event handler? The answer is - **"delegate"**.

A **delegate** is a **type** that represents **references to methods with a particular parameter list and return type**. When you instantiate a delegate, you can associate its instance with any method with a compatible signature and return type. You can **invoke (or call) the method** through the **delegate instance**.

**Delegates** are used to **pass methods as arguments to other methods**. 

There are three steps involved while working with delegates:

1.  Declare a delegate
2.  Set a target method
3.  Invoke a delegate

A **delegate** can be declared using the delegate keyword followed by a function signature

```cs

[access modifier] delegate [return type] [delegate name]([parameters])
```

Eg:

```cs

public delegate void MyDelegate(string msg);

public delegate int PerformCalculation(int x, int y);

```

```cs
public delegate void MyDelegate(string msg); //declaring a delegate

class Program
{
    static void Main(string[] args)
    {
        MyDelegate del = ClassA.MethodA;
        del("Hello World");

        del = ClassB.MethodB;
        del("Hello World");

        del = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
        del("Hello World");
    }
}

class ClassA
{
    static void MethodA(string message)
    {
        Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
    }
}

class ClassB
{
    static void MethodB(string message)
    {
        Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
    }
}
```






### ref
https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/

https://www.tutorialsteacher.com/csharp/csharp-delegates
