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

> The `as` operator considers only reference, nullable, boxing, and unboxing conversions. You can't use the `as` operator to perform a user-defined conversion. To do that, use a **cast expression**.

Eg:
```cs
IEnumerable<int> numbers = new[] { 10, 20, 30 };
IList<int> indexable = numbers as IList<int>;
if (indexable != null)
{
    Console.WriteLine(indexable[0] + indexable[indexable.Count - 1]);  // output: 40
}
```

### ref
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/type-testing-and-cast#as-operator
