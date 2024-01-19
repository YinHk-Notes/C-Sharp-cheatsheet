## Lambda Expressions
Use a **lambda expression** to create an **anonymous method**.

**Lambda expressions** in C# are used like **anonymous functions**, with the difference that in **Lambda expressions you don’t need to specify the type of the value** that you input thus making it more flexible to use. 

```cs
(input-parameters) => expression
```
```cs
(input-parameters) => { <sequence-of-statements> }
```
```cs
[Return type] [Method name] (input-parameters) => { <sequence-of-statements> }
```

Eg:

```cs
string GetListItem(int i, List<string> li) => li[i];

```

```cs
Func<int, int> square = x => x * x;
Console.WriteLine(square(5));
// Output:
// 25
```
```cs
System.Linq.Expressions.Expression<Func<int, int>> e = x => x * x;
Console.WriteLine(e);
// Output:
// x => (x * x)
```
```cs
int[] numbers = { 2, 3, 4, 5 };
var squaredNumbers = numbers.Select(x => x * x);
Console.WriteLine(string.Join(" ", squaredNumbers));
// Output:
// 4 9 16 25
```

Sometimes the compiler can't infer the types of input parameters. You can specify the types explicitly
eg:
```cs
Func<int, string, bool> isTooLong = (int x, string s) => s.Length > x;

```




### ref
https://www.geeksforgeeks.org/lambda-expressions-in-c-sharp/

https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions

