## Named parameters
Named parameters **free you from matching the order of parameters to the order of parameters in the parameter lists** of called methods. The argument for each parameter can be specified by **parameter name**. For example, a function that prints order details (such as, seller name, order number & product name) can be called by sending arguments by position, in the order defined by the function.

Named parameters provides us the relaxation to remember or to look up the order of parameters in the parameter lists of called methods. The parameter for each argument can be specified by parameter name.


Eg:
```cs
NamedParameterFunction(firstName: "Hello", lastName: "World")
```


```cs
using System;
namespace DemoApplication{
   class Demo{
      static void Main(string[] args){
         NamedParameterFunction("James", "Bond");
         NamedParameterFunction(firstName:"Mark", lastName:"Wood");
         NamedParameterFunction(lastName: "Federer", firstName: "Roger");
         Console.ReadLine();
      }
      public static void NamedParameterFunction(string firstName, string lastName){
         Console.WriteLine($"FullName: {firstName} {lastName}");
      }
   }
}
```

```cs
static void MyMethod(string child1, string child2, string child3) 
{
  Console.WriteLine("The youngest child is: " + child3);
}

static void Main(string[] args)
{
  MyMethod(child3: "John", child1: "Liam", child2: "Liam");
}

// The youngest child is: John
```

### ref
https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/named-and-optional-arguments#named-arguments

https://www.tutorialspoint.com/what-are-named-parameters-in-chash

https://www.w3schools.com/cs/cs_method_parameters_named_args.php



