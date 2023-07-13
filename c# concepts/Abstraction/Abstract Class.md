## Abstract Class
We use the **`abstract`** keyword to create an abstract class.
> In C#, we **cannot create objects of an abstract class**. 

For example,

```cs
// create an abstract class
abstract class Language {
  // fields and methods
}
...

// try to create an object Language
// throws an error
Language obj = new Language();
```

An abstract class can have both **abstract methods (method without body)** and **non-abstract methods**. 

For example,

```cs
abstract class Language {

  // abstract method
  public abstract void display1();

  // non-abstract method
  public void display2() {
    Console.WriteLine("Non abstract method");
  }
}
```



### ref 
https://www.programiz.com/csharp-programming/abstract-class

