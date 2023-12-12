## Extension Method

In C#, the extension method concept allows you to **add new methods in the existing class or in the structure without modifying the source code of the original type** and you do not require any kind of special permission from the original type and there is no need to re-compile the original type. It is introduced in C# 3.0.

Extension methods enable you to "add" methods to existing types without creating a new derived type, recompiling, or otherwise modifying the original type.


Extension methods are **`static` methods**, but they're called as if they were instance methods on the **extended type**.

Extension methods, as the name suggests, are additional methods. Extension methods allow you to inject additional methods without modifying, deriving or recompiling the original class, struct or interface.


-   Extension methods allow existing classes to be extended without relying on inheritance or changing the class's source code.
-   If the class is **`sealed`**, there is no concept of extending its functionality. For this, a new concept is introduced, in other words, extension methods.
-   This feature is important for all developers, especially if you would like to use the dynamism of the C# enhancements in your class's design.
-   Extension methods are additional custom methods which were originally not included with the class.
-   Extension methods can be added to custom, .NET Framework or third party classes, structs or interfaces.
-   The first parameter of the extension method must be of the type for which the extension method is applicable, preceded by the **`this`** keyword.
-   Extension methods can be used anywhere in the application by including the **namespace of the extension method**.
-   An extension method is actually a special kind of **`static`** method defined in a **`static`** class.
-   The only difference between a regular static method and an extension method is that the **first parameter** of the extension method specifies the type that it is going to operator on, preceded by the **`this`** keyword.



### How to use? 
For example,  you have a class or a structure which contains three methods and you want to add two new methods in this class or structure, 
you did not have the source code of the class/structure, or do not have permissions from the class/structure, or the class is a sealed class, 
but you still want to add new methods in it, then you can use the concept extension method to add the new method in the existing class/structure.

Now you create a new class which is **`static`** and contain the two methods which you want to add in the existing class, now **bind this class with the existing class**. After **binding** you will see the existing class can access the two new added methods.

use the **binding parameter** to bind these methods
Eg:
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

```cs
namespace ExtensionMethods
{
    public static class IntExtensions
     {
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }
    }
}




using ExtensionMethods;

class Program
{
    static void Main(string[] args)
    {
        int i = 10;

        bool result = i.IsGreaterThan(100);  //IsGreaterThan method now is a method of int data type (Int32 struct).

        Console.WriteLine(result);
    }
}

```



#### Steps
1. Create a **`static`** Class for Extension Methods
2. Define an Extension Method(**`static` method**)
3. The first parameter use **`this`** modifier specify the class or struct to bind.


### ref
https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods

https://www.tutorialsteacher.com/csharp/csharp-extension-method

https://www.c-sharpcorner.com/uploadfile/puranindia/extension-methods-in-C-Sharp-3-0/

https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-implement-and-call-a-custom-extension-method

https://www.geeksforgeeks.org/extension-method-in-c-sharp/

