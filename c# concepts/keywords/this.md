## `this`
The `this` keyword refers to the current instance of the class and is also used as a modifier of the first parameter of an extension method.


- Refers to the current instance of a class
  ```cs
    using System;
 
    namespace ThisKeyword {
    class Test {

      int num;
      Test(int num) {
        // this.num refers to the instance field
        this.num = num;
        Console.WriteLine("object of this: " + this);
      }

      static void Main(string[] args) {

        Test t1 = new Test(4);
        Console.WriteLine("object of t1: " + t1);
        Console.ReadLine();
      }
    }
  }
```
-  Invoke Constructor of the Same Class Using `this` \
   While working with constructor overloading, we might have to invoke one constructor from another constructor. \
   eg:

  ```cs
    using System;
 
    namespace ThisKeyword {
    class Test {
    
      Test(int num1, int num2) {

        Console.WriteLine("Constructor with two parameter");
      }
    
      // invokes the constructor with 2 parameters
      Test(int num) : this(33, 22) {

        Console.WriteLine("Constructor with one parameter");
      }

      public static void Main(String[] args) {

        Test t1 = new Test(11); 
        Console.ReadLine();   
      }
    }
  }
```



### ref
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/this

https://www.programiz.com/csharp-programming/this-keyword

