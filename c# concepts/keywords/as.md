## `as`
The `as` operator explicitly **converts the result of an expression to a given reference** or **nullable value type**. If the conversion isn't possible, the `as` operator returns `null`.

Unlike a cast expression, the `as` operator **never throws an exception**.

```cs
E as T
```
where `E` is an expression that returns a value and `T` is the name of a type or a type parameter, produces the same result as


```cs
E is T ? (T)(E) : (T)null
```





### ref
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/type-testing-and-cast#as-operator
