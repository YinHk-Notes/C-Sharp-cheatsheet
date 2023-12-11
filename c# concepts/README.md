

C# 程式會在 **.NET** 上執行，這是稱為 Common Language Runtime 的虛擬執行系統， (CLR) 和一組類別庫。


The easiest way to get started with C#, is to use an IDE. Using Visual studio for C#

Applications written in C# use the **.NET** Framework, so it makes sense to use Visual Studio, as the program, the framework, and the language, are all created by Microsoft.

To install C#, install Visual studio first. Once the **Visual Studio Installer** is downloaded and installed, choose the **.NET**, and install.

Microsoft Visual Studio is an integrated development environment (IDE) from Microsoft. It is used to develop computer programs for Microsoft Windows. Visual Studio is one stop shop for all applications built on the .Net platform. One can develop, debug and run applications using Visual Studio.



#### Using C# in VS code

You can install it from within VS Code by searching for **'C# Dev Kit'** in the Extensions view **(Ctrl+Shift+X)** or if you already have a project with C# files, VS Code will prompt you to install the extension as soon as you open a C# file.

https://code.visualstudio.com/docs/languages/csharp

#### C# version
The latest C# compiler determines a default language version based on your project's target framework or frameworks. Visual Studio doesn't provide a UI to change the value, but you can change it by editing the **_csproj_** file.


Checking C# Version in Visual Studio:

In Visual Studio, you can easily check the C# version by inspecting the project properties. Follow these steps:

1.  Right-click on your project in the Solution Explorer.
2.  Select `Properties`.
3.  Navigate to the `Build` tab.
4.  Click on the `Advanced` button at the bottom of the Build tab.
5.  In the `Language version` dropdown, you can see the current C# version used in your project.

You can detect the C# version you are using in various ways, such as examining your project file or using specific command line tools.


To find the C# version of a specific project, you can inspect the `_.csproj_` file and look for the **`<LangVersion>`** tag


Visual Studio plays an essential role in determining the **C# version** you’re using 🔧.

To check or change the C# version, navigate to the advanced build settings in your project (**Project > Properties > Build**) 👩‍💻. There, you’ll see all the C# versions available, including the latest language version.

Alternatively, you can also type in the developer cmd prompt obtained via **`Visual Studio > View > Terminal`**:

```
csc -langversion:?
```



C# versions are closely tied to the **.NET Framework**. In fact, each C# release usually corresponds to a .NET Framework version:

-   C# 1.0 with .NET 1.0
-   C# 1.2 with .NET 1.1
-   C# 2.0 with .NET 2.0
-   C# 3.0 with .NET 3.5

… and so on


With **.NET Core**, versioning becomes more flexible. Each **.NET SDK** version comes with a specific C# language version, allowing you to use newer C# features in your projects. However, the default language version depends on your project’s target framework(s). You can find and change this value by editing the **_csproj_** file 

https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/configure-language-version

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

https://learn.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-debugger?view=vs-2022

https://learn.microsoft.com/en-us/visualstudio/ide/compiling-and-building-in-visual-studio?view=vs-2022

https://learn.microsoft.com/en-us/visualstudio/test/getting-started-with-unit-testing?toc=%2Fvisualstudio%2Fget-started%2Fcsharp%2Ftoc.json&bc=%2Fvisualstudio%2Fget-started%2Fcsharp%2Fbreadcrumb%2Ftoc.json&view=vs-2022&tabs=dotnet%2Cmstest

https://learn.microsoft.com/en-us/visualstudio/deployment/?view=vs-2022





