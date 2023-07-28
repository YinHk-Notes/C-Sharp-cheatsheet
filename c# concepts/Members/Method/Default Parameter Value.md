## Default Parameter Value

You can use a default parameter value, by using the equals sign `=`.


```cs
using System;

namespace MyApplication
{
  class Program
  {
    static void MyMethod(string country = "Canada")
    {
      Console.WriteLine(country);
    }

    static void Main(string[] args)
    {
      MyMethod("Sweden");
      MyMethod("India");
      MyMethod();
      MyMethod("USA");
    }
  }
}

/*
output:
Sweden
India
Canada
USA
*/
```

### ref
https://www.w3schools.com/cs/cs_method_parameters_default.php


