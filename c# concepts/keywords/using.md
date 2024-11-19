## using

The **`using`** keyword has two major uses:
- The **`using`** statement defines a **scope** at the end of which an **object is disposed**:
  ```cs
    string filePath = "example.txt";
    string textToWrite = "Hello, this is a test message!";

    // Use the using statement to ensure the StreamWriter is properly disposed of
    using (StreamWriter writer = new StreamWriter(filePath))
    {
        writer.WriteLine(textToWrite);
    }
  ```
- The **`using`** directive creates an **alias for a namespace** or **imports types** defined in other namespaces:
  ```cs
    using System;
    using System.IO;
  ```

### using()
```cs
using (expression)
{
    // ...
}
```

The **`using`** statement defines a scope at the end of which the Dispose() method of the object is called.

Basic Syntax: 
```cs
using (var resource = new SomeDisposableResource())
{
    // Work with the resource
}
// resource.Dispose() is called automatically here.

```

Equivalent Code Without **`using`**:

```cs
var resource = new SomeDisposableResource();
try
{
    // Work with the resource
}
finally
{
    resource.Dispose(); // Manually dispose of the resource
}

```
### **When to Use `using`:**

You use `using` when working with objects that implement `IDisposable`. Common examples include:

- File handling:
  ```cs
    using (var reader = new StreamReader("file.txt"))
    {
        string content = reader.ReadToEnd();
    } // The StreamReader is disposed automatically here.

  ```
- Database connections:
  ```cs
    using (var connection = new SqlConnection(connectionString))
    {
        connection.Open();
        // Perform database operations
    } // Connection is disposed automatically here.

  ```
- Network streams:
  ```cs
    using (var client = new TcpClient("example.com", 80))
    using (var stream = client.GetStream())
    {
        // Work with the network stream
    }
  ```

### **Features of `using`:**

1.  **Scope Control:**
    -   The object is valid only within the `using` block. After the block, the object is disposed and cannot be accessed.
2.  **Exception Safety:**
    -   If an exception occurs within the block, the `Dispose()` method is still called, ensuring proper cleanup.
3.  **Multiple Resources:**
    -   You can manage multiple disposable objects in a single `using` statement:
    ```cs
        using (var reader = new StreamReader("file.txt"))
        using (var writer = new StreamWriter("output.txt"))
        {
            writer.Write(reader.ReadToEnd());
        }
    ```

        
### **Limitations of `using`:**

1.  **IDisposable Requirement:**
    -   Only objects implementing the `IDisposable` interface can be used with `using`.
2.  **Scope Restriction:**
    -   The object is disposed immediately after exiting the `using` block. If you need the object to persist beyond that scope, `using` isn't suitable.
3.  **Single Use:**
    -   You cannot reuse an object after it has been disposed.



### ref 
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using \
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/using




