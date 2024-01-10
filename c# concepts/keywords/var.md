## `var`

**`var`** is used to declare a **implicitly-typed local variable**. 

When you declare a local variable, you can let the compiler **infer the type of the variable from the initialization** expression. To do that use the **`var`** keyword instead of the name of a type


**Implicitly typed local variables** are strongly typed just as if you had declared the type yourself, but the **compiler determines the type at run time** depending on the **value stored** in them.

The use of var allows you to **not repeat a type name** in a **variable declaration** and **object instantiation**.


 
```cs
var greeting = "Hello";
Console.WriteLine(greeting.GetType());  // output: System.String

var a = 32;
Console.WriteLine(a.GetType());  // output: System.Int32

var xs = new List<double>();
Console.WriteLine(xs.GetType());  // output: System.Collections.Generic.List`1[System.Double]
```

> **Note**: When you use var in the enabled nullable aware context and the type of an initialization expression is a reference type, the compiler always infers a nullable reference type even if the type of an initialization expression isn't nullable.


### Use constructor invocation expression
A common use of var is with a constructor invocation expression.


The use of `var` allows you to not repeat a type name in a variable declaration and object instantiation

Eg:
```cs
var xs = new List<int>();

```
Beginning with C# 9.0, you can use a **target-typed** `new` expression as an alternative:
```cs
List<int> xs = new();
List<int>? ys = new();

```

### Declare the array with the `var` keyword in C#
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


### Use `var` with anonymous types
> When you work with anonymous types, you **must** use implicitly-typed local variables.
Anonymous types provide a convenient way to encapsulate a set of read-only properties into a single object without having to explicitly define a type first.


```cs
var product = new Product();
var bonus = new { note = "You won!" };
var shipment = new { address = "Nowhere St.", product };
var shipmentWithBonus = new { address = "Somewhere St.", product, bonus };
```


https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/anonymous-types



### Use `var` in query expression
```cs
var fromPhoenix = from cust in customers
                  where cust.City == "Phoenix"
                  select new { cust.Name, cust.Phone };

foreach (var customer in fromPhoenix)
{
    Console.WriteLine($"Name={customer.Name}, Phone={customer.Phone}");
}
```

```cs
// Variable queryId could be declared by using
// System.Collections.Generic.IEnumerable<string>
// instead of var.
var queryId =
    from student in students
    where student.Id > 111
    select student.LastName;

// Variable str could be declared by using var instead of string.
foreach (string str in queryId)
{
    Console.WriteLine("Last name: {0}", str);
}
```

```CS
private static void QueryNames(char firstLetter)
{
    // Create the query. Use of var is required because
    // the query produces a sequence of anonymous types:
    // System.Collections.Generic.IEnumerable<????>.
    var studentQuery =
        from student in students
        where student.FirstName[0] == firstLetter
        select new { student.FirstName, student.LastName };

    // Execute the query and display the results.
    foreach (var anonType in studentQuery)
    {
        Console.WriteLine("First = {0}, Last = {1}", anonType.FirstName, anonType.LastName);
    }
}
```

### When to use a `var` in C#

Don’t use var for simple local variable types that are known to you. Use of var when you’re not sure what type of data will be stored in a variable.



### ref
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/declarations#implicitly-typed-local-variables

https://www.c-sharpcorner.com/UploadFile/5ef30d/var-keyword-in-C-Sharp-programming/
