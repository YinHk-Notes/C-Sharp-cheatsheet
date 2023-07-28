## `default`

You can use the **`default`** keyword in the following contexts:

- To specify the `default` case in the `switch` statement.
- As the `default` operator or literal to produce the `default` value of a type.
- As the default type constraint on a generic method override or explicit interface implementation.



### default value expressions

#### default operator
The argument to the `default` operator must be the name of a type or a type parameter

```cs
Console.WriteLine(default(int));  // output: 0
Console.WriteLine(default(object) is null);  // output: True

void DisplayDefaultOf<T>()
{
    var val = default(T);
    Console.WriteLine($"Default value of {typeof(T)} is {(val == null ? "null" : val.ToString())}.");
}

DisplayDefaultOf<int?>();
DisplayDefaultOf<System.Numerics.Complex>();
DisplayDefaultOf<System.Collections.Generic.List<int>>();
// Output:
// Default value of System.Nullable`1[System.Int32] is null.
// Default value of System.Numerics.Complex is (0, 0).
// Default value of System.Collections.Generic.List`1[System.Int32] is null.
```




#### default literal
You can use the `default` literal to produce the default value of a type when the compiler can infer the expression type. The `default` literal expression produces the same value as the `default(T)` expression where `T` is the inferred type.

```cs
T[] InitializeArray<T>(int length, T initialValue = default)
{
    if (length < 0)
    {
        throw new ArgumentOutOfRangeException(nameof(length), "Array length must be nonnegative.");
    }

    var array = new T[length];
    for (var i = 0; i < length; i++)
    {
        array[i] = initialValue;
    }
    return array;
}

void Display<T>(T[] values) => Console.WriteLine($"[ {string.Join(", ", values)} ]");

Display(InitializeArray<int>(3));  // output: [ 0, 0, 0 ]
Display(InitializeArray<bool>(4, default));  // output: [ False, False, False, False ]

System.Numerics.Complex fillValue = default;
Display(InitializeArray(3, fillValue));  // output: [ (0, 0), (0, 0), (0, 0) ]
```



### ref
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default

https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/default

https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/where-generic-type-constraint

