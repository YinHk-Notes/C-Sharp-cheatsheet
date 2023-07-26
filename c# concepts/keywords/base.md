## base
The **`base`** keyword is used to **access members of the base class** from within a derived class. Use it if you want to:

-   Call a method on the base class that has been overridden by another method.
-   Specify which base-class constructor should be called when creating instances of the derived class.

> The base class access is permitted only in a **constructor**, in an **instance method**, and in an **instance property accessor**.


> Using the `base` keyword from within a `static` method will give an error.


> The `base` class that is accessed is the base class specified in the class declaration. For example, if you specify **`class ClassB : ClassA`**, the members of ClassA are accessed from ClassB, regardless of the base class of ClassA.


#### Calls the method of base class.

> It is useful if base and derived classes defines same method. In other words, if method is **overridden**. If derived class doesn't define same method, there is no need to use `base` keyword.


```cs
using System;  
public class Animal{  
    public virtual void eat(){  
        Console.WriteLine("eating...");  
    }  
}  
public class Dog: Animal  
{  
    public override void eat()  
    {  
        base.eat();  
        Console.WriteLine("eating bread...");  
    }  
      
}  
public class TestBase  
{  
    public static void Main()  
    {  
        Dog d = new Dog();  
        d.eat();  //eating...    eating bread...
    }  
}
```

#### Calling base class constructor internally
The base-class constructor called when creating instances of a derived class.

```cs
public class BaseClass
{
    int num;

    public BaseClass()
    {
        Console.WriteLine("in BaseClass()");
    }

    public BaseClass(int i)
    {
        num = i;
        Console.WriteLine("in BaseClass(int i)");
    }

    public int GetNum()
    {
        return num;
    }
}

public class DerivedClass : BaseClass
{
    // This constructor will call BaseClass.BaseClass()
    public DerivedClass() : base()
    {
    }

    // This constructor will call BaseClass.BaseClass(int i)
    public DerivedClass(int i) : base(i)
    {
    }

    static void Main()
    {
        DerivedClass md = new DerivedClass();
        DerivedClass md1 = new DerivedClass(1);
    }
}
/*
Output:
in BaseClass()
in BaseClass(int i)
*/

```





### ref
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/base

https://www.javatpoint.com/c-sharp-base



