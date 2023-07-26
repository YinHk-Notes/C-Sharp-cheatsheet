### `var`

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

We can use the var keyword to declare array data types where we **don't have predefined datatypes**.
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

### ref
https://www.c-sharpcorner.com/UploadFile/5ef30d/var-keyword-in-C-Sharp-programming/

https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/declarations#implicitly-typed-local-variables

