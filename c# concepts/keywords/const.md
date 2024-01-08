## const
To declare a local constant, use the `const` keyword

You use the const keyword to declare a constant field or a local constant. Constant fields and locals aren't variables and may not be modified. Constants can be numbers, Boolean values, strings, or a null reference.



> When you declare a local constant, you **must** also **initialize it immediately**.

> **Note**: The **`readonly`** keyword differs from the const keyword. A **`const`** field can only be **initialized at the declaration** of the field. A **`readonly`** field can be **initialized either at the declaration or in a constructor**. Therefore, **`readonly`** fields can have **different values depending on the constructor used**.

eg:
```cs
const string Greeting = "Hello";
const double MinLimit = -10.0, MaxLimit = -MinLimit;
```


### ref
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/const

