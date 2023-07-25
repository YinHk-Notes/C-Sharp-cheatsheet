## ref

You use the ref keyword in the following contexts:
- In a method signature and in a method call, to pass an argument to a method by reference. 
- In a method signature, to return a value to the caller by reference. 
- In a declaration of a local variable, to declare a reference variable. 
- As the part of a **conditional ref expression** or a `ref` **assignment operator**.
- In a `struct` declaration, to declare a `ref struct`.
- In a `ref struct` definition, to declare a `ref` field.

### Passing an argument by reference
When used in a method's parameter list, the `ref` keyword indicates that an argument is passed by reference, not by value.


To use a `ref` parameter, both the method definition and the calling method must explicitly use the `ref` keyword

Eg:
```cs
void Method(ref int refArgument)
{
    refArgument = refArgument + 44;
}

int number = 1;
Method(ref number);
Console.WriteLine(number);
// Output: 45
```

> An argument that is passed to a `ref` or `in` parameter must be initialized before it's passed.


https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/ref
