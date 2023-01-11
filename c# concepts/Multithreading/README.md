## Multithreading


By default, every process has at least one thread that is responsible for executing the application code and that thread is called Main Thread. So, every application by default is a **single-threaded application**.

```cs
using System;
namespace ThreadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Method1();
            Method2();
            Method3();
            Console.Read();
        }

        static void Method1()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method1 :" + i);
            }
        }
        
        static void Method2()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method2 :" + i);
            }
        }

        static void Method3()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method3 :" + i);
            }
        }
    }
}
```

```cs
using System.Threading;
using System;
namespace ThreadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Method1();
            Method2();
            Method3();
            Console.Read();
        }
        static void Method1()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method1 :" + i);
            }
        }

        static void Method2()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method2 :" + i);
                if (i == 3)
                {
                    Console.WriteLine("Performing the Database Operation Started");
                    //Sleep for 10 seconds
                    Thread.Sleep(10000);
                    Console.WriteLine("Performing the Database Operation Completed");
                }
            }
        }
        static void Method3()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method3 :" + i);
            }
        }
    }
}
```
A process by default makes use of a single thread to run our application code but a process can have multiple threads, and multiple threads can run our application code simultaneously. 

The advantage is that the execution takes place simultaneously. So, when multiple threads try to execute the application code, then the operating system allocates some time period for each thread to execute.

https://www.huanlintalk.com/2013/04/csharp-notes-multithreading-1.html

https://dotnettutorials.net/lesson/multithreading-in-csharp/
