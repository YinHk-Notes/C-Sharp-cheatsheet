## `readonly`

The `readonly` keyword is a modifier that can be used in four contexts:

1. In a **field declaration**, `readonly` indicates that assignment to the field can **only occur as part of the declaration** or in a **constructor** in the **same class**.
   You are allowed to declare a field using `readonly` modifier. It indicates that the assignment to the fields is only the part of the declaration or in a constructor to the same class.
    A `readonly` field can be assigned and reassigned multiple times within the field declaration and constructor. \
    A `readonly` field **can't be assigned after the constructor exits**. This rule has different implications for value types and reference types:
    - Because value types directly contain their data, a field that is a `readonly` value type is immutable.
    - Because reference types contain a reference to their data, a field that is a `readonly` reference type must always refer to the same object. That object isn't immutable. The `readonly` modifier prevents the field from being replaced by a different instance of the reference type. However, the modifier doesn't prevent the instance data of the field from being modified through the read-only field.
  
```cs
class Age
{
    private readonly int _year;
    Age(int year)
    {
        _year = year;
    }
    void ChangeYear()
    {
        //_year = 1967; // Compile error if uncommented.
    }
}
```

   You can assign a value to a `readonly` field only in the following contexts:
   - When the variable is initialized in the declaration, for example:
      ```cs
         public readonly int y = 5;
      ```
   - In an instance constructor of the class that contains the instance field declaration.
   - In the `static` constructor of the class that contains the `static` field declaration.





2. In a `readonly` **struct** type definition, readonly indicates that the structure type is **immutable**.
    https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/struct#readonly-struct
3. In an **instance member declaration** within a structure type, `readonly` indicates that an instance member **doesn't modify the state of the structure**.
   ```cs
         // C# program to illustrate how
         // to create a readonly member
         using System;

         public struct Customer
         {

	         public string Name { get; }
	         public int Price { get; }

	         // Readonly member
	         public readonly string Product { get; }

	         public Customer(string name, string product, int price)
	         {

		         this.Name = name;
		         this.Product = product;
		         this.Price = price;
	         }
          }

          class GFG {
               // Main method
	            static public void Main()
	            {
		               Customer a = new Customer("Sumit", "Mobile Phone", 2398);
		               Console.WriteLine("Customer name: " + a.Name);
		               Console.WriteLine("Product: " + a.Product);
		               Console.WriteLine("Price: " + a.Price);
	            }
            }
      ```
   https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/struct#readonly-instance-members
4. In a `ref` `readonly` method return, the `readonly` modifier indicates that method returns a reference and **writes aren't allowed** to that reference.
   ```cs
      private static readonly SamplePoint s_origin = new SamplePoint(0, 0, 0);
      public static ref readonly SamplePoint Origin => ref s_origin;
   ```





### ref 
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/readonly

https://www.geeksforgeeks.org/readonly-in-c-sharp/

