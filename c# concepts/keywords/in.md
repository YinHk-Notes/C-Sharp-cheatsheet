## `in` (parameter modifier)

The `in` keyword is used in the following contexts:

- generic type parameters in generic interfaces and delegates.
- As a parameter modifier, which lets you pass an argument to a method by reference rather than by value.
- `foreach` statements for iteration.
- `from` clauses in LINQ query expressions.
- `join` clauses in LINQ query expressions.

`in` is used to state that the parameter passed **cannot be modified by the method**.

The `in` keyword in C# is used to specify that a method parameter is **passed by reference**, but the called method **cannot modify the argument**.

The `in` keyword **doesn’t allow parameter values to be changed**.

This is useful for parameters that are not modified by the called method, but **must be passed by reference** in order for the calling method to access the results.


Variables passed as in arguments **must be initialized** before being passed in a method call. However, the called method **may not assign a value or modify the argument**.



```cs
int readonlyArgument = 44;
InArgExample(readonlyArgument);
Console.WriteLine(readonlyArgument);     // value is still 44

void InArgExample(in int number)
{
    // Uncomment the following line to see error CS8331
    // number = 19;
}
```

**Overloading** based on the presence of in is allowed:

Eg:
```cs
class InOverloads
{
    public void SampleMethod(in int i) { }
    public void SampleMethod(int i) { }
}
```



> Note: The `in` keyword can also be used with a generic type parameter to specify that the type parameter is contravariant, as part of a `foreach` statement, or as part of a `join` clause in a LINQ query.


### Limitations on `in` parameters

You can't use the in, ref, and out keywords for the following kinds of methods:

- Async methods, which you define by using the `async` modifier.
- Iterator methods, which include a `yield` return or `yield break` statement.
- The first argument of an extension method cannot have the in modifier unless that argument is a struct.
- The first argument of an extension method where that argument is a generic type (even when that type is constrained to be a struct.)

### `foreach` statement

Eg:
```cs
var fibNumbers = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };
foreach (int element in fibNumbers)
{
    Console.Write($"{element} ");
}
// Output:
// 0 1 1 2 3 5 8 13
```


### ref
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/in-parameter-modifier \
https://www.pluralsight.com/guides/csharp-in-out-ref-parameters \
https://www.infoworld.com/article/3678688/how-to-use-the-in-out-and-ref-keywords-in-net-core.html
