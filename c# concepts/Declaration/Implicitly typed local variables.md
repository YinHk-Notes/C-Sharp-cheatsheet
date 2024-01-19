### Implicitly typed local variables

C# allows variables to be declared as **explicit type or implicit type**.  

The C# `var` keyword is used to **declare implicit type variable**s in C#. 

A common use of `var` is with a **constructor invocation expression**. 


**Implicitly typed local variables** are strongly typed just as if you had declared the type yourself, but the compiler determines the type at **run time** **depending on the value stored** in them.


The use of `var` allows you to **not repeat a type name** in a variable declaration and object instantiation

```cs
var name = "C# Corner"; // Implicitly typed.  
string name = "C# Corner"; // Explicitly typed.  
var age = 30;
```

We can use the **`var`** keyword to declare **array data types** where we **don't have predefined datatypes**.
```cs
using System;  
using System.Text;  
using System.Collections;  
  
namespace ConsoleApplication1  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            var aInt = new int[] { 1, 2, 3, 4, 5, 6 };  
            foreach (var item in aInt)  
            {  
                Console.Write(item.ToString());  
            }  
            Console.Read();  
        }  
    }  
} 
```

The following restrictions apply to implicitly-typed variable declarations:

-   **`var`** can only be used when a local variable is **declared and initialized** in the **same statement**; the variable cannot be initialized to null, or to a method group or an anonymous function.
    
-   **`var`** **cannot be used on fields** at **class scope**.
    
-   Variables declared by using **`var`** cannot be used in the initialization expression. In other words, this expression is legal: **`int i = (i = 20);`** but this expression produces a compile-time error: **`var i = (i = 20);`**
    
-   Multiple implicitly-typed variables cannot be initialized in the same statement.
    
-   If a type named **`var`** is in scope, then the **`var`** keyword will resolve to that type name and will not be treated as part of an implicitly typed local variable declaration.

Implicit typing with the var keyword can only be **applied to variables at local method scope**. Implicit typing is **not available for class fields** as the C# compiler would encounter a logical paradox as it processed the code: the compiler needs to know the type of the field, but it cannot determine the type until the assignment expression is analyzed, and the expression cannot be evaluated without knowing the type.

### ref
https://www.c-sharpcorner.com/UploadFile/5ef30d/var-keyword-in-C-Sharp-programming/

https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/declarations#implicitly-typed-local-variables

https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/implicitly-typed-local-variables

https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-use-implicitly-typed-local-variables-and-arrays-in-a-query-expression


