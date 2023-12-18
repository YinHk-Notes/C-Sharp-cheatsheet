## Predicate<T> Delegate
A **Predicate** is a **delegate** that accepts **one or more generic parameters** and **returns a boolean value**.

**Predicate** delegates are typically used to **perform search operations based on a set of criteria**.

**Predicates** in C# are implemented with **delegates**. The **Predicate delegate** represents the method that **defines a set of criteria** and **determines whether the specified object meets those criteria**.


```cs
public delegate bool Predicate<in T>(T obj);

```


```cs
using System;
using System.Drawing;

public class Example
{
   public static void Main()
   {
      // Create an array of Point structures.
      Point[] points = { new Point(100, 200),
                         new Point(150, 250), new Point(250, 375),
                         new Point(275, 395), new Point(295, 450) };

      // Define the Predicate<T> delegate.
      Predicate<Point> predicate = FindPoints;

      // Find the first Point structure for which X times Y
      // is greater than 100000.
      Point first = Array.Find(points, predicate);

      // Display the first structure found.
      Console.WriteLine("Found: X = {0}, Y = {1}", first.X, first.Y);
   }

   private static bool FindPoints(Point obj)
   {
      return obj.X * obj.Y > 100000;
   }
}
// The example displays the following output:
//        Found: X = 275, Y = 395
```

```cs
var data = new List<int> { 1, -2, 3, 0, 2, -1 };

var predicate = new Predicate<int>(isPositive);
var filtered = data.FindAll(predicate);

Console.WriteLine(string.Join(",", filtered));

bool isPositive(int val)
{
    return val > 0;
}
```

### Predicate with anonymous method

```cs
var data = new List<int> { 1, -2, 3, 0, 2, -1 };

Predicate<int> isPositive = delegate(int val) { return val > 0; };
var filtered = data.FindAll(isPositive);

Console.WriteLine(string.Join(",", filtered));
```

### Predicate with lambda expression
```cs

var words = new List<string> { "falcon", "wood", "tree",
    "rock", "cloud", "rain" };

Predicate<string> hasFourChars = word => word.Length == 4;

var words2 = words.FindAll(hasFourChars);
Console.WriteLine(string.Join(',', words2));
```



### ref
https://www.tutorialsteacher.com/csharp/csharp-predicate

https://learn.microsoft.com/en-us/dotnet/api/system.predicate-1?view=net-7.0

https://zetcode.com/csharp/predicate/

https://www.youtube.com/watch?v=zFcLTc1qHlM&t=1s

https://www.youtube.com/watch?v=LlZpno4_ylw

