## `throw`
The `throw` statement **throws an exception**:

```cs
if (shapeAmount <= 0)
{
    throw new ArgumentOutOfRangeException(nameof(shapeAmount), "Amount of shapes must be positive.");
}
```


Inside a `catch` block, you can use a `throw`; statement to **re-throw the exception** that is handled by the `catch` block:
```cs
try
{
    ProcessShapes(shapeAmount);
}
catch (Exception e)
{
    LogError(e, "Shape processing failed.");
    throw;
}
```

> **Note**: `throw`; preserves the original stack trace of the exception, which is **stored in the `Exception.StackTrace` property**. Opposite to that, throw e; updates the **StackTrace** property of `e`.

### ref
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/exception-handling-statements#the-throw-statement

