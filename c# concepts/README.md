

C# 程式會在 .NET 上執行，這是稱為 Common Language Runtime 的虛擬執行系統， (CLR) 和一組類別庫。

### Write & edit code in C#

#### Create a new code file


Start by creating a new file and adding some code to it.

1.  Open Visual Studio. Press **Esc**, or choose **Continue without code** on the start window, to open the development environment.
    
2.  From the **File** menu on the menu bar, choose **New** > **File**, or press **Ctrl**+**N**.
    
3.  In the **New File** dialog box, under the **General** category, choose **Visual C# Class**, and then choose **Open**.
    
    A new file opens in the editor with the skeleton of a C# class. You don't have to create a full Visual Studio project to gain some of the benefits that the code editor offers—all you need is a code file.


#### Use code snippets
Visual Studio provides useful code snippets that you can use to quickly and easily generate commonly used code blocks. 


Let's add the C# `void Main` snippet to our file.

1.  Place your cursor just above the final closing brace **`}`** in the file, and type the characters `svm`. `svm` stands for `static void Main`—don't worry if you don't know what that means yet.
    
    A pop-up dialog box appears with information about the `svm` code snippet.

2. Press **Tab** twice to insert the code snippet.

   You'll see the `static void Main()` method signature get added to the file. The Main() method is the entry point for C# applications.


> **Note**: Available code snippets vary for different programming languages. You can look at the available code snippets for your language by choosing **Edit** > **IntelliSense** > **Insert Snippet** or pressing **Ctrl**+**K**, **Ctrl**+**X**, and then choosing the folder for your programming language.

https://learn.microsoft.com/en-us/visualstudio/ide/code-snippets?view=vs-2022

https://learn.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-editor?view=vs-2022

### Compiling and Executing C# Program

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
    
-   Type **"csc helloworld.cs"** and press enter to compile your code.
    
-   If there are no errors in your code, the command prompt takes you to the next line and generates **helloworld.exe** executable file.
    
-   Type **helloworld** to execute your program.
    
-   You can see the output Hello World printed on the screen.


How to run a program depends on what you start from, the type of program, and whether you want to run under the debugger. In the simplest case, to build and run an open project in Visual Studio:

-   Press **F5**, choose **Debug** > **Start with debugging** from the Visual Studio menu, or select the green **Start** arrow and project name on the Visual Studio toolbar.
-   Or, to run without debugging, press **Ctrl**+**F5** or choose **Debug** > **Start without debugging** from the Visual Studio menu.

### ref 

https://learn.microsoft.com/en-us/visualstudio/get-started/csharp/run-program?view=vs-2022

https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/

https://learn.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-console?view=vs-2022






