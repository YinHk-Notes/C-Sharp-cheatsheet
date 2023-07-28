## `is`

The `is` operator checks if the run-time type of an expression result is compatible with a given type. The `is` operator also tests an expression result against a pattern.


```cs
E is T
```

where `E` is an expression that returns a value and `T` is the name of a type or a type parameter. `E` can't be an anonymous method or a lambda expression.

The `is` operator returns `true` when an expression result is non-null and any of the following conditions are true:


- The run-time type of an expression result is `T`.

- The run-time type of an expression result derives from type `T`, implements interface `T`, or another implicit reference conversion exists from it to `T`.

- The run-time type of an expression result is a nullable value type with the underlying type `T` and the `Nullable<T>.HasValue` is true.

- A boxing or unboxing conversion exists from the run-time type of an expression result to type `T`.


> The is operator doesn't consider user-defined conversions.

```cs
public class Base { }

public class Derived : Base { }

public static class IsOperatorExample
{
    public static void Main()
    {
        object b = new Base();
        Console.WriteLine(b is Base);  // output: True
        Console.WriteLine(b is Derived);  // output: False

        object d = new Derived();
        Console.WriteLine(d is Base);  // output: True
        Console.WriteLine(d is Derived); // output: True
    }
}
```
### ref
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/type-testing-and-cast#is-operator
