## String interpolation


The **`$`** character identifies a string literal as an _interpolated string_. An interpolated string is a string literal that might contain _interpolation expressions_. When an interpolated string is resolved to a result string, items with interpolation expressions are replaced by the string representations of the expression results.


Eg:
```cs
var name = "Mark";
var date = DateTime.Now;

// Composite formatting:
Console.WriteLine("Hello, {0}! Today is {1}, it's {2:HH:mm} now.", name, date.DayOfWeek, date);
// String interpolation:
Console.WriteLine($"Hello, {name}! Today is {date.DayOfWeek}, it's {date:HH:mm} now.");
// Both calls produce the same output that is similar to:
// Hello, Mark! Today is Wednesday, it's 19:40 now.
```



### ref 
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated
