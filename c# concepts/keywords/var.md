### `var`

C# allows variables to be declared as **explicit type or implicit type**.  
The C# `var` keyword is used to **declare implicit type variable**s in C#. 

```cs
var name = "C# Corner"; // Implicitly typed.  
string name = "C# Corner"; // Explicitly typed.  
var age = 30;
```

We can use the var keyword to declare array data types where we don't have predefined datatypes
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