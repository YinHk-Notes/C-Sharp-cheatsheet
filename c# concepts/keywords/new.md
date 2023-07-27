## `new` operator

The new operator creates a new instance of a type. You can also use the new keyword as a member declaration modifier or a generic type constraint.


### Constructor invocation

To create a new instance of a type

```cs
var dict = new Dictionary<string, int>();
dict["first"] = 10;
dict["second"] = 20;
dict["third"] = 30;

Console.WriteLine(string.Join("; ", dict.Select(entry => $"{entry.Key}: {entry.Value}")));
// Output:
// first: 10; second: 20; third: 30
```

### Target-typed `new`
Beginning with C# 9.0, constructor invocation expressions are target-typed. That is, if a target type of an expression is known, you can omit a type name


```cs
List<int> xs = new();
List<int> ys = new(capacity: 10_000);
List<int> zs = new() { Capacity = 20_000 };

Dictionary<int, List<int>> lookup = new()
{
    [1] = new() { 1, 2, 3 },
    [2] = new() { 5, 8, 3 },
    [5] = new() { 1, 0, 4 }
};
```

### Array creation
You also use the `new` operator to create an array instance

```cs
var numbers = new int[3];
numbers[0] = 10;
numbers[1] = 20;
numbers[2] = 30;

Console.WriteLine(string.Join(", ", numbers));
// Output:
// 10, 20, 30
```

```cs
var a = new int[3] { 10, 20, 30 };
var b = new int[] { 10, 20, 30 };
var c = new[] { 10, 20, 30 };
Console.WriteLine(c.GetType());  // output: System.Int32[]
```

### Instantiation of anonymous types
To create an instance of an **anonymous type**, use the `new` operator and object initializer syntax:

```cs
var example = new { Greeting = "Hello", Name = "World" };
Console.WriteLine($"{example.Greeting}, {example.Name}!");
// Output:
// Hello, World!
```

### ref
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/new-operator


