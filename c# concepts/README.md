## Compiling and Executing C# Program

```cs
using System;

namespace HelloWorldApplication {
   class HelloWorld {
      static void Main(string[] args) {
         /* my first program in C# */
         Console.WriteLine("Hello World");
         Console.ReadKey();
      }
   }
}
```


If you are using Visual Studio.Net for compiling and executing C# programs, take the following steps −

-   Start Visual Studio.
    
-   On the menu bar, choose File -> New -> Project.
    
-   Choose Visual C# from templates, and then choose Windows.
    
-   Choose Console Application.
    
-   Specify a name for your project and click OK button.
    
-   This creates a new project in Solution Explorer.
    
-   Write code in the Code Editor.
    
-   Click the Run button or press F5 key to execute the project. A Command Prompt window appears that contains the line Hello World.
    

You can compile a C# program by using the command-line instead of the Visual Studio IDE −

-   Open a text editor and add the above-mentioned code.
    
-   Save the file as **helloworld.cs**
    
-   Open the command prompt tool and go to the directory where you saved the file.
    
-   Type **csc helloworld.cs** and press enter to compile your code.
    
-   If there are no errors in your code, the command prompt takes you to the next line and generates **helloworld.exe** executable file.
    
-   Type **helloworld** to execute your program.
    
-   You can see the output Hello World printed on the screen.



### ref 
https://www.tutorialspoint.com/csharp/csharp_program_structure.htm
https://learn.microsoft.com/en-us/visualstudio/get-started/csharp/run-program?view=vs-2022

