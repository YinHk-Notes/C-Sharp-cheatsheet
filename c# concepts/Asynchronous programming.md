## Asynchronous programming

Asynchronous programming is a programming technique that allows code to be executed concurrently without blocking the execution of the calling thread. In other words, asynchronous code can run in the background while other code is executing. In synchronous programming, each line of code is executed sequentially, and the program waits for each operation to complete before moving on to the next one. This can lead to performance problems, particularly in programs that need to perform long-running operations like I/O or network requests.


Asynchronous programming allows programs to perform these operations without blocking the calling thread. When an asynchronous operation is started, the program continues to execute other code while it waits for the operation to complete. The program is notified when the operation is complete and can continue with the following line of code.

Asynchronous programming can be implemented using various techniques, such as callbacks, events, and promises. In C#, the "async" and "await" keywords provide a convenient way to write asynchronous code that looks similar to synchronous code, making it easier to read and maintain.

### ref
https://www.c-sharpcorner.com/article/async-and-await-in-c-sharp/

https://learn.microsoft.com/en-us/dotnet/csharp/asynchronous-programming/

