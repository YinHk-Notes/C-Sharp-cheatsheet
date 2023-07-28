## `try`, `catch` and `finally`

### `try-catch`

Use the `try-catch` statement to handle exceptions that might occur during execution of a code block. Place the code where an exception might occur inside a `try` block. Use a `catch` clause to specify the base type of exceptions you want to handle in the corresponding `catch` block

```cs
try
{
    var result = Process(-3, 4);
    Console.WriteLine($"Processing succeeded: {result}");
}
catch (ArgumentException e)
{
    Console.WriteLine($"Processing failed: {e.Message}");
}
```

You can provide several catch clauses
```cs
try
{
    var result = await ProcessAsync(-3, 4, cancellationToken);
    Console.WriteLine($"Processing succeeded: {result}");
}
catch (ArgumentException e)
{
    Console.WriteLine($"Processing failed: {e.Message}");
}
catch (OperationCanceledException)
{
    Console.WriteLine("Processing is cancelled.");
}

```


### ref
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/exception-handling-statements#the-try-catch-statement
