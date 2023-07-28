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

### `finally`
In programming, sometimes an exception may cause an error which ends the current method. However, that method might have **opened a file or a network that needs to be closed**. So, to overcome such types of problem, C# provides a special keyword named as `finally` keyword.

You can also use the `finally` block to clean up allocated resources used in the `try` block.

The `finally` block will execute when the `try` / `catch` block **leaves the execution**, **no matter what condition cause it**. **It always executes whether the try block terminates normally or terminates due to an exception.** The main purpose of `finally` block is to **release the system resources**. The `finally` block follows `try` / `catch` block.

```cs
try {

    // code...
}

// this is optional
catch {

   // code..
}

finally
{
    // code..
}
```

-   In C#, multiple `finally` blocks in the same program are not allowed.
-   The `finally` block does not contain any return, continue, break statements because it does not allow controls to leave the `finally` block.
-   You can also use `finally` block only with a try block means without a `catch` block but in this situation, no exceptions are handled.
-   The `finally` block will be executed after the try and catch blocks, but before control transfers back to its origin.


### ref
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/exception-handling-statements#the-try-catch-statement

https://www.geeksforgeeks.org/c-sharp-finally-keyword/


