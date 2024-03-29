## Delegate

if we want to **pass a function as a parameter**? How does C# **handles the callback functions** or **event handler**? The answer is - **"delegate"**.

A **delegate** is a **type** that represents **references to methods with a particular parameter list and return type**. When you instantiate a delegate, you can associate its instance with any method with a compatible signature and return type. You can **invoke (or call) the method** through the **delegate instance**.

**Delegates** are also used to **pass methods as arguments to other methods**. 

A **delegate** is a type that holds a reference to a method. A delegate is declared with a signature that shows the return type and parameters for the methods it references, and it can hold references only to methods that match its signature.

Delegates have the following properties:

-   Delegate is the **reference type** data type that defines the signature.
-   Delegate holds references only to methods that match its signature.
-   Delegates are similar to C++ function pointers, but delegates are fully object-oriented, and unlike C++ pointers to member functions, delegates encapsulate both an object instance and a method.
-   Delegates allow methods to be passed as parameters.
-   Delegates can be used to define callback methods.
-   Delegates can be **chained together**; for example, **multiple methods can be calle**d on a single event.
-   Methods don't have to match the delegate type exactly. 
-   Lambda expressions are a more concise way of writing inline code blocks. Lambda expressions (in certain contexts) are compiled to delegate types. For more information about lambda expressions
-   A delegate is a type that **safely encapsulates a method**, similar to a function pointer in C and C++. Unlike C function pointers, delegates are object-oriented, **type safe, and secure**. The type of a delegate is defined by the **name of the delegate**.
-   **Delegate type variable** can refer to **any method with the same signature as the delegate**.
-   Syntax: **`[access modifier] delegate [return type] [delegate name]([parameters])`**
-   A target method's signature **must match** with delegate signature.
-   Delegates can be invoke like a normal function or **`Invoke()`** method.
-   **Multiple methods can be assigned** to the delegate using **"+" or "+="** operator and removed using **"-" or "-="** operator. It is called **multicast delegate**.
-   Delegate is used to **declare an event** and **anonymous methods** in C#.

### Using delegate
There are three steps involved while working with delegates:

1.  **Declare a delegate**
2.  **Set a target method**
3.  **Invoke a delegate**

A **delegate** can be declared using the delegate keyword followed by a function signature

```cs

[access modifier] delegate [return type] [delegate name]([parameters])
```




#### Declare a Delegate
```cs
public delegate void Del(string message);

```

```cs
// Declare a delegate.
delegate void Del(string str);
```

#### Create a target method for a delegate with a matching signature
```CS
// Create a method for a delegate.
public static void DelegateMethod(string message)
{
    Console.WriteLine(message);
}
```

```cs

// Declare a method with the same signature as the delegate.
static void Notify(string name)
{
    Console.WriteLine($"Notification received for: {name}");
}
```



#### Instantiate the delegate & set target method

```cs
// Instantiate the delegate and Set target method
Del handler = DelegateMethod;


// Or 
Del handler = new Del(DelegateMethod);


// Or set lambda expression
Del handler = (string msg) =>  Console.WriteLine(msg);

```

```cs
// Create an instance of the delegate.
Del del1 = new Del(Notify);

// C# 2.0 provides a simpler way to declare an instance of Del.
Del del2 = Notify;

// Instantiate Del by using an anonymous method.
Del del3 = delegate(string name)
    { Console.WriteLine($"Notification received for: {name}"); };

```

#### Call or Invoke the delegate
```cs
handler.Invoke("Hello World!");

// Or
handler("Hello World!");

```

![](./img/Delegate.png)

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


### Passing Delegate as a Parameter
A method can have a parameter of the delegate type
```cs
public delegate void MyDelegate(string msg); //declaring a delegate

class Program
{
    static void Main(string[] args)
    {
        MyDelegate del = ClassA.MethodA;
        InvokeDelegate(del);

        del = ClassB.MethodB;
        InvokeDelegate(del);

        del = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
        InvokeDelegate(del);
    }

    static void InvokeDelegate(MyDelegate del) // MyDelegate type parameter
    {
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

### Multicast Delegate (Combine delegates)

The delegate can point to multiple methods. A delegate that points multiple methods is called a **multicast delegate**. The **"+"** or **"+="** operator adds a function to the invocation list, and the **"-"** and **"-="** operator removes it.

Eg:
```cs
public delegate void MyDelegate(string msg);
public class Program
{
	public static void Main()
	{
		MyDelegate del1 = ClassA.MethodA;
		MyDelegate del2 = ClassB.MethodB;
		
		MyDelegate del = del1 + del2;
		Console.WriteLine("After del1 + del2");
		del("Hello World");
		
		MyDelegate del3 = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
		del += del3;
		Console.WriteLine("After del1 + del2 + del3");
		del("Hello World");
		
		del = del - del2;
		Console.WriteLine("After del - del2");
		del("Hello World");
		
		del -= del1;
		Console.WriteLine("After del1 - del1");
		del("Hello World");
	}
}

public class ClassA
{
	public static void MethodA(string message)
	{
		Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
	}
}

public class ClassB
{
	public static void MethodB(string message)
	{
		Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
	}
}


/*
Console output:

After del1 + del2
Called ClassA.MethodA() with parameter: Hello World
Called ClassB.MethodB() with parameter: Hello World
After del1 + del2 + del3
Called ClassA.MethodA() with parameter: Hello World
Called ClassB.MethodB() with parameter: Hello World
Called lambda expression: Hello World
After del - del2
Called ClassA.MethodA() with parameter: Hello World
Called lambda expression: Hello World
After del1 - del1
Called lambda expression: Hello World

 */

```

> **Note**: If a multicast delegate returns a value then it **returns the value from the last assigned target method**.


### Generic Delegate
A generic delegate can be defined the same way as a delegate but using generic type parameters or return type.


> The generic type must be specified when you set a target method.


Eg:
```cs
public delegate T add<T>(T param1, T param2); // generic delegate

class Program
{
    static void Main(string[] args)
    {
        add<int> sum = Sum;
        Console.WriteLine(sum(10, 20));

        add<string> con = Concat;
        Console.WriteLine(conct("Hello ","World!!"));
    }

    public static int Sum(int val1, int val2)
    {
        return val1 + val2;
    }

    public static string Concat(string str1, string str2)
    {
        return str1 + str2;
    }
}

/*
	Console output:
	30
	HelloWorld!!
*/
```



### ref
https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/

https://www.tutorialsteacher.com/csharp/csharp-delegates

https://www.infoworld.com/article/3057152/how-to-work-with-action-func-and-predicate-delegates-in-c-sharp.html

https://medium.com/nerd-for-tech/c-delegates-actions-events-summary-please-8fab0244a40a
