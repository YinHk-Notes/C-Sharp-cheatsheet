## Method

Syntax
```
<Access Specifier> <Return Type> <Method Name> (Parameter List) {
    //...statement...
}
```

> Methods and Functions are the same in C#.                                                                                   However, Methods are used in C# and are functions that operate through a designated class. A method is a group of statements that together perform a task. Every C# program has at least one class with a method named **Main**.

### Void method

void isn't allowed in the parameter list of a method. A method that takes no parameters and returns no value, 
the return type is “void”.


```CS
void SampleMethod(){
	// Body of the method.**
}
```

### Method Overloading
With method overloading, multiple methods can have the **same name** with **different parameters** or **different type of parameters**.
```cs
int MyMethod(int x)
float MyMethod(float x)
double MyMethod(double x, double y)
```

> **Note**: Multiple methods can have the same name as long as the number and/or type of parameters are different.

https://www.w3schools.com/cs/cs_method_overloading.php


### Method Overriding

**Method Overriding** in C# is similar to the virtual function in C++. 

Method Overriding is a technique that allows the invoking of functions from another class (base class) in the derived class. Creating a method in the derived class with the **same signature** as a method in the base class is called as **method overriding**.

An override method provides a new implementation of the method inherited from a base class. The method that is overridden by an override declaration is known as the overridden base method.

- An override method **must** have the same signature as the overridden base method.
- return type of an override method can derive from the return type of the corresponding base method.

In C# we can use `virtual` keyword with base class method and `override` keyword with derived class method to achieve methood overriding.

Eg:
```cs
class base_class
{
    public virtual void gfg();
}

class derived_class : base_class
{
    public override void gfg();
}
class Main_Method
{
 static void Main()
 {
    derived_class d = new derived_class();
    d.gfg();
    
      base_class b = new derived_class();
        b.gfg();
 }
}
```

```cs
using System;  
public class Animal{  
    public virtual void eat(){  
        Console.WriteLine("Eating...");  
    }  
}  
public class Dog: Animal  
{  
    public override void eat()  
    {  
        Console.WriteLine("Eating bread...");  
    }  
}  
public class TestOverriding  
{  
    public static void Main()  
    {  
        Dog d = new Dog();  
        d.eat();  
    }  
} 

```


https://www.geeksforgeeks.org/c-sharp-method-overriding/

https://www.javatpoint.com/c-sharp-method-overriding
