## `in` (parameter modifier)

`in` is used to state that the parameter passed **cannot be modified by the method**.

The `in` keyword in C# is used to specify that a method parameter is passed by reference, but the called method cannot modify the argument.

The `in` keyword **doesn’t allow parameter values to be changed**.

This is useful for parameters that are not modified by the called method, but must be passed by reference in order for the calling method to access the results.


```cs
int readonlyArgument = 44;
InArgExample(readonlyArgument);
Console.WriteLine(readonlyArgument);     // value is still 44

void InArgExample(in int number)
{
    // Uncomment the following line to see error CS8331
    //number = 19;
}
```


> Note: The `in` keyword can also be used with a generic type parameter to specify that the type parameter is contravariant, as part of a `foreach` statement, or as part of a `join` clause in a LINQ query.
> 
### ref
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/in-parameter-modifier \
https://www.pluralsight.com/guides/csharp-in-out-ref-parameters \
https://www.infoworld.com/article/3678688/how-to-use-the-in-out-and-ref-keywords-in-net-core.html
