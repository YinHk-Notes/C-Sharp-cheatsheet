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
  

### ref 
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using

