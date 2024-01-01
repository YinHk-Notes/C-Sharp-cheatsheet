## Comparison Delegate

Comparison Delegate represents the method that **compares two objects of the same type**.

```cs
public delegate int Comparison<in T>(T x, T y);
```
- **`X`** is the first object to compare.
- **`Y`** is the second object to compare.

Return value **`int`**: 

- Less than 0: x is less than y
- 0: x equals y
- Greater than 0: x is greater than y.


```cs
using System;
using System.Collections.Generic;

public class Example
{
    private static int CompareDinosByLength(string x, string y)
    {
        if (x == null)
        {
            if (y == null)
            {
                // If x is null and y is null, they're
                // equal.
                return 0;
            }
            else
            {
                // If x is null and y is not null, y
                // is greater.
                return -1;
            }
        }
        else
        {
            // If x is not null...
            //
            if (y == null)
                // ...and y is null, x is greater.
            {
                return 1;
            }
            else
            {
                // ...and y is not null, compare the
                // lengths of the two strings.
                //
                int retval = x.Length.CompareTo(y.Length);

                if (retval != 0)
                {
                    // If the strings are not of equal length,
                    // the longer string is greater.
                    //
                    return retval;
                }
                else
                {
                    // If the strings are of equal length,
                    // sort them with ordinary string comparison.
                    //
                    return x.CompareTo(y);
                }
            }
        }
    }

    public static void Main()
    {
        List<string> dinosaurs = new List<string>();
        dinosaurs.Add("Pachycephalosaurus");
        dinosaurs.Add("Amargasaurus");
        dinosaurs.Add("");
        dinosaurs.Add(null);
        dinosaurs.Add("Mamenchisaurus");
        dinosaurs.Add("Deinonychus");
        Display(dinosaurs);

        Console.WriteLine("\nSort with generic Comparison<string> delegate:");
        dinosaurs.Sort(CompareDinosByLength);
        Display(dinosaurs);
    }

    private static void Display(List<string> list)
    {
        Console.WriteLine();
        foreach( string s in list )
        {
            if (s == null)
                Console.WriteLine("(null)");
            else
                Console.WriteLine("\"{0}\"", s);
        }
    }
}

/* This code example produces the following output:

"Pachycephalosaurus"
"Amargasaurus"
""
(null)
"Mamenchisaurus"
"Deinonychus"

Sort with generic Comparison<string> delegate:

(null)
""
"Deinonychus"
"Amargasaurus"
"Mamenchisaurus"
"Pachycephalosaurus"
 */
```




### ref 
https://learn.microsoft.com/en-us/dotnet/api/system.comparison-1?view=net-8.0



