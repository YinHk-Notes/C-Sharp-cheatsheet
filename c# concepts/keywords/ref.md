## `ref` (parameter modifier)

You use the ref keyword in the following contexts:
- In a method signature and in a method call, to pass an argument to a method by reference. 
- In a method signature, to return a value to the caller by reference. 
- In a declaration of a local variable, to declare a reference variable. 
- As the part of a **conditional ref expression** or a `ref` **assignment operator**.
- In a `struct` declaration, to declare a `ref struct`.
- In a `ref struct` definition, to declare a `ref` field.

### Passing an argument by reference
When used in a method's parameter list, the `ref` keyword indicates that **an argument is passed by reference**, **not by value**.

`ref` is used to state that the parameter passed **may be modified by the method**.

To use a `ref` parameter, both the method definition and the calling method must explicitly use the `ref` keyword

if we use `ref` to pass the variable by reference, the variable is not copied into the method. Instead, the method follows the reference to access the original variable. Hence any change the called method makes to the value of the variable will be made to the original variable.

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

> An argument that is passed to a `ref` or `in` parameter **must be initialized before it's passed**.

> The `out` keyword is identical to the `ref` keyword,
> with the exception that `ref` needs the variable to **be initialized prior to being passed**. It is similar to `ref` keyword. But the main difference between `ref` and `out` keyword is that ref needs that the variable **must be initialized before it passed to the method**. But `out` parameter **doesn’t require the variables to be initialized before it passed to the method**.

### Reference return values
Reference return values (or ref returns) are values that a method returns by reference to the caller. That is, the caller can modify the value returned by a method, and that change is reflected in the state of the object in the called method.

A reference return value is defined by using the `ref` keyword:
- In the method signature.
  ```cs
    public ref decimal GetCurrentPrice()
  ```
- Between the `return` token and the variable returned in a `return` statement in the method.
  ```cs
    return ref DecimalArray[0];
  ```
  

https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/ref
