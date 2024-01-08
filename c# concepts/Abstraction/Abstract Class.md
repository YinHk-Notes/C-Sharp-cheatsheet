## Abstract Class
We use the **`abstract`** keyword to create an abstract class.
> In C#, we **cannot create objects of an abstract class**.
> An abstract class may contain abstract members including **abstract methods** and **abstract properties**.
> Abstract methods and properties do not contain implementation.

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

### inheritance
As we **cannot create objects of an abstract class**, we **must create a derived clas**s from it. So that we can access members of the abstract class using the object of the derived class.


For example,
```cs
using System;
namespace AbstractClass {

  abstract class Language {

    // non-abstract method
    public void display() {
      Console.WriteLine("Non abstract method");
    }
  }

  // inheriting from abstract class
  class Program : Language {

    static void Main (string [] args) {
      
      // object of Program class
      Program obj = new Program();

      // access method of an abstract class
      obj.display();

      Console.ReadLine();
    }
  }
}
```

> **Note**: We can use abstract class only as a **base** class. This is why **abstract** classes **cannot be** **"sealed"**.

> The **subclasses** of an abstract class **must implement the abstract methods and properties**.

### ref 
https://www.programiz.com/csharp-programming/abstract-class

