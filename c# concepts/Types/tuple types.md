## Tuple types
Provides concise syntax to **group multiple data elements** in a lightweight data structure.

```cs
(double, int) t1 = (4.5, 3);
Console.WriteLine($"Tuple with elements {t1.Item1} and {t1.Item2}.");
// Output:
// Tuple with elements 4.5 and 3.

(double Sum, int Count) t2 = (4.5, 3);
Console.WriteLine($"Sum of {t2.Count} elements is {t2.Sum}.");
// Output:
// Sum of 3 elements is 4.5.
```

### Tuple field names
You can explicitly specify the names of tuple fields
```cs
var t = (Sum: 4.5, Count: 3);
Console.WriteLine($"Sum of {t.Count} elements is {t.Sum}.");

(double Sum, int Count) d = (4.5, 3);
Console.WriteLine($"Sum of {d.Count} elements is {d.Sum}.");


var sum = 4.5;
var count = 3;
var t = (sum, count);
Console.WriteLine($"Sum of {t.count} elements is {t.sum}.");

//The default names of tuple fields are Item1, Item2, Item3 and so on.
var t = (1, "two", 3);
Console.WriteLine($"The 1st element is {t.Item1}");
Console.WriteLine($"The 2nd element is {t.Item2}");
Console.WriteLine($"The 3rd element is {t.Item3}");
/*
The 1st element is 1
The 2nd element is two
The 3rd element is 3

*/
```

> **Note**: You must call the Tuple<T1,T2,T3,T4,T5,T6,T7,TRest>.Tuple<T1,T2,T3,T4,T5,T6,T7,TRest> constructor to create a tuple with nine or more components unless your language provides a special syntax for this purpose. The static (`Shared` in Visual Basic) methods of the Tuple class cannot be used to create a tuple with nine or more components.
