## `async` and `await`

Asynchronous programming is a programming technique that allows code to be executed concurrently without blocking the execution of the calling thread

In other words, asynchronous code can run in the background while other code is executing. 

### `async`
Use the `async` modifier to specify that a method, lambda expression, or anonymous method is asynchronous. If you use this modifier on a method or expression, it's referred to as an _async method_.

```cs
public async Task<int> ExampleMethodAsync()
{
    //...
}
```

### `await`

The `await` operator suspends evaluation of the enclosing async method until the asynchronous operation represented by its operand completes.

When the asynchronous operation completes, the `await` operator returns the result of the operation, if any. When the `await` operator is applied to the operand that represents an already completed operation, it returns the result of the operation immediately without suspension of the enclosing method. The `await` operator doesn't block the thread that evaluates the async method. When the `await` operator suspends the enclosing async method, the control returns to the caller of the method.

```cs
using System;
using System.Net.Http;
using System.Threading.Tasks;

public class AwaitOperator
{
    public static async Task Main()
    {
        Task<int> downloading = DownloadDocsMainPageAsync();
        Console.WriteLine($"{nameof(Main)}: Launched downloading.");

        int bytesLoaded = await downloading;
        Console.WriteLine($"{nameof(Main)}: Downloaded {bytesLoaded} bytes.");
    }

    private static async Task<int> DownloadDocsMainPageAsync()
    {
        Console.WriteLine($"{nameof(DownloadDocsMainPageAsync)}: About to start downloading.");

        var client = new HttpClient();
        byte[] content = await client.GetByteArrayAsync("https://learn.microsoft.com/en-us/");

        Console.WriteLine($"{nameof(DownloadDocsMainPageAsync)}: Finished downloading.");
        return content.Length;
    }
}
// Output similar to:
// DownloadDocsMainPageAsync: About to start downloading.
// Main: Launched downloading.
// DownloadDocsMainPageAsync: Finished downloading.
// Main: Downloaded 27700 bytes.
```




```cs
class Program
 {
   static async Task Main(string[] args)
   {
     await callMethod();
     Console.ReadKey();
   }

   public static async Task callMethod()
   {
     Method2();
     var count = await Method1();
     Method3(count);
   }

   public static async Task<int> Method1()
   {
     int count = 0;
     await Task.Run(() =>
     {
       for (int i = 0; i < 100; i++)
       {
         Console.WriteLine(" Method 1");
         count += 1;
       }
     });
     return count;
   }

   public static void Method2()
   {
     for (int i = 0; i < 25; i++)
     {
       Console.WriteLine(" Method 2");
     }
   }

   public static void Method3(int count)
   {
     Console.WriteLine("Total count is " + count);
   }
}
```

> `async` and `await` always used together
### ref
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/async

https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/await

https://learn.microsoft.com/en-us/dotnet/csharp/asynchronous-programming/async-scenarios

https://www.c-sharpcorner.com/article/async-and-await-in-c-sharp/



