## `this`
The **`this`** keyword refers to the **current instance of the class** and is also used as a **modifier of the first parameter** of an extension method.


- Refers to the current instance of a class:
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
-  **Invoke Constructor of the Same Class** Using **`this`**: \
   While working with **constructor overloading**, we might have to invoke one constructor from another constructor. \
   eg:

    ```cs
        using System;
 
        namespace ThisKeyword {
        class Test {
    
          Test(int num1, int num2)
          {

              Console.WriteLine("Constructor with two parameter");
          }
    
          // invokes the constructor with 2 parameters
          Test(int num) : this(33, 22)
          {

              Console.WriteLine("Constructor with one parameter");
          }

          public static void Main(String[] args)
          {

              Test t1 = new Test(11); 
              Console.ReadLine();   
          }
        }
        }
    ```

  > **Note**: Calling one constructor from another constructor is known as **constructor chaining**.

- `this` as an object argument \
  We can use **`this`** keyword to **pass the current object as an argument** to a method.

  ```cs
    using System;
 
    namespace ThisKeyword {
      class Test {
        int num1;
        int num2;
      
        Test() {
          num1 = 22;
          num2 = 33;
        }

        // method that accepts this as argument   
        void passParameter(Test t1) {
            Console.WriteLine("num1: " + num1);
            Console.WriteLine("num2: " + num2);
        }

        void display() {
            // passing this as a parameter
            passParameter(this);
        }
  
        public static void Main(String[] args) {
            Test t1 = new Test();
            t1.display();
            Console.ReadLine();
        }
      }
    }

  ```
- **`this`** to declare a C# indexer: \
  **Indexers** allow **objects of a class** to be indexed just like arrays. We use this keyword to declare an indexer in C#.
  ```cs

    using System;
    namespace ThisKeyword {
      
      class Student {
      
          private string[] name = new string[3];
  
          // declaring an indexer
          public string this[int index] {

          // returns value of array element
          get {
              return name[index];
          }
      
          // sets value of array element
          set { 
            name[index] = value;
          }
        }
      }
  
    class Program {
  
      public static void Main() {
        Student s1 = new Student();
        s1[0] = "Ram";
        s1[1] = "Shyam";
        s1[2] = "Gopal";

        for (int i = 0; i < 3; i++) {

          Console.WriteLine(s1[i] + " ");
          }
        }
      }
    }
  ```

- **`this`** used as a **modifier of the first parameter** of an extension method:

  ```cs

  	// C# program to illustrate the concept
	// of the extension methods
	using System;

	namespace ExtensionMethod {

		// This class contains M4 and M5 method
		// Which we want to add in Geek class.
		// NewMethodClass is a static class
		static class NewMethodClass {

		// Method 4
		public static void M4(this Geek g)
		{
			Console.WriteLine("Method Name: M4");
		}

		// Method 5
		public static void M5(this Geek g, string str)
		{
			Console.WriteLine(str);
		}
	

		// Now we create a new class in which
		// Geek class access all the five methods
		public class GFG {

			// Main Method
			public static void Main(string[] args)
			{
				Geek g = new Geek();
				g.M1();
				g.M2();
				g.M3();
				g.M4();
				g.M5("Method Name: M5");
			}
		}
	}
  ```



### ref
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/this

https://www.programiz.com/csharp-programming/this-keyword

