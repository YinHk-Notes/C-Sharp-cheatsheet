## out(parameter modifier)

`out` allows you to pass parameters using **references** and to **change the values** of those parameters as well.

> The `out` keyword is identical to the `ref` keyword, with the exception that `ref` needs the variable to be initialized prior to being passed.

>  When working with the out keyword in C#, both the method signature and the calling method **must explicitly specify the `out` keyword**.

Eg:
```cs
int number;
OutDemo(out number);
Console.WriteLine(number); //The value is now 100
void OutDemo(out int number)
{
    number = 100;
}
```

### ref
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/out-parameter-modifier \
https://www.infoworld.com/article/3678688/how-to-use-the-in-out-and-ref-keywords-in-net-core.html \
https://www.pluralsight.com/guides/csharp-in-out-ref-parameters


