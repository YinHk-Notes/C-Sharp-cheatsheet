## Namespace

### Why using namespace?
- Namespaces used to organize its many classes.
- Namespace also solves the problem of naming conflict.
- Declaring your own namespaces can help you **control the scope of class and method** names in larger programming projects.
- Similar to **"Package"** in java

### Namespaces have the following properties:

- They organize large code projects.
- They're delimited by using the `.` operator.
- The using directive obviates the requirement to specify the name of the namespace for every class.
- The global namespace is the "root" namespace: global`::`System will always refer to the .NET System namespace.
- Namespaces in C# can be nested.
- If two classes are in the same namespace, they will **'know'** about each other and be in the **same scope**.



The namespace keyword is used to **declare a scope**. The ability to create scopes within your project helps organise code and lets you create globally-unique types.


A namespace in C# is a logically **arranged class, struct, interface, enum, or delegate**. **Namespaces in C# can be nested**, meaning you can define a class and include it in another class.

A class in a specific namespace and a class from another **`.cs`** file can be called by **`using <namespace>;`**.




```cs
namespace N1     // N1
{
    class C1      // N1.C1
    {
        class C2   // N1.C1.C2
        {
        }
    }
    namespace N2  // N1.N2
		{
        class C2   // N1.N2.C2
        {
        }
    }
}
```

### Class with same namespace

To give a class a namespace, we simply wrap the class in another set of curly braces and declare the namespace like this:
```cs
namespace ExampleNameSpace
{

  public class ExampleClass
  {
    // all ExampleClass methods, fields, and properties here
  }

}

```
We can wrap other classes in the same namespace to make them available to each other:
```cs
namespace ExampleNameSpace
{

  public class SecondClass
  {
    // all SecondClass methods, fields, and properties here
  }

}

```

Examplpe:
```cs
namespace App
{
    public class MyClass
    {
        public MyClass()
        {
            myVariable = 1;
        }
    
        public int myVariable;

        public static int StaticVariable = 3;
    
    }
}
```

```cs
using App; // at the beginning of your .cs file
MyClass myClass = new MyClass();
var v = myClass.myVariable; // defined in the App namespace
var stat = MyClass.StaticVariable;
```

or you can use the **full identifier**
```
Namespace-Name.Member-Name
```
```
MyNamespace.MyClass myClass = new MyNamespace.MyClass();
```
Eg:
```cs
App.MyClass myClass = new App.MyClass();
var v = myClass.myVariable;
var stat = App.MyClass.StaticVariable;
```


```cs
using System;

namespace MyNamespace
{
    public class SampleClass
    {
        public static void myMethod()
        {
            Console.WriteLine("Creating my namespace");
        }
    }
}
 
namespace MyProgram
{
    public class MyClass
    {
        public static void Main()
        {
            MyNamespace.SampleClass.myMethod();
        }
    }
}
```

### Nested Namespace 
```
namespace MyNamespace
{
    namespace NestedNamespace
    {
        // Body of nested namespace
	}
}
```
> The nested namespace and its members can also be accessed using the `dot (.)` operator.

```cs
using System;
 
// Nested Namespace
namespace MyNamespace
{
    namespace Nested
    {
        public class SampleClass
        {
            public static void myMethod()
            {
                Console.WriteLine("Nested Namespace Example");
            }
        }
    }
}
 
namespace MyProgram
{
    public class MyClass
    {
        public static void Main()
        {
            MyNamespace.Nested.SampleClass.myMethod();
        }
    }
}
```




### How to access other class
- If a class in different namespace, use **`using <namespace>`** to Include a Class Into Another Class in C#.
- If a class in same namespace, no need to use **`using <namespace>`** or specify the **full identifier**. Just direct refer a class, if it exists within the same directory tree.
- Use **Inheritance** to Include a Class Into Another Class in C#


### Use `using <namespace>`

The keyword `using` is called a **directive**. It tells C# that the code in this file will be "using" code that isn't contained in this file or in this file's namespace. Our `using` statements import other namespaces that contain the code our file needs.

Example:

```cs
// WelcomeClass.cs

namespace SubClassNamS
{
    public class WelcomeClass
    {
        public static void Welcome()
        {
            // To show a message box when this method from `WelcomeClass` will be called by another class
            MessageBox.Show("Hello World!", "Test Subject", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
```


```cs
// Form1.cs

// Use `using` Namespace of another class from a different file
using static SubClassNamS.WelcomeClass;

namespace IncludeClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Button `Button1` click event
        private void button1_Click(object sender, EventArgs e)
        {
            // No need to mention `WelcomeClass` here
            Welcome();
        }
    }
}
```
> Including `SubClassNamS.WelcomeClass` enables us to access `WelcomeClass` from the `SubClassNamS` namespace.

> This method helps you import or include a `WelcomeClass` class into the `Form1` class by introducing its methods and members using namespace in C#.


> `using <namespace>` directive imports the types contained in the given namespace, but specifically **does not import nested namespaces.** This is to avoid naming conflics and explains why we must import both `System` to use `Console` and `System.Collections.Generic` to use `List`s even though the latter namespace is nested in the former.

> When we create namespaces, we want to make sure they tell us something useful by naming them in a descriptive manner. A convention in C# is to use our directory structure to define our namespaces.



### Same namespace across multiple different files

> Namespaces can (and usually are) split across multiple code files.

> The Contacts namespace will contain all classes defined across files that define that namespace.


> The classes in those namespaces are compiled separately, but (generally, leaving out external resources for now) into a single output file (i.e. an exe or a dll).

### Define packages and namespaces
https://learn.microsoft.com/zh-tw/previous-versions/visualstudio/visual-studio-2015/modeling/define-packages-and-namespaces?view=vs-2015&redirectedfrom=MSDN


### ref 
https://www.c-sharpcorner.com/article/working-with-namespaces-in-C-Sharp/

https://www.delftstack.com/howto/csharp/csharp-include-class/

https://www.learnhowtoprogram.com/fidgetech-3-c-and-net/3-0-lessons-25-34-objects-and-methods/3-0-0-28-namespaces-and-file-structure

https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-directive





